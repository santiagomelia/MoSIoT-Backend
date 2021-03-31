using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class CommandDTO
{
private int deviceTemplate_oid;
public int DeviceTemplate_oid {
        get { return deviceTemplate_oid; } set { deviceTemplate_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private bool isSynchronous;
public bool IsSynchronous {
        get { return isSynchronous; } set { isSynchronous = value;  }
}


private System.Collections.Generic.IList<int> telemetries_oid;
public System.Collections.Generic.IList<int> Telemetries_oid {
        get { return telemetries_oid; } set { telemetries_oid = value;  }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum Type {
        get { return type; } set { type = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
