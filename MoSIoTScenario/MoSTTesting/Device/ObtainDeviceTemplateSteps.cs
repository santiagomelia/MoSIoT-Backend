using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System.Collections.Generic;
using TechTalk.SpecFlow;
namespace MoSTTesting.Device
{
    [Binding]
    public class ObtainDeviceTemplateSteps
    {

        public static DeviceTemplateCEN deviceTemplateCEN;
        public static DeviceTemplateEN deviceTemplateEN;
        public static IList<DeviceTemplateEN> deviceTemplateListEN = new List<DeviceTemplateEN>();
        public static IList<int> idDeviceTemplates = new List<int>();


        [Before(tags: "obtainDeviceTemplates")]
        public static void InitializeData()
        {
            deviceTemplateCEN = new DeviceTemplateCEN();
            idDeviceTemplates.Add(deviceTemplateCEN.New_("Device1", DeviceTypeEnum.gateway,true));
            idDeviceTemplates.Add(deviceTemplateCEN.New_("Device2", DeviceTypeEnum.sensor, false));
            idDeviceTemplates.Add(deviceTemplateCEN.New_("Device3", DeviceTypeEnum.actuator, true));

        }

        [After(tags: "Having Device Templates")]
        public static void CleanData()
        {
            if (deviceTemplateListEN.Count > 0)
                foreach (var deviceTemplate in idDeviceTemplates)
                {
                    deviceTemplateCEN.Destroy(deviceTemplate);
                }

        }


        [Given(@"having a list of Device Templates")]
        public void GivenHavingAListOfDeviceTemplates()
        {
            deviceTemplateCEN = new DeviceTemplateCEN();
        }
        
        [When(@"obtain Device Templates")]
        public void WhenObtainDeviceTemplates()
        {
            deviceTemplateListEN = deviceTemplateCEN.ReadAll(0, -1);

        }
        
        [Then(@"get a list of available Device Templates")]
        public void ThenGetAListOfAvailableDeviceTemplates()
        {
            Assert.IsTrue(deviceTemplateListEN.Count > 0);
        }
    }
}
