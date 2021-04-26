

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
 *      Definition of the class IMConditionCEN
 *
 */
public partial class IMConditionCEN
{
private IIMConditionCAD _IIMConditionCAD;

public IMConditionCEN()
{
        this._IIMConditionCAD = new IMConditionCAD ();
}

public IMConditionCEN(IIMConditionCAD _IIMConditionCAD)
{
        this._IIMConditionCAD = _IIMConditionCAD;
}

public IIMConditionCAD get_IIMConditionCAD ()
{
        return this._IIMConditionCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, int p_entity, string p_value, int p_condition)
{
        IMConditionEN iMConditionEN = null;
        int oid;

        //Initialized IMConditionEN
        iMConditionEN = new IMConditionEN ();
        iMConditionEN.Name = p_name;

        iMConditionEN.Type = p_type;

        iMConditionEN.IsOID = p_isOID;

        iMConditionEN.IsWritable = p_isWritable;

        iMConditionEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMConditionEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMConditionEN.Entity.Id = p_entity;
        }

        iMConditionEN.Value = p_value;


        if (p_condition != -1) {
                // El argumento p_condition -> Property condition es oid = false
                // Lista de oids id
                iMConditionEN.Condition = new MoSIoTGenNHibernate.EN.MosIoT.ConditionEN ();
                iMConditionEN.Condition.Id = p_condition;
        }

        //Call to IMConditionCAD

        oid = _IIMConditionCAD.New_ (iMConditionEN);
        return oid;
}

public void Modify (int p_IMCondition_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, string p_value)
{
        IMConditionEN iMConditionEN = null;

        //Initialized IMConditionEN
        iMConditionEN = new IMConditionEN ();
        iMConditionEN.Id = p_IMCondition_OID;
        iMConditionEN.Name = p_name;
        iMConditionEN.Type = p_type;
        iMConditionEN.IsOID = p_isOID;
        iMConditionEN.IsWritable = p_isWritable;
        iMConditionEN.Description = p_description;
        iMConditionEN.Value = p_value;
        //Call to IMConditionCAD

        _IIMConditionCAD.Modify (iMConditionEN);
}

public void Destroy (int id
                     )
{
        _IIMConditionCAD.Destroy (id);
}

public IMConditionEN ReadOID (int id
                              )
{
        IMConditionEN iMConditionEN = null;

        iMConditionEN = _IIMConditionCAD.ReadOID (id);
        return iMConditionEN;
}

public System.Collections.Generic.IList<IMConditionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMConditionEN> list = null;

        list = _IIMConditionCAD.ReadAll (first, size);
        return list;
}
}
}
