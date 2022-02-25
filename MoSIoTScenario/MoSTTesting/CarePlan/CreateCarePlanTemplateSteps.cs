using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System;
using TechTalk.SpecFlow;

namespace MoSTTesting.CarePlan
{
    [Binding]
    public class CreateCarePlanTemplateSteps
    {
        public static CarePlanTemplateCEN carePlanTemplateCEN = new CarePlanTemplateCEN();
        public static int idCarePlantemplate;

        [After(tags: "CleanCarePlanTemplate")]
        public static void CleanData()

        {
            carePlanTemplateCEN.Destroy(idCarePlantemplate);
        }

        [Given(@"I want to create a new Care Plan template")]
        public void GivenIWantToCreateANewCarePlanTemplate()
        {

            carePlanTemplateCEN = new CarePlanTemplateCEN();
        }

        [When(@"Create the Care plan Template")]
        public void WhenCreateTheCarePlanTemplate()
        {
            idCarePlantemplate = carePlanTemplateCEN.New_(CareStatusEnum.active, CarePlanIntentEnum.proposal, "Plan de cuidados para persona con Alzheimer", DateTime.Now, 100, "cuidadosAlzheimer", "Se describen todos los objetivos y actividades para una persona que presenta Alzheimer");

        }

        [Then(@"The Care Plan Template was created")]
        public void ThenTheCarePlanTemplateWasCreated()
        {

            Assert.IsNotNull(carePlanTemplateCEN.ReadOID(idCarePlantemplate));
        }
    }
}
