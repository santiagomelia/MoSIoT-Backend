using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class InheritanceDTO
{
private System.Collections.Generic.IList<int> father_oid;
public System.Collections.Generic.IList<int> Father_oid {
        get { return father_oid; } set { father_oid = value;  }
}



private int son_oid;
public int Son_oid {
        get { return son_oid; } set { son_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
}
}
