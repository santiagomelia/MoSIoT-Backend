using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using TechTalk.SpecFlow;

namespace MoSTTesting.Device
{
    [Binding]
    public class CreateDeviceTemplateSteps
    {
       public static DeviceTemplateCEN deviceTemplateCEN = new DeviceTemplateCEN();
        public static int deviceId;

        [After(tags: "CreateDeviceTemplate")]
        public static void CleanData()
        {
            deviceTemplateCEN.Destroy(deviceId);
        }

        [Given(@"I want to create a new Device Template")]        
        public void GivenIWantToCreateANewDeviceTemplate()
        {
            deviceTemplateCEN = new DeviceTemplateCEN();
        }
        
        [When(@"Create the Device Template")]      
        public void WhenCreateTheDeviceTemplate()
        {
            deviceId = deviceTemplateCEN.New_("Smartring", DeviceTypeEnum.sensor, false);
        }
        
        [Then(@"The Device Template was created")]       
        public void ThenTheDeviceTemplateWasCreated()
        {
            Assert.IsNotNull(deviceTemplateCEN.ReadOID(deviceId));
        }
    }
}

