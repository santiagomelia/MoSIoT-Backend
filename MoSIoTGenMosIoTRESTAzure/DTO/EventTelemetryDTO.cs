using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class EventTelemetryDTO                  :                           SpecificTelemetryDTO


{
private MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum Severity {
        get { return severity; } set { severity = value;  }
}


private int eventCommand_oid;
public int EventCommand_oid {
        get { return eventCommand_oid; } set { eventCommand_oid = value;  }
}



private int notification_oid;
public int Notification_oid {
        get { return notification_oid; } set { notification_oid = value;  }
}
}
}
