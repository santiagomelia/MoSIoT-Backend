using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AzureMapsToolkit;
using IoTCentral;
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Provisioning.Client;
using Microsoft.Azure.Devices.Provisioning.Client.Transport;
using Microsoft.Azure.Devices.Shared;
using Newtonsoft.Json;

namespace APIExterna
{
    public class IoTCentralAdapterMQTT
    {
        const string APP_NAME = "mosiotalzheimer";
        const string ACCESS_TOKEN = @"SharedAccessSignature sr=849f84f9-b7f0-4638-9932-25893f52dea2&sig=0TPcUHrOGg9S4w0tcNgeJC6HEAHoQwmD0QJ2oEEx9HE%3D&skn=ADMINTOKEN&se=1653125144141";
        const string VERSION = "1.0";


        // Variables Azure.Device.Client


        const string noEvent = "none";
        static string eventText = noEvent;

        static string ScopeID = "0ne002B95CE"; // Se obtiene del Azure Central en la página Administraion->Device Connection->ID scope
        static string DeviceID = "24bjobtcf8i";
        static string PrimaryKey = "nXYg20XDtgz7vrSLWJlFyAXkmWEgGQ2Ho43BFParefYDtHaKRFzHxVRx3F8b+kV31bly70i1X3ToBxS4it19lQ=="; // Se obtiene del Azure Central en la página Administraion->Device Connection->ID scope
        static string AzureMapsKey = "j74me0q4cA72JfiUS6J8lH/2vLiaOIzN41jw41R892hTzBZ2KIm3eSWl4w2rWlUufXU995gkHqDl31mYo8pYzQ==";

        static DeviceClient s_deviceClient;
        static CancellationTokenSource cts;
        //static string GlobalDeviceEndpoint = "global.azure-devices-provisioning.net";
        static string GlobalDeviceEndpoint = "global.azure-devices-provisioning.net";
        static TwinCollection reportedProperties;

        static double[,] customer = new double[,]
       {                    
            // Lat/lon position of customers.
            // Gasworks Park
            {47.645892, -122.336954},

            // Golden Gardens Park
            {47.688741, -122.402965},

            // Seward Park
            {47.551093, -122.249266},

            // Lake Sammamish Park
            {47.555698, -122.065996},

            // Marymoor Park
            {47.663747, -122.120879},

            // Meadowdale Beach Park
            {47.857295, -122.316355},

            // Lincoln Park
            {47.530250, -122.393055},

            // Gene Coulon Park
            {47.503266, -122.200194},

            // Luther Bank Park
            {47.591094, -122.226833},

            // Pioneer Park
            {47.544120, -122.221673 }
       };

        static double[,] path;                          // Lat/lon steps for the route.
        static double[] timeOnPath;                     // Time in seconds for each section of the route.
        static int truckOnSection;                      // The current path section the truck is on.
        static double truckSectionsCompletedTime;       // The time the truck has spent on previous completed sections.
        static Random rand;


       
        enum StateEnum
        {
            ready,
            enroute,
            delivering,
            returning,
            loading,
            dumping
        };
        enum ContentsEnum
        {
            full,
            melting,
            empty
        }
        enum FanEnum
        {
            on,
            off,
            failed
        }

        // Azure maps service globals.
        static AzureMapsServices azureMapsServices;

        // Telemetry globals.
        const int intervalInMilliseconds = 5000;

        static FanEnum fan = FanEnum.on;                // Cooling fan state.
        static ContentsEnum contents = ContentsEnum.full;    // Truck contents state.
        static StateEnum state = StateEnum.ready;       // Truck is full and ready to go!
        static double optimalTemperature = -5;




        // Se invoca a AzureCentral utilizando MQTT mediante la libreria Microsoft.Azure.Devices.Client 


