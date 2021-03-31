using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class GoalDTO
{
private int carePlan_oid;
public int CarePlan_oid {
        get { return carePlan_oid; } set { carePlan_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum priority;
public MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum Priority {
        get { return priority; } set { priority = value;  }
}
private System.Collections.Generic.IList<TargetDTO> targets;
public System.Collections.Generic.IList<TargetDTO> Targets {
        get { return targets; } set { targets = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum Status {
        get { return status; } set { status = value;  }
}


private int condition_oid;
public int Condition_oid {
        get { return condition_oid; } set { condition_oid = value;  }
}

private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum category;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum Category {
        get { return category; } set { category = value;  }
}
private string outcomeCode;
public string OutcomeCode {
        get { return outcomeCode; } set { outcomeCode = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
}
}
