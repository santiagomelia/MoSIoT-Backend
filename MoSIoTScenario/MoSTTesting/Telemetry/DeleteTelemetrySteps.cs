using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System;
using TechTalk.SpecFlow;
namespace MoSTTesting.Telemetry
{
    [Binding]
    public class DeleteTelemetrySteps
    {
        public static TelemetryCEN telemetryCEN;
        public static TelemetryEN telemetryEN = null;
        public static int telemetryId = -1, idDevice;


        [Before(tags: "CreateDeviceTemplateParaTelemetry")]
        public static void InitializeData()
        {

            DeviceTemplateEN deviceTemplate = new DeviceTemplateEN()
            {
                Name = "device name",
                Type = DeviceTypeEnum.actuator,
                IsEdge = false
            };
            idDevice = new DeviceTemplateCEN().New_(deviceTemplate.Name, deviceTemplate.Type, deviceTemplate.IsEdge);
            telemetryId = telemetryCEN.New_(idDevice, 12.2, DataTypeEnum.Integer, TypeUnitEnum.percent, "Heart Rate", TelemetryTypeEnum.state);
        }


        [After(tags: "Cleaning")]
        public static void CleanData()
        {
            telemetryCEN.Destroy(telemetryId);
            new DeviceTemplateCEN().Destroy(idDevice);
        }

        [Given(@"There is Telemetry with its specific id")]
        public void GivenThereIsTelemetryWithItsSpecificId()
        {
            telemetryCEN = new TelemetryCEN();
        }
        
        [Given(@"There is no Telemetry with its specific id")]
        public void GivenThereIsNoTelemetryWithItsSpecificId()
        {
            telemetryId = -1;
            telemetryCEN = new TelemetryCEN();
        }
        
        [When(@"Remove the Telemetry")]
        public void WhenRemoveTheTelemetry()
        {
            try
            {
                telemetryCEN.Destroy(telemetryId);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
        
        [When(@"Remove the Telemetry non-existent")]
        public void WhenRemoveTheTelemetryNon_Existent()
        {
            telemetryId = -1;
        }
        
        [Then(@"The Telemetry was removed")]
        public void ThenTheTelemetryWasRemoved()
        {
            Assert.IsNull(telemetryCEN.ReadOID(telemetryId));
        }
        
        [Then(@"The Telemetry is not removed")]
        public void ThenTheTelemetryIsNotRemoved()
        {
            Assert.IsNull(telemetryCEN.ReadOID(telemetryId));
        }
    }
}
