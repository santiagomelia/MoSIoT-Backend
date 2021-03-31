

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
 *      Definition of the class EntityStateCEN
 *
 */
public partial class EntityStateCEN
{
private IEntityStateCAD _IEntityStateCAD;

public EntityStateCEN()
{
        this._IEntityStateCAD = new EntityStateCAD ();
}

public EntityStateCEN(IEntityStateCAD _IEntityStateCAD)
{
        this._IEntityStateCAD = _IEntityStateCAD;
}

public IEntityStateCAD get_IEntityStateCAD ()
{
        return this._IEntityStateCAD;
}

public int New_ (int p_virtualEntity, MoSIoTGenNHibernate.Enumerated.MosIoT.StateTypeEnum p_type, string p_name, string p_description)
{
        EntityStateEN entityStateEN = null;
        int oid;

        //Initialized EntityStateEN
        entityStateEN = new EntityStateEN ();

        if (p_virtualEntity != -1) {
                // El argumento p_virtualEntity -> Property virtualEntity es oid = false
                // Lista de oids id
                entityStateEN.VirtualEntity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                entityStateEN.VirtualEntity.Id = p_virtualEntity;
        }

        entityStateEN.Type = p_type;

        entityStateEN.Name = p_name;

        entityStateEN.Description = p_description;

        //Call to EntityStateCAD

        oid = _IEntityStateCAD.New_ (entityStateEN);
        return oid;
}

public void Modify (int p_EntityState_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.StateTypeEnum p_type, string p_name, string p_description)
{
        EntityStateEN entityStateEN = null;

        //Initialized EntityStateEN
        entityStateEN = new EntityStateEN ();
        entityStateEN.Id = p_EntityState_OID;
        entityStateEN.Type = p_type;
        entityStateEN.Name = p_name;
        entityStateEN.Description = p_description;
        //Call to EntityStateCAD

        _IEntityStateCAD.Modify (entityStateEN);
}

public void Destroy (int id
                     )
{
        _IEntityStateCAD.Destroy (id);
}
}
}
