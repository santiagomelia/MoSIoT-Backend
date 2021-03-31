

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
 *      Definition of the class PatientCEN
 *
 */
public partial class PatientCEN
{
private IPatientCAD _IPatientCAD;

public PatientCEN()
{
        this._IPatientCAD = new PatientCAD ();
}

public PatientCEN(IPatientCAD _IPatientCAD)
{
        this._IPatientCAD = _IPatientCAD;
}

public IPatientCAD get_IPatientCAD ()
{
        return this._IPatientCAD;
}

public int New_ (string p_surnames, bool p_isActive, bool p_isDiseased, String p_pass, string p_name, string p_description, string p_email, int p_patientProfile)
{
        PatientEN patientEN = null;
        int oid;

        //Initialized PatientEN
        patientEN = new PatientEN ();
        patientEN.Surnames = p_surnames;

        patientEN.IsActive = p_isActive;

        patientEN.IsDiseased = p_isDiseased;

        patientEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        patientEN.Name = p_name;

        patientEN.Description = p_description;

        patientEN.Email = p_email;


        if (p_patientProfile != -1) {
                // El argumento p_patientProfile -> Property patientProfile es oid = false
                // Lista de oids id
                patientEN.PatientProfile = new MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN ();
                patientEN.PatientProfile.Id = p_patientProfile;
        }

        //Call to PatientCAD

        oid = _IPatientCAD.New_ (patientEN);
        return oid;
}

public void Modify (int p_Patient_OID, string p_surnames, bool p_isActive, bool p_isDiseased, String p_pass, string p_name, string p_description, string p_email)
{
        PatientEN patientEN = null;

        //Initialized PatientEN
        patientEN = new PatientEN ();
        patientEN.Id = p_Patient_OID;
        patientEN.Surnames = p_surnames;
        patientEN.IsActive = p_isActive;
        patientEN.IsDiseased = p_isDiseased;
        patientEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        patientEN.Name = p_name;
        patientEN.Description = p_description;
        patientEN.Email = p_email;
        //Call to PatientCAD

        _IPatientCAD.Modify (patientEN);
}

public void Destroy (int id
                     )
{
        _IPatientCAD.Destroy (id);
}

public PatientEN ReadOID (int id
                          )
{
        PatientEN patientEN = null;

        patientEN = _IPatientCAD.ReadOID (id);
        return patientEN;
}

public System.Collections.Generic.IList<PatientEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PatientEN> list = null;

        list = _IPatientCAD.ReadAll (first, size);
        return list;
}
}
}
