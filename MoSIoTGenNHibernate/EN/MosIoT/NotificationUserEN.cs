
using System;
// Definición clase NotificationUserEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class NotificationUserEN
{
/**
 *	Atributo notification
 */
private MoSIoTGenNHibernate.EN.MosIoT.NotificationEN notification;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo user
 */
private MoSIoTGenNHibernate.EN.MosIoT.UserEN user;



/**
 *	Atributo isReceived
 */
private bool isReceived;






public virtual MoSIoTGenNHibernate.EN.MosIoT.NotificationEN Notification {
        get { return notification; } set { notification = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.UserEN User {
        get { return user; } set { user = value;  }
}



public virtual bool IsReceived {
        get { return isReceived; } set { isReceived = value;  }
}





public NotificationUserEN()
{
}



public NotificationUserEN(int id, MoSIoTGenNHibernate.EN.MosIoT.NotificationEN notification, MoSIoTGenNHibernate.EN.MosIoT.UserEN user, bool isReceived
                          )
{
        this.init (Id, notification, user, isReceived);
}


public NotificationUserEN(NotificationUserEN notificationUser)
{
        this.init (Id, notificationUser.Notification, notificationUser.User, notificationUser.IsReceived);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.NotificationEN notification, MoSIoTGenNHibernate.EN.MosIoT.UserEN user, bool isReceived)
{
        this.Id = id;


        this.Notification = notification;

        this.User = user;

        this.IsReceived = isReceived;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NotificationUserEN t = obj as NotificationUserEN;
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
