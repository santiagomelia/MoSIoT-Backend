using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class TelemetryDTO
{
private int deviceTemplate_oid;
public int DeviceTemplate_oid {
        get { return deviceTemplate_oid; } set { deviceTemplate_oid = value;  }
}

private double frecuency;
public double Frecuency {
        get { return frecuency; } set { frecuency = value;  }
}


private int typeTelemetry_oid;
public int TypeTelemetry_oid {
        get { return typeTelemetry_oid; } set { typeTelemetry_oid = value;  }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum schema;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Schema {
        get { return schema; } set { schema = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum unit;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum Unit {
        get { return unit; } set { unit = value;  }
}
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum Type {
        get { return type; } set { type = value;  }
}


private System.Collections.Generic.IList<int> properties_oid;
public System.Collections.Generic.IList<int> Properties_oid {
        get { return properties_oid; } set { properties_oid = value;  }
}



private int vitalSign_oid;
public int VitalSign_oid {
        get { return vitalSign_oid; } set { vitalSign_oid = value;  }
}
}
}
