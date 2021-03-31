

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
 *      Definition of the class AccessModeCEN
 *
 */
public partial class AccessModeCEN
{
private IAccessModeCAD _IAccessModeCAD;

public AccessModeCEN()
{
        this._IAccessModeCAD = new AccessModeCAD ();
}

public AccessModeCEN(IAccessModeCAD _IAccessModeCAD)
{
        this._IAccessModeCAD = _IAccessModeCAD;
}

public IAccessModeCAD get_IAccessModeCAD ()
{
        return this._IAccessModeCAD;
}

public int New_ (int p_patient, MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum p_typeAccessMode, string p_description, int p_disability, string p_name)
{
        AccessModeEN accessModeEN = null;
        int oid;

        //Initialized AccessModeEN
        accessModeEN = new AccessModeEN ();

        if (p_patient != -1) {
                // El argumento p_patient -> Property patient es oid = false
                // Lista de oids id
                accessModeEN.Patient = new MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN ();
                accessModeEN.Patient.Id = p_patient;
        }

        accessModeEN.TypeAccessMode = p_typeAccessMode;

        accessModeEN.Description = p_description;


        if (p_disability != -1) {
                // El argumento p_disability -> Property disability es oid = false
                // Lista de oids id
                accessModeEN.Disability = new MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN ();
                accessModeEN.Disability.Id = p_disability;
        }

        accessModeEN.Name = p_name;

        //Call to AccessModeCAD

        oid = _IAccessModeCAD.New_ (accessModeEN);
        return oid;
}

public void Modify (int p_AccessMode_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum p_typeAccessMode, string p_description, string p_name)
{
        AccessModeEN accessModeEN = null;

        //Initialized AccessModeEN
        accessModeEN = new AccessModeEN ();
        accessModeEN.Id = p_AccessMode_OID;
        accessModeEN.TypeAccessMode = p_typeAccessMode;
        accessModeEN.Description = p_description;
        accessModeEN.Name = p_name;
        //Call to AccessModeCAD

        _IAccessModeCAD.Modify (accessModeEN);
}

public void Destroy (int id
                     )
{
        _IAccessModeCAD.Destroy (id);
}

public AccessModeEN ReadOID (int id
                             )
{
        AccessModeEN accessModeEN = null;

        accessModeEN = _IAccessModeCAD.ReadOID (id);
        return accessModeEN;
}

public System.Collections.Generic.IList<AccessModeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AccessModeEN> list = null;

        list = _IAccessModeCAD.ReadAll (first, size);
        return list;
}
public void AsignarDevice (int p_AccessMode_OID, System.Collections.Generic.IList<int> p_deviceTemplate_OIDs)
{
        //Call to AccessModeCAD

        _IAccessModeCAD.AsignarDevice (p_AccessMode_OID, p_deviceTemplate_OIDs);
}
}
}
