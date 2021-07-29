

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
 *      Definition of the class IMAdaptationRequestCEN
 *
 */
public partial class IMAdaptationRequestCEN
{
private IIMAdaptationRequestCAD _IIMAdaptationRequestCAD;

public IMAdaptationRequestCEN()
{
        this._IIMAdaptationRequestCAD = new IMAdaptationRequestCAD ();
}

public IMAdaptationRequestCEN(IIMAdaptationRequestCAD _IIMAdaptationRequestCAD)
{
        this._IIMAdaptationRequestCAD = _IIMAdaptationRequestCAD;
}

public IIMAdaptationRequestCAD get_IIMAdaptationRequestCAD ()
{
        return this._IIMAdaptationRequestCAD;
}

public int New_ (string p_name, string p_description, int p_entity)
{
        IMAdaptationRequestEN iMAdaptationRequestEN = null;
        int oid;

        //Initialized IMAdaptationRequestEN
        iMAdaptationRequestEN = new IMAdaptationRequestEN ();
        iMAdaptationRequestEN.Name = p_name;

        iMAdaptationRequestEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMAdaptationRequestEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMAdaptationRequestEN.Entity.Id = p_entity;
        }

        //Call to IMAdaptationRequestCAD

        oid = _IIMAdaptationRequestCAD.New_ (iMAdaptationRequestEN);
        return oid;
}

public void Modify (int p_IMAdaptationRequest_OID, string p_name, string p_description)
{
        IMAdaptationRequestEN iMAdaptationRequestEN = null;

        //Initialized IMAdaptationRequestEN
        iMAdaptationRequestEN = new IMAdaptationRequestEN ();
        iMAdaptationRequestEN.Id = p_IMAdaptationRequest_OID;
        iMAdaptationRequestEN.Name = p_name;
        iMAdaptationRequestEN.Description = p_description;
        //Call to IMAdaptationRequestCAD

        _IIMAdaptationRequestCAD.Modify (iMAdaptationRequestEN);
}

public void Destroy (int id
                     )
{
        _IIMAdaptationRequestCAD.Destroy (id);
}

public IMAdaptationRequestEN ReadOID (int id
                                      )
{
        IMAdaptationRequestEN iMAdaptationRequestEN = null;

        iMAdaptationRequestEN = _IIMAdaptationRequestCAD.ReadOID (id);
        return iMAdaptationRequestEN;
}

public System.Collections.Generic.IList<IMAdaptationRequestEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMAdaptationRequestEN> list = null;

        list = _IIMAdaptationRequestCAD.ReadAll (first, size);
        return list;
}
public void AssignAdaptationR (int p_IMAdaptationRequest_OID, int p_adaptationRequest_OID)
{
        //Call to IMAdaptationRequestCAD

        _IIMAdaptationRequestCAD.AssignAdaptationR (p_IMAdaptationRequest_OID, p_adaptationRequest_OID);
}
}
}
