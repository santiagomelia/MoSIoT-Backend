using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class EntityArgumentDTO
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


private int entityOperation_oid;
public int EntityOperation_oid {
        get { return entityOperation_oid; } set { entityOperation_oid = value;  }
}
}
}
