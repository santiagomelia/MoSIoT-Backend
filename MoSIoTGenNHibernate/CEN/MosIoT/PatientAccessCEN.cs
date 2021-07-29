

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
 *      Definition of the class PatientAccessCEN
 *
 */
public partial class PatientAccessCEN
{
private IPatientAccessCAD _IPatientAccessCAD;

public PatientAccessCEN()
{
        this._IPatientAccessCAD = new PatientAccessCAD ();
}

public PatientAccessCEN(IPatientAccessCAD _IPatientAccessCAD)
{
        this._IPatientAccessCAD = _IPatientAccessCAD;
}

public IPatientAccessCAD get_IPatientAccessCAD ()
{
        return this._IPatientAccessCAD;
}

public int New_ (string p_name, int p_scenario, string p_description)
{
        PatientAccessEN patientAccessEN = null;
        int oid;

        //Initialized PatientAccessEN
        patientAccessEN = new PatientAccessEN ();
        patientAccessEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                patientAccessEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                patientAccessEN.Scenario.Id = p_scenario;
        }

        patientAccessEN.Description = p_description;

        //Call to PatientAccessCAD

        oid = _IPatientAccessCAD.New_ (patientAccessEN);
        return oid;
}

public void Modify (int p_PatientAccess_OID, string p_name, string p_description)
{
        PatientAccessEN patientAccessEN = null;

        //Initialized PatientAccessEN
        patientAccessEN = new PatientAccessEN ();
        patientAccessEN.Id = p_PatientAccess_OID;
        patientAccessEN.Name = p_name;
        patientAccessEN.Description = p_description;
        //Call to PatientAccessCAD

        _IPatientAccessCAD.Modify (patientAccessEN);
}

public void Destroy (int id
                     )
{
        _IPatientAccessCAD.Destroy (id);
}

public PatientAccessEN ReadOID (int id
                                )
{
        PatientAccessEN patientAccessEN = null;

        patientAccessEN = _IPatientAccessCAD.ReadOID (id);
        return patientAccessEN;
}

public System.Collections.Generic.IList<PatientAccessEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PatientAccessEN> list = null;

        list = _IPatientAccessCAD.ReadAll (first, size);
        return list;
}
public void AssignAccessMode (int p_PatientAccess_OID, int p_accessMode_OID)
{
        //Call to PatientAccessCAD

        _IPatientAccessCAD.AssignAccessMode (p_PatientAccess_OID, p_accessMode_OID);
}
}
}
