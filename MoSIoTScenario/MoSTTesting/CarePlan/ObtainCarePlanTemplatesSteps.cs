using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace MoSTTesting.CarePlan
{
    [Binding]
    public class ObtainCarePlanTemplatesSteps
    {

        public static CarePlanTemplateCEN carePlanTemplateCEN;
        public static CarePlanTemplateEN carePlanTemplateEN;
        public static IList<CarePlanTemplateEN> carePlanTemplateListEN = new List<CarePlanTemplateEN>();
        public static IList<int> idCarePlanTemplates = new List<int>();

        [Before(tags: "obtain Care Plan Templates")]
        public static void InitializeData()
        {
            carePlanTemplateCEN = new CarePlanTemplateCEN();
            idCarePlanTemplates.Add(carePlanTemplateCEN.New_(CareStatusEnum.completed, CarePlanIntentEnum.order, "Plan de cuidado 1", DateTime.Now, 100, "Nombre 1", "Description1"));
            idCarePlanTemplates.Add(carePlanTemplateCEN.New_(CareStatusEnum.onHold, CarePlanIntentEnum.proposal, "Plan de cuidado 2", DateTime.Now, 100, "Nombre 2" ,"Description2"));
            idCarePlanTemplates.Add(carePlanTemplateCEN.New_(CareStatusEnum.active, CarePlanIntentEnum.option, "Plan de cuidado 3", DateTime.Now, 100, "Nombre 3", "Description3"));

        }

        [After(tags: "Having Care Plan Templates")]
        public static void CleanData()
        {
            if (carePlanTemplateListEN.Count > 0)
                foreach (var carePlanTemplate in idCarePlanTemplates)
                {
                    carePlanTemplateCEN.Destroy(carePlanTemplate);
                }

        }


        [Given(@"having a list of Care plan templates")]
        public void GivenHavingAListOfCarePlanTemplates()
        {
            carePlanTemplateCEN = new CarePlanTemplateCEN();
        }
        
        [When(@"obtain Care Plan Templates")]
        public void WhenObtainCarePlanTemplates()
        {
            carePlanTemplateListEN = carePlanTemplateCEN.ReadAll(0, -1);
        }
        
        [Then(@"get a list of available Care Plan Templates")]
        public void ThenGetAListOfAvailableCarePlanTemplates()
        {
            Assert.IsTrue(carePlanTemplateListEN.Count > 0);
        }
    }
}
