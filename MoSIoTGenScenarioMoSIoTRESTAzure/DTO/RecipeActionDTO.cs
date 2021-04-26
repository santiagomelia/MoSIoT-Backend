using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class RecipeActionDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private int recipe_oid;
public int Recipe_oid {
        get { return recipe_oid; } set { recipe_oid = value;  }
}



private int operation_oid;
public int Operation_oid {
        get { return operation_oid; } set { operation_oid = value;  }
}

private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
