using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class PropertyDTO
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
private bool isWritable;
public bool IsWritable {
        get { return isWritable; } set { isWritable = value;  }
}
private bool isCloudable;
public bool IsCloudable {
        get { return isCloudable; } set { isCloudable = value;  }
}


private System.Collections.Generic.IList<int> telemetry_oid;
public System.Collections.Generic.IList<int> Telemetry_oid {
        get { return telemetry_oid; } set { telemetry_oid = value;  }
}
}
}
