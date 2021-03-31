using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class NotificationUserDTO
{
private int notification_oid;
public int Notification_oid {
        get { return notification_oid; } set { notification_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private string user_oid;
public string User_oid {
        get { return user_oid; } set { user_oid = value;  }
}

private bool isReceived;
public bool IsReceived {
        get { return isReceived; } set { isReceived = value;  }
}
}
}
