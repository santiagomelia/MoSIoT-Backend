

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
 *      Definition of the class IMAdaptationDetailCEN
 *
 */
public partial class IMAdaptationDetailCEN
{
private IIMAdaptationDetailCAD _IIMAdaptationDetailCAD;

public IMAdaptationDetailCEN()
{
        this._IIMAdaptationDetailCAD = new IMAdaptationDetailCAD ();
}

public IMAdaptationDetailCEN(IIMAdaptationDetailCAD _IIMAdaptationDetailCAD)
{
        this._IIMAdaptationDetailCAD = _IIMAdaptationDetailCAD;
}

public IIMAdaptationDetailCAD get_IIMAdaptationDetailCAD ()
{
        return this._IIMAdaptationDetailCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, int p_entity, string p_value, int p_adaptationDetailRequired)
{
        IMAdaptationDetailEN iMAdaptationDetailEN = null;
        int oid;

        //Initialized IMAdaptationDetailEN
        iMAdaptationDetailEN = new IMAdaptationDetailEN ();
        iMAdaptationDetailEN.Name = p_name;

        iMAdaptationDetailEN.Type = p_type;

        iMAdaptationDetailEN.IsOID = p_isOID;

        iMAdaptationDetailEN.IsWritable = p_isWritable;

        iMAdaptationDetailEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMAdaptationDetailEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMAdaptationDetailEN.Entity.Id = p_entity;
        }

        iMAdaptationDetailEN.Value = p_value;


        if (p_adaptationDetailRequired != -1) {
                // El argumento p_adaptationDetailRequired -> Property adaptationDetailRequired es oid = false
                // Lista de oids id
                iMAdaptationDetailEN.AdaptationDetailRequired = new MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN ();
                iMAdaptationDetailEN.AdaptationDetailRequired.Id = p_adaptationDetailRequired;
        }

        //Call to IMAdaptationDetailCAD

        oid = _IIMAdaptationDetailCAD.New_ (iMAdaptationDetailEN);
        return oid;
}

public void Modify (int p_IMAdaptationDetail_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, string p_value)
{
        IMAdaptationDetailEN iMAdaptationDetailEN = null;

        //Initialized IMAdaptationDetailEN
        iMAdaptationDetailEN = new IMAdaptationDetailEN ();
        iMAdaptationDetailEN.Id = p_IMAdaptationDetail_OID;
        iMAdaptationDetailEN.Name = p_name;
        iMAdaptationDetailEN.Type = p_type;
        iMAdaptationDetailEN.IsOID = p_isOID;
        iMAdaptationDetailEN.IsWritable = p_isWritable;
        iMAdaptationDetailEN.Description = p_description;
        iMAdaptationDetailEN.Value = p_value;
        //Call to IMAdaptationDetailCAD

        _IIMAdaptationDetailCAD.Modify (iMAdaptationDetailEN);
}

public void Destroy (int id
                     )
{
        _IIMAdaptationDetailCAD.Destroy (id);
}

public IMAdaptationDetailEN ReadOID (int id
                                     )
{
        IMAdaptationDetailEN iMAdaptationDetailEN = null;

        iMAdaptationDetailEN = _IIMAdaptationDetailCAD.ReadOID (id);
        return iMAdaptationDetailEN;
}

public System.Collections.Generic.IList<IMAdaptationDetailEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMAdaptationDetailEN> list = null;

        list = _IIMAdaptationDetailCAD.ReadAll (first, size);
        return list;
}
}
}
