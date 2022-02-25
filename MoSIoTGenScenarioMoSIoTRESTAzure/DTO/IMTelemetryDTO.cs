using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class IMTelemetryDTO                     :                           EntityDTO


{
private int telemetry_oid;
public int Telemetry_oid {
        get { return telemetry_oid; } set { telemetry_oid = value;  }
}



private System.Collections.Generic.IList<int> iMTelemetryValues_oid;
public System.Collections.Generic.IList<int> IMTelemetryValues_oid {
        get { return iMTelemetryValues_oid; } set { iMTelemetryValues_oid = value;  }
}
}
}
