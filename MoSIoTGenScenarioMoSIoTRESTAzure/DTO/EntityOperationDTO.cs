using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class EntityOperationDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Type {
        get { return type; } set { type = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType;
public MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum ServiceType {
        get { return serviceType; } set { serviceType = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private System.Collections.Generic.IList<EntityArgumentDTO> entityArgument;
public System.Collections.Generic.IList<EntityArgumentDTO> EntityArgument {
        get { return entityArgument; } set { entityArgument = value;  }
}


private int entity_oid;
public int Entity_oid {
        get { return entity_oid; } set { entity_oid = value;  }
}



private System.Collections.Generic.IList<int> ruleAction_oid;
public System.Collections.Generic.IList<int> RuleAction_oid {
        get { return ruleAction_oid; } set { ruleAction_oid = value;  }
}



private int originState_oid;
public int OriginState_oid {
        get { return originState_oid; } set { originState_oid = value;  }
}



private int targetState_oid;
public int TargetState_oid {
        get { return targetState_oid; } set { targetState_oid = value;  }
}



private System.Collections.Generic.IList<int> triggers_oid;
public System.Collections.Generic.IList<int> Triggers_oid {
        get { return triggers_oid; } set { triggers_oid = value;  }
}
}
}
