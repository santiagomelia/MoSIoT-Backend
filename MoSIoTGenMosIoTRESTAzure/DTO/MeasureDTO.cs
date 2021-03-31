using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class MeasureDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}


private System.Collections.Generic.IList<int> target_oid;
public System.Collections.Generic.IList<int> Target_oid {
        get { return target_oid; } set { target_oid = value;  }
}



private System.Collections.Generic.IList<int> telemetry_oid;
public System.Collections.Generic.IList<int> Telemetry_oid {
        get { return telemetry_oid; } set { telemetry_oid = value;  }
}

private string lOINCcode;
public string LOINCcode {
        get { return lOINCcode; } set { lOINCcode = value;  }
}
}
}
