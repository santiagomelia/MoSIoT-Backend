using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class RecipeTriggerDTO
{
private int recipe_oid;
public int Recipe_oid {
        get { return recipe_oid; } set { recipe_oid = value;  }
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



private int event__oid;
public int Event__oid {
        get { return event__oid; } set { event__oid = value;  }
}

private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
