

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
 *      Definition of the class EntityOperationCEN
 *
 */
public partial class EntityOperationCEN
{
private IEntityOperationCAD _IEntityOperationCAD;

public EntityOperationCEN()
{
        this._IEntityOperationCAD = new EntityOperationCAD ();
}

public EntityOperationCEN(IEntityOperationCAD _IEntityOperationCAD)
{
        this._IEntityOperationCAD = _IEntityOperationCAD;
}

public IEntityOperationCAD get_IEntityOperationCAD ()
{
        return this._IEntityOperationCAD;
}

public void Modify (int p_EntityOperation_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum p_serviceType, string p_description)
{
        EntityOperationEN entityOperationEN = null;

        //Initialized EntityOperationEN
        entityOperationEN = new EntityOperationEN ();
        entityOperationEN.Id = p_EntityOperation_OID;
        entityOperationEN.Name = p_name;
        entityOperationEN.Type = p_type;
        entityOperationEN.ServiceType = p_serviceType;
        entityOperationEN.Description = p_description;
        //Call to EntityOperationCAD

        _IEntityOperationCAD.Modify (entityOperationEN);
}

public void Destroy (int id
                     )
{
        _IEntityOperationCAD.Destroy (id);
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum p_serviceType, string p_description, int p_entity)
{
        EntityOperationEN entityOperationEN = null;
        int oid;

        //Initialized EntityOperationEN
        entityOperationEN = new EntityOperationEN ();
        entityOperationEN.Name = p_name;

        entityOperationEN.Type = p_type;

        entityOperationEN.ServiceType = p_serviceType;

        entityOperationEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                entityOperationEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                entityOperationEN.Entity.Id = p_entity;
        }

        //Call to EntityOperationCAD

        oid = _IEntityOperationCAD.New_ (entityOperationEN);
        return oid;
}

public EntityOperationEN ReadOID (int id
                                  )
{
        EntityOperationEN entityOperationEN = null;

        entityOperationEN = _IEntityOperationCAD.ReadOID (id);
        return entityOperationEN;
}

public System.Collections.Generic.IList<EntityOperationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EntityOperationEN> list = null;

        list = _IEntityOperationCAD.ReadAll (first, size);
        return list;
}
}
}
