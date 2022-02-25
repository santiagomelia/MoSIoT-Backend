using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System;
using TechTalk.SpecFlow;



namespace MoSTTesting.Patient
{
    [Binding]
    public class DeletePatientProfileSteps
    {
        public static PatientProfileCEN patientProfileCEN;
        public static PatientProfileEN patientProfileEN = null;
        public static int idPatientProfile = -1;


        [Before(tags: "RemovePatientProfileExistente")]
        public static void initializeCarePlanTemplate()
        {
          
            patientProfileEN = new PatientProfileEN()
            {
               PreferredLanguage = LanguageCodeEnum.es,
               HazardAvoidance = HazardValueEnum.olfactoryHazard,
               Name = "Patient name",
               Description = "Patient description para eliminar",
               Region = "Spain"

            };
            patientProfileCEN = new PatientProfileCEN();
            idPatientProfile = patientProfileCEN.New_(patientProfileEN.PreferredLanguage,patientProfileEN.Region, patientProfileEN.HazardAvoidance, patientProfileEN.Name, patientProfileEN.Description);
  
        }

        [Given(@"There is Patient Profile with its specific id")]
        public void GivenThereIsPatientProfileWithItsSpecificId()
        {
            patientProfileCEN = new PatientProfileCEN();
        }
        
        [Given(@"There is no Patient Profile with its specific id")]
        public void GivenThereIsNoPatientProfileWithItsSpecificId()
        {
            idPatientProfile = -1;
            patientProfileCEN = new PatientProfileCEN();
        }
        
        [When(@"Remove the Patient Profile")]
        public void WhenRemoveThePatientProfile()
        {
            try
            {
                patientProfileCEN.Destroy(idPatientProfile);
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.IsTrue(true);
            }
        }
        
        [When(@"Remove the Patient Profile non-existent")]
        public void WhenRemoveThePatientProfileNon_Existent()
        {
            idPatientProfile = -1;
        }
        
        [Then(@"The Patient Profile was removed")]
        public void ThenThePatientProfileWasRemoved()
        {
            Assert.IsNull(patientProfileCEN.ReadOID(idPatientProfile));
        }
        
        [Then(@"The Patient Profile is not removed")]
        public void ThenThePatientProfileIsNotRemoved()
        {
            
            Assert.IsNull(patientProfileCEN.ReadOID(idPatientProfile));
        }
    }
}
