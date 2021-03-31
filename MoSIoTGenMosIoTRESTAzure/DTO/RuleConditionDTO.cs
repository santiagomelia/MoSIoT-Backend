using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class RuleConditionDTO
{
private int rule_oid;
public int Rule_oid {
        get { return rule_oid; } set { rule_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum operator_;
public MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum Operator_ {
        get { return operator_; } set { operator_ = value;  }
}
private string value;
public string Value {
        get { return value; } set { value = value;  }
}


private System.Collections.Generic.IList<int> entityAttributes_oid;
public System.Collections.Generic.IList<int> EntityAttributes_oid {
        get { return entityAttributes_oid; } set { entityAttributes_oid = value;  }
}
}
}
