
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
 * Clase EntityOperation:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class EntityOperationCAD : BasicCAD, IEntityOperationCAD
{
public EntityOperationCAD() : base ()
{
}

public EntityOperationCAD(ISession sessionAux) : base (sessionAux)
{
}



public EntityOperationEN ReadOIDDefault (int id
                                         )
{
        EntityOperationEN entityOperationEN = null;

        try
        {
                SessionInitializeTransaction ();
                entityOperationEN = (EntityOperationEN)session.Get (typeof(EntityOperationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityOperationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityOperationEN;
}

public System.Collections.Generic.IList<EntityOperationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EntityOperationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EntityOperationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EntityOperationEN>();
                        else
                                result = session.CreateCriteria (typeof(EntityOperationEN)).List<EntityOperationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityOperationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EntityOperationEN entityOperation)
{
        try
        {
                SessionInitializeTransaction ();
                EntityOperationEN entityOperationEN = (EntityOperationEN)session.Load (typeof(EntityOperationEN), entityOperation.Id);

                entityOperationEN.Name = entityOperation.Name;


                entityOperationEN.Type = entityOperation.Type;


                entityOperationEN.ServiceType = entityOperation.ServiceType;


                entityOperationEN.Description = entityOperation.Description;







                session.Update (entityOperationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityOperationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public void Modify (EntityOperationEN entityOperation)
{
        try
        {
                SessionInitializeTransaction ();
                EntityOperationEN entityOperationEN = (EntityOperationEN)session.Load (typeof(EntityOperationEN), entityOperation.Id);

                entityOperationEN.Name = entityOperation.Name;


                entityOperationEN.Type = entityOperation.Type;


                entityOperationEN.ServiceType = entityOperation.ServiceType;


                entityOperationEN.Description = entityOperation.Description;

                session.Update (entityOperationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityOperationCAD.", ex);
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
                EntityOperationEN entityOperationEN = (EntityOperationEN)session.Load (typeof(EntityOperationEN), id);
                session.Delete (entityOperationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityOperationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public int New_ (EntityOperationEN entityOperation)
{
        try
        {
                SessionInitializeTransaction ();
                if (entityOperation.Entity != null) {
                        // Argumento OID y no colección.
                        entityOperation.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), entityOperation.Entity.Id);

                        entityOperation.Entity.Operations
                        .Add (entityOperation);
                }

                session.Save (entityOperation);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityOperationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityOperation.Id;
}

//Sin e: ReadOID
//Con e: EntityOperationEN
public EntityOperationEN ReadOID (int id
                                  )
{
        EntityOperationEN entityOperationEN = null;

        try
        {
                SessionInitializeTransaction ();
                entityOperationEN = (EntityOperationEN)session.Get (typeof(EntityOperationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityOperationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityOperationEN;
}

public System.Collections.Generic.IList<EntityOperationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EntityOperationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EntityOperationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EntityOperationEN>();
                else
                        result = session.CreateCriteria (typeof(EntityOperationEN)).List<EntityOperationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityOperationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
