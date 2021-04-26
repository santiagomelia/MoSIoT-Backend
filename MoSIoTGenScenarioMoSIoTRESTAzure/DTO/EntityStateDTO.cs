using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class EntityStateDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private int virtualEntity_oid;
public int VirtualEntity_oid {
        get { return virtualEntity_oid; } set { virtualEntity_oid = value;  }
}



private System.Collections.Generic.IList<int> originOperations_oid;
public System.Collections.Generic.IList<int> OriginOperations_oid {
        get { return originOperations_oid; } set { originOperations_oid = value;  }
}



private System.Collections.Generic.IList<int> targetOperations_oid;
public System.Collections.Generic.IList<int> TargetOperations_oid {
        get { return targetOperations_oid; } set { targetOperations_oid = value;  }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.StateTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.StateTypeEnum Type {
        get { return type; } set { type = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
