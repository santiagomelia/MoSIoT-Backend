using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class SpecificTelemetryDTO
{
private int telemetry_oid;
public int Telemetry_oid {
        get { return telemetry_oid; } set { telemetry_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
}
}
