
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
 * Clase EntityArgument:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class EntityArgumentCAD : BasicCAD, IEntityArgumentCAD
{
public EntityArgumentCAD() : base ()
{
}

public EntityArgumentCAD(ISession sessionAux) : base (sessionAux)
{
}



public EntityArgumentEN ReadOIDDefault (int id
                                        )
{
        EntityArgumentEN entityArgumentEN = null;

        try
        {
                SessionInitializeTransaction ();
                entityArgumentEN = (EntityArgumentEN)session.Get (typeof(EntityArgumentEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityArgumentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityArgumentEN;
}

public System.Collections.Generic.IList<EntityArgumentEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EntityArgumentEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EntityArgumentEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EntityArgumentEN>();
                        else
                                result = session.CreateCriteria (typeof(EntityArgumentEN)).List<EntityArgumentEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityArgumentCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EntityArgumentEN entityArgument)
{
        try
        {
                SessionInitializeTransaction ();
                EntityArgumentEN entityArgumentEN = (EntityArgumentEN)session.Load (typeof(EntityArgumentEN), entityArgument.Id);

                entityArgumentEN.Name = entityArgument.Name;


                entityArgumentEN.Type = entityArgument.Type;


                session.Update (entityArgumentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityArgumentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EntityArgumentEN entityArgument)
{
        try
        {
                SessionInitializeTransaction ();
                if (entityArgument.EntityOperation != null) {
                        // Argumento OID y no colección.
                        entityArgument.EntityOperation = (MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN), entityArgument.EntityOperation.Id);

                        entityArgument.EntityOperation.EntityArgument
                        .Add (entityArgument);
                }

                session.Save (entityArgument);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityArgumentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityArgument.Id;
}

public void Modify (EntityArgumentEN entityArgument)
{
        try
        {
                SessionInitializeTransaction ();
                EntityArgumentEN entityArgumentEN = (EntityArgumentEN)session.Load (typeof(EntityArgumentEN), entityArgument.Id);

                entityArgumentEN.Name = entityArgument.Name;


                entityArgumentEN.Type = entityArgument.Type;

                session.Update (entityArgumentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityArgumentCAD.", ex);
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
                EntityArgumentEN entityArgumentEN = (EntityArgumentEN)session.Load (typeof(EntityArgumentEN), id);
                session.Delete (entityArgumentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityArgumentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: EntityArgumentEN
public EntityArgumentEN ReadOID (int id
                                 )
{
        EntityArgumentEN entityArgumentEN = null;

        try
        {
                SessionInitializeTransaction ();
                entityArgumentEN = (EntityArgumentEN)session.Get (typeof(EntityArgumentEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityArgumentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityArgumentEN;
}

public System.Collections.Generic.IList<EntityArgumentEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EntityArgumentEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EntityArgumentEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EntityArgumentEN>();
                else
                        result = session.CreateCriteria (typeof(EntityArgumentEN)).List<EntityArgumentEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityArgumentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