        public void initializeAzureDeviceClient()
        {
          AzureMapsServices azureMapsServices = new AzureMapsServices(AzureMapsKey);

            try
            {
                using (var security = new SecurityProviderSymmetricKey(DeviceID, PrimaryKey, null))
                {
                    //DeviceRegistrationResult result = RegisterDeviceAsync(security).GetAwaiter().GetResult();
                    //if (result.Status != ProvisioningRegistrationStatusType.Assigned)
                    //{
                    //    Console.WriteLine("Failed to register device");
                    //    return;
                    //}
                    //IAuthenticationMethod auth = new DeviceAuthenticationWithRegistrySymmetricKey(result.DeviceId, (security as SecurityProviderSymmetricKey).GetPrimaryKey());
                    //s_deviceClient = DeviceClient.Create(result.AssignedHub, auth, TransportType.Mqtt);
                    IAuthenticationMethod auth = new DeviceAuthenticationWithRegistrySymmetricKey(DeviceID, (security as SecurityProviderSymmetricKey).GetPrimaryKey());
                    s_deviceClient = DeviceClient.Create("https://" + APP_NAME + ".azureiotcentral.com/api/", auth, TransportType.Mqtt);

                }
                System.Console.WriteLine("Device successfully connected to Azure IoT Central");

                SendDevicePropertiesAsync().GetAwaiter().GetResult();

                Console.Write("Register settings changed handler...");
                s_deviceClient.SetDesiredPropertyUpdateCallbackAsync(HandleSettingChanged, null).GetAwaiter().GetResult();
                Console.WriteLine("Done");

                cts = new CancellationTokenSource();

                // Create a handler for the direct method calls. (TODO: Adaptar al dominio de los dipositivos que utilizamos)
               // s_deviceClient.SetMethodHandlerAsync("GoToCustomer", CmdGoToCustomer, null).Wait();
               // s_deviceClient.SetMethodHandlerAsync("Recall", CmdRecall, null).Wait();

                SendSmartKneeTelemetryAsync(new Random(), cts.Token);

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                cts.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }



        }

        // Properties and writable properties.
        static async Task SendDevicePropertiesAsync()
        {
            reportedProperties = new TwinCollection();
            reportedProperties["TruckID"] = ""; // TODO ID del dispositivo
            await s_deviceClient.UpdateReportedPropertiesAsync(reportedProperties);
            System.Console.WriteLine($"Sent device properties: {System.Text.Json.JsonSerializer.Serialize(reportedProperties)}");
        }


        static void BuildAcknowledgement(TwinCollection desiredProperties, string setting)
        {
            reportedProperties[setting] = new
            {
                value = desiredProperties[setting]["value"],
                status = "completed",
                desiredVersion = desiredProperties["$version"],
                message = "Processed"
            };
        }

        static async Task HandleSettingChanged(TwinCollection desiredProperties, object userContext)
        {
            string setting = "OptimalTemperature";
            if (desiredProperties.Contains(setting))
            {
                BuildAcknowledgement(desiredProperties, setting);
                int optimalTemperature = (int)desiredProperties[setting]["value"];
                System.Console.WriteLine($"Optimal temperature updated: {optimalTemperature}");
            }
            await s_deviceClient.UpdateReportedPropertiesAsync(reportedProperties);
        }



        public static async Task<DeviceRegistrationResult> RegisterDeviceAsync(SecurityProviderSymmetricKey security)
        {
            Console.WriteLine("Register device...");

            using (var transport = new ProvisioningTransportHandlerMqtt(TransportFallbackType.TcpOnly))
            {
                ProvisioningDeviceClient provClient =
                            ProvisioningDeviceClient.Create(GlobalDeviceEndpoint, ScopeID, security, transport);

                Console.WriteLine($"RegistrationID = {security.GetRegistrationID()}");

                Console.Write("ProvisioningClient RegisterAsync...");
                DeviceRegistrationResult result = await provClient.RegisterAsync();

                Console.WriteLine($"{result.Status}");

                return result;
            }
        }


