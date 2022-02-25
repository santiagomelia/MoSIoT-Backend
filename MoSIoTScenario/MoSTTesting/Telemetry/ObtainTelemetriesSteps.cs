using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace MoSTTesting.Telemetry
{
    [Binding]
    public class ObtainTelemetriesSteps
    {

        public static TelemetryCEN telemetryCEN;
        public static TelemetryEN telemetryEN;
        public static IList<TelemetryEN> telemetryListEN = new List<TelemetryEN>();
        public static IList<int> idTelemetries = new List<int>();
        public static int idDevice = -1;


        [Before(tags: "obtainTelemetries")]
        public static void InitializeData()
        {
            DeviceTemplateEN deviceTemplate = new DeviceTemplateEN()
            {
                Name = "device name",
                Type = DeviceTypeEnum.actuator,
                IsEdge = false
            };
            idDevice = new DeviceTemplateCEN().New_(deviceTemplate.Name, deviceTemplate.Type, deviceTemplate.IsEdge);



            telemetryCEN = new TelemetryCEN();
            idTelemetries.Add(telemetryCEN.New_(idDevice, 12.2, DataTypeEnum.Integer, TypeUnitEnum.percent, "Heart Rate0", TelemetryTypeEnum.sensor));
            idTelemetries.Add(telemetryCEN.New_(idDevice, 65.2, DataTypeEnum.Integer, TypeUnitEnum.degrees_farenheit, "Heart Rate1", TelemetryTypeEnum.state));
            idTelemetries.Add(telemetryCEN.New_(idDevice, 45.2, DataTypeEnum.Integer, TypeUnitEnum.geolocation, "Heart Rate2", TelemetryTypeEnum.location));

        }

        [After(tags: "Having Device Templates")]
        public static void CleanData()
        {
            if (telemetryListEN.Count > 0)
                foreach (var telemetry in idTelemetries)
                {
                    telemetryCEN.Destroy(telemetry);
                }

        }


        [Given(@"having a list of telemetries")]
        public void GivenHavingAListOfTelemetries()
        {
            telemetryCEN = new TelemetryCEN();
        }
        
        [When(@"obtain telemetries")]
        public void WhenObtainTelemetries()
        {
            telemetryListEN = telemetryCEN.ReadAll(0, -1);
        }
        
        [Then(@"get a list of available telemetries")]
        public void ThenGetAListOfAvailableTelemetries()
        {
            Assert.IsTrue(telemetryListEN.Count > 0);
        }
    }
}
