

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

public int New_ (string p_name, int p_scenario, string p_description, int p_userPatient)
{
        PatientEN patientEN = null;
        int oid;

        //Initialized PatientEN
        patientEN = new PatientEN ();
        patientEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                patientEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                patientEN.Scenario.Id = p_scenario;
        }

        patientEN.Description = p_description;


        if (p_userPatient != -1) {
                // El argumento p_userPatient -> Property userPatient es oid = false
                // Lista de oids id
                patientEN.UserPatient = new MoSIoTGenNHibernate.EN.MosIoT.UserEN ();
                patientEN.UserPatient.Id = p_userPatient;
        }

        //Call to PatientCAD

        oid = _IPatientCAD.New_ (patientEN);
        return oid;
}

public void Modify (int p_Patient_OID, string p_name, string p_description)
{
        PatientEN patientEN = null;

        //Initialized PatientEN
        patientEN = new PatientEN ();
        patientEN.Id = p_Patient_OID;
        patientEN.Name = p_name;
        patientEN.Description = p_description;
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
public void AssignPatientProfile (int p_Patient_OID, int p_patientProfile_OID)
{
        //Call to PatientCAD

        _IPatientCAD.AssignPatientProfile (p_Patient_OID, p_patientProfile_OID);
}
}
}
