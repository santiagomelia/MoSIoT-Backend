using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class RecipeDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private bool isEnabled;
public bool IsEnabled {
        get { return isEnabled; } set { isEnabled = value;  }
}
private RecipeTriggerDTO triggers;
public RecipeTriggerDTO Triggers {
        get { return triggers; } set { triggers = value;  }
}
private System.Collections.Generic.IList<RecipeActionDTO> recipeAction;
public System.Collections.Generic.IList<RecipeActionDTO> RecipeAction {
        get { return recipeAction; } set { recipeAction = value;  }
}


private int ioTScenario_oid;
public int IoTScenario_oid {
        get { return ioTScenario_oid; } set { ioTScenario_oid = value;  }
}

private double intervalTime;
public double IntervalTime {
        get { return intervalTime; } set { intervalTime = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
