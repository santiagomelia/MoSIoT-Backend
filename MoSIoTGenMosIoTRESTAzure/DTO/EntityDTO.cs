using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class EntityDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}


private System.Collections.Generic.IList<int> originAssociation_oid;
public System.Collections.Generic.IList<int> OriginAssociation_oid {
        get { return originAssociation_oid; } set { originAssociation_oid = value;  }
}



private System.Collections.Generic.IList<int> targetAssociation_oid;
public System.Collections.Generic.IList<int> TargetAssociation_oid {
        get { return targetAssociation_oid; } set { targetAssociation_oid = value;  }
}



private int scenario_oid;
public int Scenario_oid {
        get { return scenario_oid; } set { scenario_oid = value;  }
}

private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private System.Collections.Generic.IList<EntityOperationDTO> operations;
public System.Collections.Generic.IList<EntityOperationDTO> Operations {
        get { return operations; } set { operations = value;  }
}
private System.Collections.Generic.IList<EntityAttributesDTO> attributes;
public System.Collections.Generic.IList<EntityAttributesDTO> Attributes {
        get { return attributes; } set { attributes = value;  }
}
private System.Collections.Generic.IList<EntityStateDTO> states;
public System.Collections.Generic.IList<EntityStateDTO> States {
        get { return states; } set { states = value;  }
}
}
}
