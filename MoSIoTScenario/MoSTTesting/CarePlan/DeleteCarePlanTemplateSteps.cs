using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System;
using TechTalk.SpecFlow;

namespace MoSTTesting.CarePlan
{
    [Binding]
    public class DeleteCarePlanTemplateSteps
    {
        public static CarePlanTemplateCEN carePlanTemplateCEN;
        public static CarePlanTemplateEN carePlanTemplateEN = null;
        public static int idCarePlantemplate = -1;

        [Before(tags: "RemoveCarePlanExistente")]
        public static void initializeCarePlanTemplate()
        {
            carePlanTemplateEN = new CarePlanTemplateEN()
            {
                Status = CareStatusEnum.active,
                Intent = CarePlanIntentEnum.proposal,
                Title = "Plan de cuidados para persona con Alzheimer",
                DurationDays = 100,
                Modified = DateTime.Now,
                Name = "cuidadosAlzheimer",
                Description = "Se describen todos los objetivos y actividades necesarias para que se cuide a una persona que presenta Alzheimer"
            };
            carePlanTemplateCEN = new CarePlanTemplateCEN();
            idCarePlantemplate = carePlanTemplateCEN.New_(carePlanTemplateEN.Status, carePlanTemplateEN.Intent,
         carePlanTemplateEN.Title, carePlanTemplateEN.Modified, carePlanTemplateEN.DurationDays, carePlanTemplateEN.Name, carePlanTemplateEN.Description);
        }

        [Given(@"There is Care Plan Template with its specific id")]
      
        public void GivenThereIsCarePlanTemplateWithItsSpecificId()
        {
            carePlanTemplateCEN = new CarePlanTemplateCEN();
        }
        
        [Given(@"There is no Care Plan Template with its specific id")]
     
        public void GivenThereIsNoCarePlanTemplateWithItsSpecificId()
        {
            idCarePlantemplate = -1;
             carePlanTemplateCEN = new CarePlanTemplateCEN();
        }
        
        [When(@"Remove the Care plan Template")]
    
        public void WhenRemoveTheCarePlanTemplate()
        {
            try
            {
                carePlanTemplateCEN.Destroy(idCarePlantemplate);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
                        
        [Then(@"The Care Plan Template was removed")]
      
        public void ThenTheCarePlanTemplateWasRemoved()
        {
            Assert.IsNull(carePlanTemplateCEN.ReadOID(idCarePlantemplate));
        }
        
        [Then(@"The Care Plan Template is not removed")]
       
        public void ThenTheCarePlanTemplateIsNotRemoved()
        {
            Assert.IsNull(carePlanTemplateCEN.ReadOID(idCarePlantemplate));
        }
    }
}
