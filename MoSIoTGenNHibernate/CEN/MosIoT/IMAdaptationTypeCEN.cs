

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
 *      Definition of the class IMAdaptationTypeCEN
 *
 */
public partial class IMAdaptationTypeCEN
{
private IIMAdaptationTypeCAD _IIMAdaptationTypeCAD;

public IMAdaptationTypeCEN()
{
        this._IIMAdaptationTypeCAD = new IMAdaptationTypeCAD ();
}

public IMAdaptationTypeCEN(IIMAdaptationTypeCAD _IIMAdaptationTypeCAD)
{
        this._IIMAdaptationTypeCAD = _IIMAdaptationTypeCAD;
}

public IIMAdaptationTypeCAD get_IIMAdaptationTypeCAD ()
{
        return this._IIMAdaptationTypeCAD;
}

public int New_ (string p_name, string p_description, int p_entity)
{
        IMAdaptationTypeEN iMAdaptationTypeEN = null;
        int oid;

        //Initialized IMAdaptationTypeEN
        iMAdaptationTypeEN = new IMAdaptationTypeEN ();
        iMAdaptationTypeEN.Name = p_name;

        iMAdaptationTypeEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMAdaptationTypeEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMAdaptationTypeEN.Entity.Id = p_entity;
        }

        //Call to IMAdaptationTypeCAD

        oid = _IIMAdaptationTypeCAD.New_ (iMAdaptationTypeEN);
        return oid;
}

public void Modify (int p_IMAdaptationType_OID, string p_name, string p_description)
{
        IMAdaptationTypeEN iMAdaptationTypeEN = null;

        //Initialized IMAdaptationTypeEN
        iMAdaptationTypeEN = new IMAdaptationTypeEN ();
        iMAdaptationTypeEN.Id = p_IMAdaptationType_OID;
        iMAdaptationTypeEN.Name = p_name;
        iMAdaptationTypeEN.Description = p_description;
        //Call to IMAdaptationTypeCAD

        _IIMAdaptationTypeCAD.Modify (iMAdaptationTypeEN);
}

public void Destroy (int id
                     )
{
        _IIMAdaptationTypeCAD.Destroy (id);
}

public IMAdaptationTypeEN ReadOID (int id
                                   )
{
        IMAdaptationTypeEN iMAdaptationTypeEN = null;

        iMAdaptationTypeEN = _IIMAdaptationTypeCAD.ReadOID (id);
        return iMAdaptationTypeEN;
}

public System.Collections.Generic.IList<IMAdaptationTypeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMAdaptationTypeEN> list = null;

        list = _IIMAdaptationTypeCAD.ReadAll (first, size);
        return list;
}
public void AssignAdaptationT (int p_IMAdaptationType_OID, int p_adaptationTypeRequired_OID)
{
        //Call to IMAdaptationTypeCAD

        _IIMAdaptationTypeCAD.AssignAdaptationT (p_IMAdaptationType_OID, p_adaptationTypeRequired_OID);
}
}
}
