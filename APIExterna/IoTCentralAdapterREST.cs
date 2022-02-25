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
using Newtonsoft.Json.Linq;

namespace APIExterna
{
    public class IoTCentralAdapterREST
    {
        const string APP_NAME = "mosiotalzheimer";
        const string ACCESS_TOKEN = @"SharedAccessSignature sr=849f84f9-b7f0-4638-9932-25893f52dea2&sig=0TPcUHrOGg9S4w0tcNgeJC6HEAHoQwmD0QJ2oEEx9HE%3D&skn=ADMINTOKEN&se=1653125144141";
        const string VERSION = "1.0";

        async public void ListarDeviceTemplates()
        {

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", ACCESS_TOKEN);
            httpClient.DefaultRequestHeaders.Add("api-version", VERSION);
            var deviceTemplatesClient = new DeviceTemplatesClient(httpClient);
            deviceTemplatesClient.BaseUrl = "https://" + APP_NAME + ".azureiotcentral.com/api/";
            // string deviceTemplate = @"dtmi:continuousPatientMonitoringTemplate:Smart_Vitals_Patch_220;1";

            DeviceTemplateCollection result = await deviceTemplatesClient.ListAsync();

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);

        }


        async public void ListarDeviceDeDeviceTemplate()
        {

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", ACCESS_TOKEN);
            httpClient.DefaultRequestHeaders.Add("api-version", VERSION);
            var deviceTemplatesClient = new DeviceTemplatesClient(httpClient);
            deviceTemplatesClient.BaseUrl = "https://" + APP_NAME + ".azureiotcentral.com/api/";
            string deviceTemplate = @"dtmi:continuousPatientMonitoringTemplate:Smart_Vitals_Patch_220;1";

            DeviceCollection result = await deviceTemplatesClient.ListDevicesAsync(deviceTemplate);

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);

        }

        async public Task<JObject> ListarDeviceTelemetry(string idDevice, string Telemetry)
        {
            JObject result = null;
            try
            {
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Authorization", ACCESS_TOKEN);
                httpClient.DefaultRequestHeaders.Add("api-version", VERSION);
                var deviceTemplatesClient = new DeviceTemplatesClient(httpClient);
                deviceTemplatesClient.BaseUrl = "https://" + APP_NAME + ".azureiotcentral.com/api/";
                // string deviceTemplate = @"dtmi:continuousPatientMonitoringTemplate:Smart_Vitals_Patch_220;1";

                result = await deviceTemplatesClient.ListDeviceTelemetries(idDevice, Telemetry);

              //  int milliseconds = 5000;
               // Thread.Sleep(milliseconds);

                // string json = JsonConvert.SerializeObject(result, Formatting.None);
                //Console.WriteLine(json);
                //return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace.ToString());
            }
           
            return result;
        }


        async public void ModificarDeviceTemplate()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", ACCESS_TOKEN);
            var deviceTemplatesClient = new DeviceTemplatesClient(httpClient);
            deviceTemplatesClient.BaseUrl = "https://" + APP_NAME + ".azureiotcentral.com/api/";

            string template;
            using (StreamReader r = new StreamReader(Path.Combine(System.AppContext.BaseDirectory, "template.json")))
            {
                template = r.ReadToEnd();
            }

            var a = Newtonsoft.Json.JsonConvert.DeserializeObject<DeviceTemplate>(template);

            var result = await deviceTemplatesClient.SetAsync(a, "urn:jlqzoun1k:modelDefinition:kprwlytc22");

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }


        async public void GetToken()
        {

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", ACCESS_TOKEN);
            httpClient.DefaultRequestHeaders.Add("api-version", VERSION);
            ApiTokensClient apiTokensClient = new ApiTokensClient(httpClient);
            apiTokensClient.BaseUrl = "https://" + APP_NAME + ".azureiotcentral.com/api/";


            ApiTokenCollection result = await apiTokensClient.ListAsync();

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);

        }




    
        
    }
}
