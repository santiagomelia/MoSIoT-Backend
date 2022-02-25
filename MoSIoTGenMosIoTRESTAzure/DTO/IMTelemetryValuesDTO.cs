using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class IMTelemetryValuesDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private Nullable<DateTime> timeStamp;
public Nullable<DateTime> TimeStamp {
        get { return timeStamp; } set { timeStamp = value;  }
}
private string valu;
public string Valu {
        get { return valu; } set { valu = value;  }
}


private int iMTelemetry_oid;
public int IMTelemetry_oid {
        get { return iMTelemetry_oid; } set { iMTelemetry_oid = value;  }
}
}
}
