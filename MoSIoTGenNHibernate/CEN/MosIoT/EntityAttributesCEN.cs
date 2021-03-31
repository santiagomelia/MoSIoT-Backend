

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
 *      Definition of the class EntityAttributesCEN
 *
 */
public partial class EntityAttributesCEN
{
private IEntityAttributesCAD _IEntityAttributesCAD;

public EntityAttributesCEN()
{
        this._IEntityAttributesCAD = new EntityAttributesCAD ();
}

public EntityAttributesCEN(IEntityAttributesCAD _IEntityAttributesCAD)
{
        this._IEntityAttributesCAD = _IEntityAttributesCAD;
}

public IEntityAttributesCAD get_IEntityAttributesCAD ()
{
        return this._IEntityAttributesCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum p_associationType, bool p_isWritable, string p_description, int p_entity)
{
        EntityAttributesEN entityAttributesEN = null;
        int oid;

        //Initialized EntityAttributesEN
        entityAttributesEN = new EntityAttributesEN ();
        entityAttributesEN.Name = p_name;

        entityAttributesEN.Type = p_type;

        entityAttributesEN.IsOID = p_isOID;

        entityAttributesEN.AssociationType = p_associationType;

        entityAttributesEN.IsWritable = p_isWritable;

        entityAttributesEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                entityAttributesEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                entityAttributesEN.Entity.Id = p_entity;
        }

        //Call to EntityAttributesCAD

        oid = _IEntityAttributesCAD.New_ (entityAttributesEN);
        return oid;
}

public void Modify (int p_EntityAttributes_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum p_associationType, bool p_isWritable, string p_description)
{
        EntityAttributesEN entityAttributesEN = null;

        //Initialized EntityAttributesEN
        entityAttributesEN = new EntityAttributesEN ();
        entityAttributesEN.Id = p_EntityAttributes_OID;
        entityAttributesEN.Name = p_name;
        entityAttributesEN.Type = p_type;
        entityAttributesEN.IsOID = p_isOID;
        entityAttributesEN.AssociationType = p_associationType;
        entityAttributesEN.IsWritable = p_isWritable;
        entityAttributesEN.Description = p_description;
        //Call to EntityAttributesCAD

        _IEntityAttributesCAD.Modify (entityAttributesEN);
}

public void Destroy (int id
                     )
{
        _IEntityAttributesCAD.Destroy (id);
}

public EntityAttributesEN ReadOID (int id
                                   )
{
        EntityAttributesEN entityAttributesEN = null;

        entityAttributesEN = _IEntityAttributesCAD.ReadOID (id);
        return entityAttributesEN;
}

public System.Collections.Generic.IList<EntityAttributesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EntityAttributesEN> list = null;

        list = _IEntityAttributesCAD.ReadAll (first, size);
        return list;
}
}
}
