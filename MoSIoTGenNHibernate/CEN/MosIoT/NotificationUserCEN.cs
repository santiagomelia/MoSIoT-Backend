

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
 *      Definition of the class NotificationUserCEN
 *
 */
public partial class NotificationUserCEN
{
private INotificationUserCAD _INotificationUserCAD;

public NotificationUserCEN()
{
        this._INotificationUserCAD = new NotificationUserCAD ();
}

public NotificationUserCEN(INotificationUserCAD _INotificationUserCAD)
{
        this._INotificationUserCAD = _INotificationUserCAD;
}

public INotificationUserCAD get_INotificationUserCAD ()
{
        return this._INotificationUserCAD;
}

public int New_ (int p_notification, string p_user, bool p_isReceived)
{
        NotificationUserEN notificationUserEN = null;
        int oid;

        //Initialized NotificationUserEN
        notificationUserEN = new NotificationUserEN ();

        if (p_notification != -1) {
                // El argumento p_notification -> Property notification es oid = false
                // Lista de oids id
                notificationUserEN.Notification = new MoSIoTGenNHibernate.EN.MosIoT.NotificationEN ();
                notificationUserEN.Notification.Id = p_notification;
        }


        if (p_user != null) {
                // El argumento p_user -> Property user es oid = false
                // Lista de oids id
                notificationUserEN.User = new MoSIoTGenNHibernate.EN.MosIoT.UserEN ();
                notificationUserEN.User.Email = p_user;
        }

        notificationUserEN.IsReceived = p_isReceived;

        //Call to NotificationUserCAD

        oid = _INotificationUserCAD.New_ (notificationUserEN);
        return oid;
}

public void Modify (int p_NotificationUser_OID, bool p_isReceived)
{
        NotificationUserEN notificationUserEN = null;

        //Initialized NotificationUserEN
        notificationUserEN = new NotificationUserEN ();
        notificationUserEN.Id = p_NotificationUser_OID;
        notificationUserEN.IsReceived = p_isReceived;
        //Call to NotificationUserCAD

        _INotificationUserCAD.Modify (notificationUserEN);
}

public void Destroy (int id
                     )
{
        _INotificationUserCAD.Destroy (id);
}
}
}
