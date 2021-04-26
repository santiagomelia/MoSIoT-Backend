
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
 * Clase Notify:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class NotifyCAD : BasicCAD, INotifyCAD
{
public NotifyCAD() : base ()
{
}

public NotifyCAD(ISession sessionAux) : base (sessionAux)
{
}



public NotifyEN ReadOIDDefault (int id
                                )
{
        NotifyEN notifyEN = null;

        try
        {
                SessionInitializeTransaction ();
                notifyEN = (NotifyEN)session.Get (typeof(NotifyEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotifyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notifyEN;
}

public System.Collections.Generic.IList<NotifyEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<NotifyEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(NotifyEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<NotifyEN>();
                        else
                                result = session.CreateCriteria (typeof(NotifyEN)).List<NotifyEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotifyCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (NotifyEN notify)
{
        try
        {
                SessionInitializeTransaction ();
                NotifyEN notifyEN = (NotifyEN)session.Load (typeof(NotifyEN), notify.Id);

                session.Update (notifyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotifyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (NotifyEN notify)
{
        try
        {
                SessionInitializeTransaction ();
                if (notify.Entity != null) {
                        // Argumento OID y no colección.
                        notify.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), notify.Entity.Id);

                        notify.Entity.Operations
                        .Add (notify);
                }

                session.Save (notify);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotifyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notify.Id;
}

public void Modify (NotifyEN notify)
{
        try
        {
                SessionInitializeTransaction ();
                NotifyEN notifyEN = (NotifyEN)session.Load (typeof(NotifyEN), notify.Id);

                notifyEN.Name = notify.Name;


                notifyEN.Type = notify.Type;


                notifyEN.ServiceType = notify.ServiceType;


                notifyEN.Description = notify.Description;

                session.Update (notifyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotifyCAD.", ex);
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
                NotifyEN notifyEN = (NotifyEN)session.Load (typeof(NotifyEN), id);
                session.Delete (notifyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotifyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: NotifyEN
public NotifyEN ReadOID (int id
                         )
{
        NotifyEN notifyEN = null;

        try
        {
                SessionInitializeTransaction ();
                notifyEN = (NotifyEN)session.Get (typeof(NotifyEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotifyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notifyEN;
}

public System.Collections.Generic.IList<NotifyEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<NotifyEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(NotifyEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<NotifyEN>();
                else
                        result = session.CreateCriteria (typeof(NotifyEN)).List<NotifyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotifyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
