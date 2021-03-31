using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class TargetDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private int goal_oid;
public int Goal_oid {
        get { return goal_oid; } set { goal_oid = value;  }
}

private string desiredValue;
public string DesiredValue {
        get { return desiredValue; } set { desiredValue = value;  }
}


private int measure_oid;
public int Measure_oid {
        get { return measure_oid; } set { measure_oid = value;  }
}

private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private Nullable<DateTime> dueDate;
public Nullable<DateTime> DueDate {
        get { return dueDate; } set { dueDate = value;  }
}
}
}
