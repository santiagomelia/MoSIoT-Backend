using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Enumerated.MosIoT;
using System.Collections.Generic;
using TechTalk.SpecFlow;
namespace MoSTTesting.Patient
{
    [Binding]
    public class ObtainPatientProfilesSteps
    {
        public static PatientProfileCEN patientProfileCEN;
        public static PatientProfileEN patientProfileEN;
        public static IList<PatientProfileEN> patientProfileListEN = new List<PatientProfileEN>();
        public static IList<int> idPatientProfiles = new List<int>();


        [Before(tags: "obtainPatientProfiles")]
        public static void InitializeData()
        {
            patientProfileCEN = new PatientProfileCEN();
            idPatientProfiles.Add(patientProfileCEN.New_(LanguageCodeEnum.en, "England", HazardValueEnum.flashing, "patient1 name", "patient description1"));
            idPatientProfiles.Add(patientProfileCEN.New_(LanguageCodeEnum.fr, "France", HazardValueEnum.sound, "patient2 name", "patient description1"));
            idPatientProfiles.Add(patientProfileCEN.New_(LanguageCodeEnum.es, "Espana", HazardValueEnum.olfactoryHazard, "patient3 name", "patient description1"));

        }

        [After(tags: "Having Patient Profiles")]
        public static void CleanData()
        {
            if (patientProfileListEN.Count > 0)
                foreach (var patient in idPatientProfiles)
                {
                    patientProfileCEN.Destroy(patient);
                }

        }

        [Given(@"having a list of Patient profiles")]
        public void GivenHavingAListOfPatientProfiles()
        {
            patientProfileCEN = new PatientProfileCEN();
        }
        
        [When(@"obtain patient profiles")]
        public void WhenObtainPatientProfiles()
        {
            patientProfileListEN = patientProfileCEN.ReadAll(0, -1);
        }
        
        [Then(@"get a list of available patient profiles")]
        public void ThenGetAListOfAvailablePatientProfiles()
        {
            Assert.IsTrue(patientProfileListEN.Count > 0);
        }
    }
}
