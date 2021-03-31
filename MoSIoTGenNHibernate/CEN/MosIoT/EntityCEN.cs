

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
 *      Definition of the class EntityCEN
 *
 */
public partial class EntityCEN
{
private IEntityCAD _IEntityCAD;

public EntityCEN()
{
        this._IEntityCAD = new EntityCAD ();
}

public EntityCEN(IEntityCAD _IEntityCAD)
{
        this._IEntityCAD = _IEntityCAD;
}

public IEntityCAD get_IEntityCAD ()
{
        return this._IEntityCAD;
}

public int New_ (string p_name, int p_scenario, string p_description)
{
        EntityEN entityEN = null;
        int oid;

        //Initialized EntityEN
        entityEN = new EntityEN ();
        entityEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                entityEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                entityEN.Scenario.Id = p_scenario;
        }

        entityEN.Description = p_description;

        //Call to EntityCAD

        oid = _IEntityCAD.New_ (entityEN);
        return oid;
}

public void Modify (int p_Entity_OID, string p_name, string p_description)
{
        EntityEN entityEN = null;

        //Initialized EntityEN
        entityEN = new EntityEN ();
        entityEN.Id = p_Entity_OID;
        entityEN.Name = p_name;
        entityEN.Description = p_description;
        //Call to EntityCAD

        _IEntityCAD.Modify (entityEN);
}

public void Destroy (int id
                     )
{
        _IEntityCAD.Destroy (id);
}

public EntityEN ReadOID (int id
                         )
{
        EntityEN entityEN = null;

        entityEN = _IEntityCAD.ReadOID (id);
        return entityEN;
}

public System.Collections.Generic.IList<EntityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EntityEN> list = null;

        list = _IEntityCAD.ReadAll (first, size);
        return list;
}
}
}
