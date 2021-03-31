
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
 * Clase Notification:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class NotificationCAD : BasicCAD, INotificationCAD
{
public NotificationCAD() : base ()
{
}

public NotificationCAD(ISession sessionAux) : base (sessionAux)
{
}



public NotificationEN ReadOIDDefault (int id
                                      )
{
        NotificationEN notificationEN = null;

        try
        {
                SessionInitializeTransaction ();
                notificationEN = (NotificationEN)session.Get (typeof(NotificationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notificationEN;
}

public System.Collections.Generic.IList<NotificationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<NotificationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(NotificationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<NotificationEN>();
                        else
                                result = session.CreateCriteria (typeof(NotificationEN)).List<NotificationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (NotificationEN notification)
{
        try
        {
                SessionInitializeTransaction ();
                NotificationEN notificationEN = (NotificationEN)session.Load (typeof(NotificationEN), notification.Id);

                notificationEN.Severity = notification.Severity;


                notificationEN.Message = notification.Message;


                notificationEN.SendDate = notification.SendDate;



                session.Update (notificationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (NotificationEN notification)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (notification);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return notification.Id;
}

public void Modify (NotificationEN notification)
{
        try
        {
                SessionInitializeTransaction ();
                NotificationEN notificationEN = (NotificationEN)session.Load (typeof(NotificationEN), notification.Id);

                notificationEN.Severity = notification.Severity;


                notificationEN.Message = notification.Message;


                notificationEN.SendDate = notification.SendDate;

                session.Update (notificationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationCAD.", ex);
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
                NotificationEN notificationEN = (NotificationEN)session.Load (typeof(NotificationEN), id);
                session.Delete (notificationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NotificationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
