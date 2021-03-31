
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


/*PROTECTED REGION ID(usingMoSIoTGenNHibernate.CEN.MosIoT_PatientProfile_new_) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace MoSIoTGenNHibernate.CEN.MosIoT
{
public partial class PatientProfileCEN
{
public int New_ (MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum p_preferredLanguage, string p_region, MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum p_hazardAvoidance, string p_name, string p_description)
{
        /*PROTECTED REGION ID(MoSIoTGenNHibernate.CEN.MosIoT_PatientProfile_new__customized) START*/

        PatientProfileEN patientProfileEN = null;

        int oid;

        //Initialized PatientProfileEN
        patientProfileEN = new PatientProfileEN ();
        patientProfileEN.PreferredLanguage = p_preferredLanguage;

        patientProfileEN.Region = p_region;

        patientProfileEN.HazardAvoidance = p_hazardAvoidance;

        patientProfileEN.Name = p_name;

        patientProfileEN.Description = p_description;

        //Call to PatientProfileCAD

        oid = _IPatientProfileCAD.New_ (patientProfileEN);
        return oid;
        /*PROTECTED REGION END*/
}
}
}
