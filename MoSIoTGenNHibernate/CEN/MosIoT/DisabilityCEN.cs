

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
 *      Definition of the class DisabilityCEN
 *
 */
public partial class DisabilityCEN
{
private IDisabilityCAD _IDisabilityCAD;

public DisabilityCEN()
{
        this._IDisabilityCAD = new DisabilityCAD ();
}

public DisabilityCEN(IDisabilityCAD _IDisabilityCAD)
{
        this._IDisabilityCAD = _IDisabilityCAD;
}

public IDisabilityCAD get_IDisabilityCAD ()
{
        return this._IDisabilityCAD;
}

public int New_ (int p_patient, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum p_severity, string p_description)
{
        DisabilityEN disabilityEN = null;
        int oid;

        //Initialized DisabilityEN
        disabilityEN = new DisabilityEN ();

        if (p_patient != -1) {
                // El argumento p_patient -> Property patient es oid = false
                // Lista de oids id
                disabilityEN.Patient = new MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN ();
                disabilityEN.Patient.Id = p_patient;
        }

        disabilityEN.Name = p_name;

        disabilityEN.Type = p_type;

        disabilityEN.Severity = p_severity;

        disabilityEN.Description = p_description;

        //Call to DisabilityCAD

        oid = _IDisabilityCAD.New_ (disabilityEN);
        return oid;
}

public void Modify (int p_Disability_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum p_severity, string p_description)
{
        DisabilityEN disabilityEN = null;

        //Initialized DisabilityEN
        disabilityEN = new DisabilityEN ();
        disabilityEN.Id = p_Disability_OID;
        disabilityEN.Name = p_name;
        disabilityEN.Type = p_type;
        disabilityEN.Severity = p_severity;
        disabilityEN.Description = p_description;
        //Call to DisabilityCAD

        _IDisabilityCAD.Modify (disabilityEN);
}

public void Destroy (int id
                     )
{
        _IDisabilityCAD.Destroy (id);
}

public DisabilityEN ReadOID (int id
                             )
{
        DisabilityEN disabilityEN = null;

        disabilityEN = _IDisabilityCAD.ReadOID (id);
        return disabilityEN;
}

public System.Collections.Generic.IList<DisabilityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DisabilityEN> list = null;

        list = _IDisabilityCAD.ReadAll (first, size);
        return list;
}
}
}
