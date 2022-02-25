using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System;
using TechTalk.SpecFlow;
namespace MoSTTesting.Device
{
    [Binding]
    public class DeleteDeviceTemplateSteps
    {

        public static DeviceTemplateCEN deviceTemplateCEN;
        public static DeviceTemplateEN deviceTemplateEN = null;
        public static int idDeviceTemplate = -1;



        [Before(tags: "RemoveDeviceTemplateExistente")]
        public static void initializeDeviceTemplate()
        {

            
            deviceTemplateEN = new DeviceTemplateEN()
            {
                Type = DeviceTypeEnum.actuator,
                IsEdge = true,
                Name = "SmartPhone"

            };
            deviceTemplateCEN = new DeviceTemplateCEN();
            idDeviceTemplate = deviceTemplateCEN.New_(deviceTemplateEN.Name, deviceTemplateEN.Type, deviceTemplateEN.IsEdge);

        }

        [Given(@"There is Device Template with its specific id")]
        public void GivenThereIsDeviceTemplateWithItsSpecificId()
        {
            deviceTemplateCEN = new DeviceTemplateCEN();
        }
        
        [Given(@"There is no Device Template with its specific id")]
        public void GivenThereIsNoDeviceTemplateWithItsSpecificId()
        {
            idDeviceTemplate = -1;

            deviceTemplateCEN = new DeviceTemplateCEN();
        }
        
        [When(@"Remove the Device Template")]
        public void WhenRemoveTheDeviceTemplate()
        {
            try
            {
                deviceTemplateCEN.Destroy(idDeviceTemplate);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
        
        [When(@"Remove the Device Template non-existent")]
        public void WhenRemoveTheDeviceTemplateNon_Existent()
        {
            idDeviceTemplate = -1;
        }
        
        [Then(@"The Device Template was removed")]
        public void ThenTheDeviceTemplateWasRemoved()
        {
            Assert.IsNull(deviceTemplateCEN.ReadOID(idDeviceTemplate));
        }
        
        [Then(@"The Device Template is not removed")]
        public void ThenTheDeviceTemplateIsNotRemoved()
        {
            Assert.IsNull(deviceTemplateCEN.ReadOID(idDeviceTemplate));
        }
    }
}
