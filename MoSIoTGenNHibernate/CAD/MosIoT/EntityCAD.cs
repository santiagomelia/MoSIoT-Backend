
using System;
using System.Text;
using MoSIoTGenNHibernate.CEN.MosIoT;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Exceptions;


/*
 * Clase Entity:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class EntityCAD : BasicCAD, IEntityCAD
{
public EntityCAD() : base ()
{
}

public EntityCAD(ISession sessionAux) : base (sessionAux)
{
}



public EntityEN ReadOIDDefault (int id
                                )
{
        EntityEN entityEN = null;

        try
        {
                SessionInitializeTransaction ();
                entityEN = (EntityEN)session.Get (typeof(EntityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityEN;
}

public System.Collections.Generic.IList<EntityEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EntityEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EntityEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EntityEN>();
                        else
                                result = session.CreateCriteria (typeof(EntityEN)).List<EntityEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EntityEN entity)
{
        try
        {
                SessionInitializeTransaction ();
                EntityEN entityEN = (EntityEN)session.Load (typeof(EntityEN), entity.Id);

                entityEN.Name = entity.Name;





                entityEN.Description = entity.Description;




                session.Update (entityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EntityEN entity)
{
        try
        {
                SessionInitializeTransaction ();
                if (entity.Scenario != null) {
                        // Argumento OID y no colección.
                        entity.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), entity.Scenario.Id);

                        entity.Scenario.Entity
                        .Add (entity);
                }

                session.Save (entity);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entity.Id;
}

public void Modify (EntityEN entity)
{
        try
        {
                SessionInitializeTransaction ();
                EntityEN entityEN = (EntityEN)session.Load (typeof(EntityEN), entity.Id);

                entityEN.Name = entity.Name;


                entityEN.Description = entity.Description;

                session.Update (entityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                EntityEN entityEN = (EntityEN)session.Load (typeof(EntityEN), id);
                session.Delete (entityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: EntityEN
public EntityEN ReadOID (int id
                         )
{
        EntityEN entityEN = null;

        try
        {
                SessionInitializeTransaction ();
                entityEN = (EntityEN)session.Get (typeof(EntityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityEN;
}

public System.Collections.Generic.IList<EntityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EntityEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EntityEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EntityEN>();
                else
                        result = session.CreateCriteria (typeof(EntityEN)).List<EntityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
