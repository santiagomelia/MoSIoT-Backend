using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class StateDeviceDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private string value;
public string Value {
        get { return value; } set { value = value;  }
}


private int stateTelemetry_oid;
public int StateTelemetry_oid {
        get { return stateTelemetry_oid; } set { stateTelemetry_oid = value;  }
}
}
}
