
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
 * Clase EntityAttributes:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class EntityAttributesCAD : BasicCAD, IEntityAttributesCAD
{
public EntityAttributesCAD() : base ()
{
}

public EntityAttributesCAD(ISession sessionAux) : base (sessionAux)
{
}



public EntityAttributesEN ReadOIDDefault (int id
                                          )
{
        EntityAttributesEN entityAttributesEN = null;

        try
        {
                SessionInitializeTransaction ();
                entityAttributesEN = (EntityAttributesEN)session.Get (typeof(EntityAttributesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityAttributesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityAttributesEN;
}

public System.Collections.Generic.IList<EntityAttributesEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EntityAttributesEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EntityAttributesEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EntityAttributesEN>();
                        else
                                result = session.CreateCriteria (typeof(EntityAttributesEN)).List<EntityAttributesEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityAttributesCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EntityAttributesEN entityAttributes)
{
        try
        {
                SessionInitializeTransaction ();
                EntityAttributesEN entityAttributesEN = (EntityAttributesEN)session.Load (typeof(EntityAttributesEN), entityAttributes.Id);

                entityAttributesEN.Name = entityAttributes.Name;


                entityAttributesEN.Type = entityAttributes.Type;


                entityAttributesEN.IsOID = entityAttributes.IsOID;




                entityAttributesEN.AssociationType = entityAttributes.AssociationType;


                entityAttributesEN.IsWritable = entityAttributes.IsWritable;


                entityAttributesEN.Description = entityAttributes.Description;





                entityAttributesEN.Value = entityAttributes.Value;

                session.Update (entityAttributesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityAttributesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EntityAttributesEN entityAttributes)
{
        try
        {
                SessionInitializeTransaction ();
                if (entityAttributes.Entity != null) {
                        // Argumento OID y no colección.
                        entityAttributes.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), entityAttributes.Entity.Id);

                        entityAttributes.Entity.Attributes
                        .Add (entityAttributes);
                }

                session.Save (entityAttributes);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityAttributesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityAttributes.Id;
}

public void Modify (EntityAttributesEN entityAttributes)
{
        try
        {
                SessionInitializeTransaction ();
                EntityAttributesEN entityAttributesEN = (EntityAttributesEN)session.Load (typeof(EntityAttributesEN), entityAttributes.Id);

                entityAttributesEN.Name = entityAttributes.Name;


                entityAttributesEN.Type = entityAttributes.Type;


                entityAttributesEN.IsOID = entityAttributes.IsOID;


                entityAttributesEN.IsWritable = entityAttributes.IsWritable;


                entityAttributesEN.Description = entityAttributes.Description;


                entityAttributesEN.Value = entityAttributes.Value;

                session.Update (entityAttributesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityAttributesCAD.", ex);
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
                EntityAttributesEN entityAttributesEN = (EntityAttributesEN)session.Load (typeof(EntityAttributesEN), id);
                session.Delete (entityAttributesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityAttributesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: EntityAttributesEN
public EntityAttributesEN ReadOID (int id
                                   )
{
        EntityAttributesEN entityAttributesEN = null;

        try
        {
                SessionInitializeTransaction ();
                entityAttributesEN = (EntityAttributesEN)session.Get (typeof(EntityAttributesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityAttributesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return entityAttributesEN;
}

public System.Collections.Generic.IList<EntityAttributesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EntityAttributesEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EntityAttributesEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EntityAttributesEN>();
                else
                        result = session.CreateCriteria (typeof(EntityAttributesEN)).List<EntityAttributesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EntityAttributesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