        static async void SendSmartKneeTelemetryAsync(Random rand, CancellationToken token)
        {
            while (true)
            {
                //  UpdateTruck(); /// Aquí debemos actualizar los valores que le pasamos al SmartKnee
                var _eventcreationtime = DateTime.Now;
                // Create the telemetry JSON message.
                var Smart_Knee_Brace_6wm = new
                {

                    Acceleration = new
                    {
                        x = 33,
                        y = 22,
                        z = 11
                    },
                    RangeOfMotion = 100,
                    KneeBend = -1

                };

                var telemetryDataPoint = new { _eventcreationtime, Smart_Knee_Brace_6wm };
                //    TruckState = state.ToString(),
                //    CoolingSystemState = fan.ToString(),
                //    ContentsState = contents.ToString(),
                //    Location = new { lon = currentLon, lat = currentLat },
                //    Event = eventText,
                //};
                var telemetryMessageString = System.Text.Json.JsonSerializer.Serialize(telemetryDataPoint);
                var telemetryMessage = new Message(Encoding.ASCII.GetBytes(telemetryMessageString));

                // Clear the events, as the message has been sent.
                eventText = noEvent;

                Console.WriteLine($"\nTelemetry data: {telemetryMessageString}");

                // Bail if requested.
                token.ThrowIfCancellationRequested();

                // Send the telemetry message.
                await s_deviceClient.SendEventAsync(telemetryMessage);
                System.Console.WriteLine($"Telemetry sent {DateTime.Now.ToShortTimeString()}");

                await Task.Delay(intervalInMilliseconds);
            }
        }


        static Task<MethodResponse> CmdRecall(MethodRequest methodRequest, object userContext)
        {
            switch (state)
            {
                case StateEnum.ready:
                case StateEnum.loading:
                case StateEnum.dumping:
                    eventText = "Already at base";
                    break;

                case StateEnum.returning:
                    eventText = "Already returning";
                    break;

                case StateEnum.delivering:
                    eventText = "Unable to recall - " + state;
                    break;


            }

            // Acknowledge the command.
            if (eventText == noEvent)
            {
                // Acknowledge the direct method call with a 200 success message.
                string result = "{\"result\":\"Executed direct method: " + methodRequest.Name + "\"}";
                return Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(result), 200));
            }
            else
            {
                // Acknowledge the direct method call with a 400 error message.
                string result = "{\"result\":\"Invalid call\"}";
                return Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(result), 400));
            }
        }



        static Task<MethodResponse> CmdGoToCustomer(MethodRequest methodRequest, object userContext)
        {
            try
            {
                // Pick up variables from the request payload, with the field name specified in IoT Central.
                var payloadString = Encoding.UTF8.GetString(methodRequest.Data);
                //var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(payloadString);

                // Parse the input string for name/value pair.
                //string key = dict.Keys.ElementAt(0);
                //int customerNumber = Int32.Parse(dict.Values.ElementAt(0));
                int customerNumber = Int32.Parse(payloadString);


                // Check for a valid key and customer ID.
                if (customerNumber >= 0 && customerNumber < customer.Length)
                {
                    switch (state)
                    {
                        case StateEnum.dumping:
                        case StateEnum.loading:
                        case StateEnum.delivering:
                            eventText = "Unable to act - " + state;
                            break;

                        case StateEnum.ready:
                        case StateEnum.enroute:
                        case StateEnum.returning:
                            if (contents == ContentsEnum.empty)
                            {
                                eventText = "Unable to act - empty";
                            }
                            else
                            {
                                // Set event only when all is good.
                                eventText = "New customer: " + customerNumber.ToString();

                                //destinationLat = customer[customerNumber, 0];
                                //destinationLon = customer[customerNumber, 1];

                                // Find route from current position to destination, storing route.
                                //  GetRoute(StateEnum.enroute);
                            }
                            break;
                    }

                    // Acknowledge the direct method call with a 200 success message.
                    string result = "{\"result\":\"Executed direct method: " + methodRequest.Name + "\"}";
                    return Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(result), 200));
                }
                else
                {
                    eventText = $"Invalid customer: {customerNumber}";

                    // Acknowledge the direct method call with a 400 error message.
                    string result = "{\"result\":\"Invalid customer\"}";
                    return Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(result), 400));
                }
            }
            catch
            {
                // Acknowledge the direct method call with a 400 error message.
                string result = "{\"result\":\"Invalid call\"}";
                return Task.FromResult(new MethodResponse(Encoding.UTF8.GetBytes(result), 400));
            }
        }
        
    }
}
