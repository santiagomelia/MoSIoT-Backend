using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class NotificationDTO
{
private MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum Severity {
        get { return severity; } set { severity = value;  }
}
private string message;
public string Message {
        get { return message; } set { message = value;  }
}
private Nullable<DateTime> sendDate;
public Nullable<DateTime> SendDate {
        get { return sendDate; } set { sendDate = value;  }
}


private System.Collections.Generic.IList<string> receivers_oid;
public System.Collections.Generic.IList<string> Receivers_oid {
        get { return receivers_oid; } set { receivers_oid = value;  }
}



private int carePlan_oid;
public int CarePlan_oid {
        get { return carePlan_oid; } set { carePlan_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
}
}
