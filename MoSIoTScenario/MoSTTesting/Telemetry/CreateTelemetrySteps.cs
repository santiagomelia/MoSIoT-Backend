using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System;
using TechTalk.SpecFlow;

namespace MoSTTesting.Telemetry
{
    [Binding]
    public class CreateTelemetrySteps
    {
        public static TelemetryCEN telemetryCEN;
        public static TelemetryEN telemetryEN;
        public static int telemetryId = -1;
        public static int idDevice = -1;

        [Before(tags: "CreateDeviceTemplate")]
        public static void InitializeData()
        {

            DeviceTemplateEN deviceTemplate = new DeviceTemplateEN()
            {
                Name = "device name",
                Type = DeviceTypeEnum.actuator,
                IsEdge = false
            };
            idDevice = new DeviceTemplateCEN().New_(deviceTemplate.Name, deviceTemplate.Type, deviceTemplate.IsEdge);

        }


        [After(tags: "Cleaning")]
        public static void CleanData()
        {
            telemetryCEN.Destroy(telemetryId);
            new DeviceTemplateCEN().Destroy(idDevice);
        }

        [Given(@"I want to create a new Telemetry with specific device")]
        public void GivenIWantToCreateANewTelemetryWithSpecificDevice()
        {
            telemetryCEN = new TelemetryCEN();
        }
        
        [When(@"Create telemetry")]
        public void WhenCreateTelemetry()
        {
            telemetryId = telemetryCEN.New_(idDevice, 12.2, DataTypeEnum.Integer, TypeUnitEnum.percent, "Heart Rate", TelemetryTypeEnum.state);
        }
        
        [Then(@"el telemetry was created")]
        public void ThenElTelemetryWasCreated()
        {
            Assert.IsNotNull(telemetryCEN.ReadOID(telemetryId));
        }
    }
}
