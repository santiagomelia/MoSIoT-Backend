

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
 *      Definition of the class EntityArgumentCEN
 *
 */
public partial class EntityArgumentCEN
{
private IEntityArgumentCAD _IEntityArgumentCAD;

public EntityArgumentCEN()
{
        this._IEntityArgumentCAD = new EntityArgumentCAD ();
}

public EntityArgumentCEN(IEntityArgumentCAD _IEntityArgumentCAD)
{
        this._IEntityArgumentCAD = _IEntityArgumentCAD;
}

public IEntityArgumentCAD get_IEntityArgumentCAD ()
{
        return this._IEntityArgumentCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, int p_entityOperation)
{
        EntityArgumentEN entityArgumentEN = null;
        int oid;

        //Initialized EntityArgumentEN
        entityArgumentEN = new EntityArgumentEN ();
        entityArgumentEN.Name = p_name;

        entityArgumentEN.Type = p_type;


        if (p_entityOperation != -1) {
                // El argumento p_entityOperation -> Property entityOperation es oid = false
                // Lista de oids id
                entityArgumentEN.EntityOperation = new MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN ();
                entityArgumentEN.EntityOperation.Id = p_entityOperation;
        }

        //Call to EntityArgumentCAD

        oid = _IEntityArgumentCAD.New_ (entityArgumentEN);
        return oid;
}

public void Modify (int p_EntityArgument_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type)
{
        EntityArgumentEN entityArgumentEN = null;

        //Initialized EntityArgumentEN
        entityArgumentEN = new EntityArgumentEN ();
        entityArgumentEN.Id = p_EntityArgument_OID;
        entityArgumentEN.Name = p_name;
        entityArgumentEN.Type = p_type;
        //Call to EntityArgumentCAD

        _IEntityArgumentCAD.Modify (entityArgumentEN);
}

public void Destroy (int id
                     )
{
        _IEntityArgumentCAD.Destroy (id);
}

public EntityArgumentEN ReadOID (int id
                                 )
{
        EntityArgumentEN entityArgumentEN = null;

        entityArgumentEN = _IEntityArgumentCAD.ReadOID (id);
        return entityArgumentEN;
}

public System.Collections.Generic.IList<EntityArgumentEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EntityArgumentEN> list = null;

        list = _IEntityArgumentCAD.ReadAll (first, size);
        return list;
}
}
}
