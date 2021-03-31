using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class RuleDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private bool isEnabled;
public bool IsEnabled {
        get { return isEnabled; } set { isEnabled = value;  }
}
private System.Collections.Generic.IList<RuleConditionDTO> condition;
public System.Collections.Generic.IList<RuleConditionDTO> Condition {
        get { return condition; } set { condition = value;  }
}
private System.Collections.Generic.IList<RuleActionDTO> ruleAction;
public System.Collections.Generic.IList<RuleActionDTO> RuleAction {
        get { return ruleAction; } set { ruleAction = value;  }
}


private int ioTScenario_oid;
public int IoTScenario_oid {
        get { return ioTScenario_oid; } set { ioTScenario_oid = value;  }
}

private double intervalTime;
public double IntervalTime {
        get { return intervalTime; } set { intervalTime = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
