
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
 * Clase EntityState:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class EntityStateCAD : BasicCAD, IEntityStateCAD
{
public EntityStateCAD() : base ()
{
}

public EntityStateCAD(ISession sessionAux) : base (sessionAux)
{
}



public EntityStateEN ReadOIDDefault (int id
                                     )
{
        EntityStateEN entityStateEN = null;

        try
        {
                SessionInitializeTransaction ();
                entityStateEN = (EntityStateEN)session.Get (typeof(EntityStateEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityStateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityStateEN;
}

public System.Collections.Generic.IList<EntityStateEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EntityStateEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EntityStateEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EntityStateEN>();
                        else
                                result = session.CreateCriteria (typeof(EntityStateEN)).List<EntityStateEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityStateCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EntityStateEN entityState)
{
        try
        {
                SessionInitializeTransaction ();
                EntityStateEN entityStateEN = (EntityStateEN)session.Load (typeof(EntityStateEN), entityState.Id);




                entityStateEN.Type = entityState.Type;


                entityStateEN.Name = entityState.Name;


                entityStateEN.Description = entityState.Description;

                session.Update (entityStateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityStateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EntityStateEN entityState)
{
        try
        {
                SessionInitializeTransaction ();
                if (entityState.VirtualEntity != null) {
                        // Argumento OID y no colección.
                        entityState.VirtualEntity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), entityState.VirtualEntity.Id);

                        entityState.VirtualEntity.States
                        .Add (entityState);
                }

                session.Save (entityState);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityStateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityState.Id;
}

public void Modify (EntityStateEN entityState)
{
        try
        {
                SessionInitializeTransaction ();
                EntityStateEN entityStateEN = (EntityStateEN)session.Load (typeof(EntityStateEN), entityState.Id);

                entityStateEN.Type = entityState.Type;


                entityStateEN.Name = entityState.Name;


                entityStateEN.Description = entityState.Description;

                session.Update (entityStateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityStateCAD.", ex);
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
                EntityStateEN entityStateEN = (EntityStateEN)session.Load (typeof(EntityStateEN), id);
                session.Delete (entityStateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityStateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
