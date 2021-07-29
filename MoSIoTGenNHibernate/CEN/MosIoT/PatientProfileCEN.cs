

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;

using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


namespace MoSIoTGenNHibernate.CEN.MosIoT
{
/*
 *      Definition of the class PatientProfileCEN
 *
 */
public partial class PatientProfileCEN
{
private IPatientProfileCAD _IPatientProfileCAD;

public PatientProfileCEN()
{
        this._IPatientProfileCAD = new PatientProfileCAD ();
}

public PatientProfileCEN(IPatientProfileCAD _IPatientProfileCAD)
{
        this._IPatientProfileCAD = _IPatientProfileCAD;
}

public IPatientProfileCAD get_IPatientProfileCAD ()
{
        return this._IPatientProfileCAD;
}

public void Modify (int p_PatientProfile_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum p_preferredLanguage, string p_region, MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum p_hazardAvoidance, string p_name, string p_description)
{
        PatientProfileEN patientProfileEN = null;

        //Initialized PatientProfileEN
        patientProfileEN = new PatientProfileEN ();
        patientProfileEN.Id = p_PatientProfile_OID;
        patientProfileEN.PreferredLanguage = p_preferredLanguage;
        patientProfileEN.Region = p_region;
        patientProfileEN.HazardAvoidance = p_hazardAvoidance;
        patientProfileEN.Name = p_name;
        patientProfileEN.Description = p_description;
        //Call to PatientProfileCAD

        _IPatientProfileCAD.Modify (patientProfileEN);
}

public void Destroy (int id
                     )
{
        _IPatientProfileCAD.Destroy (id);
}

public PatientProfileEN ReadOID (int id
                                 )
{
        PatientProfileEN patientProfileEN = null;

        patientProfileEN = _IPatientProfileCAD.ReadOID (id);
        return patientProfileEN;
}

public System.Collections.Generic.IList<PatientProfileEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PatientProfileEN> list = null;

        list = _IPatientProfileCAD.ReadAll (first, size);
        return list;
}
public void AssignCarePlanTemplate (int p_PatientProfile_OID, System.Collections.Generic.IList<int> p_carePlanTemplate_OIDs)
{
        //Call to PatientProfileCAD

        _IPatientProfileCAD.AssignCarePlanTemplate (p_PatientProfile_OID, p_carePlanTemplate_OIDs);
}
}
}
