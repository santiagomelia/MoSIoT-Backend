

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
 *      Definition of the class NotificationCEN
 *
 */
public partial class NotificationCEN
{
private INotificationCAD _INotificationCAD;

public NotificationCEN()
{
        this._INotificationCAD = new NotificationCAD ();
}

public NotificationCEN(INotificationCAD _INotificationCAD)
{
        this._INotificationCAD = _INotificationCAD;
}

public INotificationCAD get_INotificationCAD ()
{
        return this._INotificationCAD;
}

public int New_ (MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum p_severity, string p_message, Nullable<DateTime> p_sendDate)
{
        NotificationEN notificationEN = null;
        int oid;

        //Initialized NotificationEN
        notificationEN = new NotificationEN ();
        notificationEN.Severity = p_severity;

        notificationEN.Message = p_message;

        notificationEN.SendDate = p_sendDate;

        //Call to NotificationCAD

        oid = _INotificationCAD.New_ (notificationEN);
        return oid;
}

public void Modify (int p_Notification_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum p_severity, string p_message, Nullable<DateTime> p_sendDate)
{
        NotificationEN notificationEN = null;

        //Initialized NotificationEN
        notificationEN = new NotificationEN ();
        notificationEN.Id = p_Notification_OID;
        notificationEN.Severity = p_severity;
        notificationEN.Message = p_message;
        notificationEN.SendDate = p_sendDate;
        //Call to NotificationCAD

        _INotificationCAD.Modify (notificationEN);
}

public void Destroy (int id
                     )
{
        _INotificationCAD.Destroy (id);
}
}
}
