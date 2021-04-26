using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class AppointmentDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private bool isVirtual;
public bool IsVirtual {
        get { return isVirtual; } set { isVirtual = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private string direction;
public string Direction {
        get { return direction; } set { direction = value;  }
}
private string reasonCode;
public string ReasonCode {
        get { return reasonCode; } set { reasonCode = value;  }
}


private int careActivity_oid;
public int CareActivity_oid {
        get { return careActivity_oid; } set { careActivity_oid = value;  }
}
}
}
