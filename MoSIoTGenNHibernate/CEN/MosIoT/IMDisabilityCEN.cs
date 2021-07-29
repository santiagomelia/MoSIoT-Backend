

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
 *      Definition of the class IMDisabilityCEN
 *
 */
public partial class IMDisabilityCEN
{
private IIMDisabilityCAD _IIMDisabilityCAD;

public IMDisabilityCEN()
{
        this._IIMDisabilityCAD = new IMDisabilityCAD ();
}

public IMDisabilityCEN(IIMDisabilityCAD _IIMDisabilityCAD)
{
        this._IIMDisabilityCAD = _IIMDisabilityCAD;
}

public IIMDisabilityCAD get_IIMDisabilityCAD ()
{
        return this._IIMDisabilityCAD;
}

public int New_ (string p_name, string p_description, int p_entity)
{
        IMDisabilityEN iMDisabilityEN = null;
        int oid;

        //Initialized IMDisabilityEN
        iMDisabilityEN = new IMDisabilityEN ();
        iMDisabilityEN.Name = p_name;

        iMDisabilityEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMDisabilityEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMDisabilityEN.Entity.Id = p_entity;
        }

        //Call to IMDisabilityCAD

        oid = _IIMDisabilityCAD.New_ (iMDisabilityEN);
        return oid;
}

public void Modify (int p_IMDisability_OID, string p_name, string p_description)
{
        IMDisabilityEN iMDisabilityEN = null;

        //Initialized IMDisabilityEN
        iMDisabilityEN = new IMDisabilityEN ();
        iMDisabilityEN.Id = p_IMDisability_OID;
        iMDisabilityEN.Name = p_name;
        iMDisabilityEN.Description = p_description;
        //Call to IMDisabilityCAD

        _IIMDisabilityCAD.Modify (iMDisabilityEN);
}

public void Destroy (int id
                     )
{
        _IIMDisabilityCAD.Destroy (id);
}

public IMDisabilityEN ReadOID (int id
                               )
{
        IMDisabilityEN iMDisabilityEN = null;

        iMDisabilityEN = _IIMDisabilityCAD.ReadOID (id);
        return iMDisabilityEN;
}

public System.Collections.Generic.IList<IMDisabilityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMDisabilityEN> list = null;

        list = _IIMDisabilityCAD.ReadAll (first, size);
        return list;
}
public void AssignDisability (int p_IMDisability_OID, int p_disability_OID)
{
        //Call to IMDisabilityCAD

        _IIMDisabilityCAD.AssignDisability (p_IMDisability_OID, p_disability_OID);
}
}
}
