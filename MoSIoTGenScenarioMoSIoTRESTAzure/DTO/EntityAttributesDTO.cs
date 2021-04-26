using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class EntityAttributesDTO
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
private bool isOID;
public bool IsOID {
        get { return isOID; } set { isOID = value;  }
}


private System.Collections.Generic.IList<int> targetAssociation_oid;
public System.Collections.Generic.IList<int> TargetAssociation_oid {
        get { return targetAssociation_oid; } set { targetAssociation_oid = value;  }
}



private System.Collections.Generic.IList<int> originAsociation_oid;
public System.Collections.Generic.IList<int> OriginAsociation_oid {
        get { return originAsociation_oid; } set { originAsociation_oid = value;  }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum AssociationType {
        get { return associationType; } set { associationType = value;  }
}
private bool isWritable;
public bool IsWritable {
        get { return isWritable; } set { isWritable = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}


private int entity_oid;
public int Entity_oid {
        get { return entity_oid; } set { entity_oid = value;  }
}



private System.Collections.Generic.IList<int> trigger_oid;
public System.Collections.Generic.IList<int> Trigger_oid {
        get { return trigger_oid; } set { trigger_oid = value;  }
}



private System.Collections.Generic.IList<int> register_oid;
public System.Collections.Generic.IList<int> Register_oid {
        get { return register_oid; } set { register_oid = value;  }
}

private string value;
public string Value {
        get { return value; } set { value = value;  }
}
}
}
