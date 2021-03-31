using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class TrademarkDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}


private System.Collections.Generic.IList<int> device_oid;
public System.Collections.Generic.IList<int> Device_oid {
        get { return device_oid; } set { device_oid = value;  }
}
}
}
