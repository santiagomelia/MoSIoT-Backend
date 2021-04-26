using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class DisabilityDTO
{
private int patient_oid;
public int Patient_oid {
        get { return patient_oid; } set { patient_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum Type {
        get { return type; } set { type = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum severity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum Severity {
        get { return severity; } set { severity = value;  }
}


private int origin_oid;
public int Origin_oid {
        get { return origin_oid; } set { origin_oid = value;  }
}



private System.Collections.Generic.IList<int> accessMode_oid;
public System.Collections.Generic.IList<int> AccessMode_oid {
        get { return accessMode_oid; } set { accessMode_oid = value;  }
}

private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
