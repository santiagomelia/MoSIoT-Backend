using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class RuleActionDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private int rule_oid;
public int Rule_oid {
        get { return rule_oid; } set { rule_oid = value;  }
}



private int operation_oid;
public int Operation_oid {
        get { return operation_oid; } set { operation_oid = value;  }
}
}
}
