
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
 * Clase NotificationUser:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class NotificationUserCAD : BasicCAD, INotificationUserCAD
{
public NotificationUserCAD() : base ()
{
}

public NotificationUserCAD(ISession sessionAux) : base (sessionAux)
{
}



public NotificationUserEN ReadOIDDefault (int id
                                          )
{
        NotificationUserEN notificationUserEN = null;

        try
        {
                SessionInitializeTransaction ();
                notificationUserEN = (NotificationUserEN)session.Get (typeof(NotificationUserEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationUserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notificationUserEN;
}

public System.Collections.Generic.IList<NotificationUserEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<NotificationUserEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(NotificationUserEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<NotificationUserEN>();
                        else
                                result = session.CreateCriteria (typeof(NotificationUserEN)).List<NotificationUserEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationUserCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (NotificationUserEN notificationUser)
{
        try
        {
                SessionInitializeTransaction ();
                NotificationUserEN notificationUserEN = (NotificationUserEN)session.Load (typeof(NotificationUserEN), notificationUser.Id);



                notificationUserEN.IsReceived = notificationUser.IsReceived;

                session.Update (notificationUserEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationUserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (NotificationUserEN notificationUser)
{
        try
        {
                SessionInitializeTransaction ();
                if (notificationUser.Notification != null) {
                        // Argumento OID y no colección.
                        notificationUser.Notification = (MoSIoTGenNHibernate.EN.MosIoT.NotificationEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.NotificationEN), notificationUser.Notification.Id);

                        notificationUser.Notification.NotificationUSer
                        .Add (notificationUser);
                }
                if (notificationUser.User != null) {
                        // Argumento OID y no colección.
                        notificationUser.User = (MoSIoTGenNHibernate.EN.MosIoT.UserEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.UserEN), notificationUser.User.Email);

                        notificationUser.User.NotificationUSer
                        .Add (notificationUser);
                }

                session.Save (notificationUser);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationUserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notificationUser.Id;
}

public void Modify (NotificationUserEN notificationUser)
{
        try
        {
                SessionInitializeTransaction ();
                NotificationUserEN notificationUserEN = (NotificationUserEN)session.Load (typeof(NotificationUserEN), notificationUser.Id);

                notificationUserEN.IsReceived = notificationUser.IsReceived;

                session.Update (notificationUserEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationUserCAD.", ex);
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
                NotificationUserEN notificationUserEN = (NotificationUserEN)session.Load (typeof(NotificationUserEN), id);
                session.Delete (notificationUserEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationUserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
