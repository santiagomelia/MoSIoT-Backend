using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class IoTScenarioDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private System.Collections.Generic.IList<EntityDTO> entity;
public System.Collections.Generic.IList<EntityDTO> Entity {
        get { return entity; } set { entity = value;  }
}
private System.Collections.Generic.IList<RecipeDTO> recipes;
public System.Collections.Generic.IList<RecipeDTO> Recipes {
        get { return recipes; } set { recipes = value;  }
}
private System.Collections.Generic.IList<AssociationDTO> association;
public System.Collections.Generic.IList<AssociationDTO> Association {
        get { return association; } set { association = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
