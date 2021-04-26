using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class DeviceTemplateDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private System.Collections.Generic.IList<PropertyDTO> property;
public System.Collections.Generic.IList<PropertyDTO> Property {
        get { return property; } set { property = value;  }
}
private System.Collections.Generic.IList<CommandDTO> command;
public System.Collections.Generic.IList<CommandDTO> Command {
        get { return command; } set { command = value;  }
}
private System.Collections.Generic.IList<TelemetryDTO> telemetry;
public System.Collections.Generic.IList<TelemetryDTO> Telemetry {
        get { return telemetry; } set { telemetry = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum Type {
        get { return type; } set { type = value;  }
}
private bool isEdge;
public bool IsEdge {
        get { return isEdge; } set { isEdge = value;  }
}
}
}
