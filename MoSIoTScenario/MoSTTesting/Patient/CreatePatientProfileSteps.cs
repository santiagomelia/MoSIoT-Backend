using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System;
using System.Security.Claims;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MoSTTesting.Patient
{
    [Binding]

    public class CreatePatientProfileSteps
    {
        public static PatientProfileCEN patientProfileCEN = new PatientProfileCEN();
        public static int idPatientProfile;

        [After(tags: "CreatePatientProfile")]
        public static void CleanData()

        {
            patientProfileCEN.Destroy(idPatientProfile);
        }


        [Given(@"I want to create a new Patient Profile")]
        public void GivenIWantToCreateANewPatientProfile()
        {
            patientProfileCEN = new PatientProfileCEN();

        }

        [When(@"Create the Patient Profile")]
       
        public void WhenCreateThePatientProfile()
        {
            idPatientProfile = patientProfileCEN.New_(LanguageCodeEnum.es, "Espana", HazardValueEnum.olfactoryHazard, "patient with Alzheimer", "patient with a mild Alzheimer with a cognitive disability");
        }

        [Then(@"The Patient Profile was created")]
     
        public void ThenThePatientProfileWasCreated()
        {
            Assert.AreNotEqual(-1,patientProfileCEN.ReadOID(idPatientProfile));
        }
    }
}
