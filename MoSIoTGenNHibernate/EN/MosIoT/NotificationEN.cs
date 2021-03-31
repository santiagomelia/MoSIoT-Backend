
using System;
// Definición clase NotificationEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class NotificationEN
{
/**
 *	Atributo severity
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity;



/**
 *	Atributo message
 */
private string message;



/**
 *	Atributo sendDate
 */
private Nullable<DateTime> sendDate;



/**
 *	Atributo receivers
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.UserEN> receivers;



/**
 *	Atributo carePlan
 */
private MoSIoTGenNHibernate.EN.MosIoT.CarePlanEN carePlan;



/**
 *	Atributo id
 */
private int id;






public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum Severity {
        get { return severity; } set { severity = value;  }
}



public virtual string Message {
        get { return message; } set { message = value;  }
}



public virtual Nullable<DateTime> SendDate {
        get { return sendDate; } set { sendDate = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.UserEN> Receivers {
        get { return receivers; } set { receivers = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.CarePlanEN CarePlan {
        get { return carePlan; } set { carePlan = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public NotificationEN()
{
        receivers = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.UserEN>();
}



public NotificationEN(int id, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity, string message, Nullable<DateTime> sendDate, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.UserEN> receivers, MoSIoTGenNHibernate.EN.MosIoT.CarePlanEN carePlan
                      )
{
        this.init (Id, severity, message, sendDate, receivers, carePlan);
}


public NotificationEN(NotificationEN notification)
{
        this.init (Id, notification.Severity, notification.Message, notification.SendDate, notification.Receivers, notification.CarePlan);
}

private void init (int id
                   , MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity, string message, Nullable<DateTime> sendDate, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.UserEN> receivers, MoSIoTGenNHibernate.EN.MosIoT.CarePlanEN carePlan)
{
        this.Id = id;


        this.Severity = severity;

        this.Message = message;

        this.SendDate = sendDate;

        this.Receivers = receivers;

        this.CarePlan = carePlan;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NotificationEN t = obj as NotificationEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
