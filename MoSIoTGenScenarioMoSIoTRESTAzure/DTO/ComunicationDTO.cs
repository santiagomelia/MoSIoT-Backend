using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class ComunicationDTO
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
private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private System.Collections.Generic.IList<int> eventTelemetry_oid;
public System.Collections.Generic.IList<int> EventTelemetry_oid {
        get { return eventTelemetry_oid; } set { eventTelemetry_oid = value;  }
}



private int careActivity_oid;
public int CareActivity_oid {
        get { return careActivity_oid; } set { careActivity_oid = value;  }
}



private int carePlanTemplate_oid;
public int CarePlanTemplate_oid {
        get { return carePlanTemplate_oid; } set { carePlanTemplate_oid = value;  }
}
}
}
