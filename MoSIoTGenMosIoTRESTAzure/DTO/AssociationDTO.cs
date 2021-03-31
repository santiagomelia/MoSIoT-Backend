using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class AssociationDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}


private int rolOrigin_oid;
public int RolOrigin_oid {
        get { return rolOrigin_oid; } set { rolOrigin_oid = value;  }
}



private int rolTarget_oid;
public int RolTarget_oid {
        get { return rolTarget_oid; } set { rolTarget_oid = value;  }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum Type {
        get { return type; } set { type = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityOrigin;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum CardinalityOrigin {
        get { return cardinalityOrigin; } set { cardinalityOrigin = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityTarget;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum CardinalityTarget {
        get { return cardinalityTarget; } set { cardinalityTarget = value;  }
}


private int entityOrigin_oid;
public int EntityOrigin_oid {
        get { return entityOrigin_oid; } set { entityOrigin_oid = value;  }
}



private int entityTarget_oid;
public int EntityTarget_oid {
        get { return entityTarget_oid; } set { entityTarget_oid = value;  }
}



private int ioTScenario_oid;
public int IoTScenario_oid {
        get { return ioTScenario_oid; } set { ioTScenario_oid = value;  }
}
}
}
