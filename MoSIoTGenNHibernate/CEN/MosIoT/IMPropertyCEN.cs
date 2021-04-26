

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
 *      Definition of the class IMPropertyCEN
 *
 */
public partial class IMPropertyCEN
{
private IIMPropertyCAD _IIMPropertyCAD;

public IMPropertyCEN()
{
        this._IIMPropertyCAD = new IMPropertyCAD ();
}

public IMPropertyCEN(IIMPropertyCAD _IIMPropertyCAD)
{
        this._IIMPropertyCAD = _IIMPropertyCAD;
}

public IIMPropertyCAD get_IIMPropertyCAD ()
{
        return this._IIMPropertyCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, int p_entity, string p_value, int p_property)
{
        IMPropertyEN iMPropertyEN = null;
        int oid;

        //Initialized IMPropertyEN
        iMPropertyEN = new IMPropertyEN ();
        iMPropertyEN.Name = p_name;

        iMPropertyEN.Type = p_type;

        iMPropertyEN.IsOID = p_isOID;

        iMPropertyEN.IsWritable = p_isWritable;

        iMPropertyEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMPropertyEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMPropertyEN.Entity.Id = p_entity;
        }

        iMPropertyEN.Value = p_value;


        if (p_property != -1) {
                // El argumento p_property -> Property property es oid = false
                // Lista de oids id
                iMPropertyEN.Property = new MoSIoTGenNHibernate.EN.MosIoT.PropertyEN ();
                iMPropertyEN.Property.Id = p_property;
        }

        //Call to IMPropertyCAD

        oid = _IIMPropertyCAD.New_ (iMPropertyEN);
        return oid;
}

public void Modify (int p_IMProperty_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, string p_value)
{
        IMPropertyEN iMPropertyEN = null;

        //Initialized IMPropertyEN
        iMPropertyEN = new IMPropertyEN ();
        iMPropertyEN.Id = p_IMProperty_OID;
        iMPropertyEN.Name = p_name;
        iMPropertyEN.Type = p_type;
        iMPropertyEN.IsOID = p_isOID;
        iMPropertyEN.IsWritable = p_isWritable;
        iMPropertyEN.Description = p_description;
        iMPropertyEN.Value = p_value;
        //Call to IMPropertyCAD

        _IIMPropertyCAD.Modify (iMPropertyEN);
}

public void Destroy (int id
                     )
{
        _IIMPropertyCAD.Destroy (id);
}

public IMPropertyEN ReadOID (int id
                             )
{
        IMPropertyEN iMPropertyEN = null;

        iMPropertyEN = _IIMPropertyCAD.ReadOID (id);
        return iMPropertyEN;
}

public System.Collections.Generic.IList<IMPropertyEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMPropertyEN> list = null;

        list = _IIMPropertyCAD.ReadAll (first, size);
        return list;
}
}
}
