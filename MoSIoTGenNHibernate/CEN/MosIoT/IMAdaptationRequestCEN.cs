

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

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, int p_entity, string p_value, int p_adaptationRequest)
{
        IMAdaptationRequestEN iMAdaptationRequestEN = null;
        int oid;

        //Initialized IMAdaptationRequestEN
        iMAdaptationRequestEN = new IMAdaptationRequestEN ();
        iMAdaptationRequestEN.Name = p_name;

        iMAdaptationRequestEN.Type = p_type;

        iMAdaptationRequestEN.IsOID = p_isOID;

        iMAdaptationRequestEN.IsWritable = p_isWritable;

        iMAdaptationRequestEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMAdaptationRequestEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMAdaptationRequestEN.Entity.Id = p_entity;
        }

        iMAdaptationRequestEN.Value = p_value;


        if (p_adaptationRequest != -1) {
                // El argumento p_adaptationRequest -> Property adaptationRequest es oid = false
                // Lista de oids id
                iMAdaptationRequestEN.AdaptationRequest = new MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN ();
                iMAdaptationRequestEN.AdaptationRequest.Id = p_adaptationRequest;
        }

        //Call to IMAdaptationRequestCAD

        oid = _IIMAdaptationRequestCAD.New_ (iMAdaptationRequestEN);
        return oid;
}

public void Modify (int p_IMAdaptationRequest_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, string p_value)
{
        IMAdaptationRequestEN iMAdaptationRequestEN = null;

        //Initialized IMAdaptationRequestEN
        iMAdaptationRequestEN = new IMAdaptationRequestEN ();
        iMAdaptationRequestEN.Id = p_IMAdaptationRequest_OID;
        iMAdaptationRequestEN.Name = p_name;
        iMAdaptationRequestEN.Type = p_type;
        iMAdaptationRequestEN.IsOID = p_isOID;
        iMAdaptationRequestEN.IsWritable = p_isWritable;
        iMAdaptationRequestEN.Description = p_description;
        iMAdaptationRequestEN.Value = p_value;
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
}
}
