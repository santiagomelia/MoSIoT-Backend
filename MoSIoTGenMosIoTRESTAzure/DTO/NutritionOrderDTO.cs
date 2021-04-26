using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class NutritionOrderDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private string dietCode;
public string DietCode {
        get { return dietCode; } set { dietCode = value;  }
}


private int careActivity_oid;
public int CareActivity_oid {
        get { return careActivity_oid; } set { careActivity_oid = value;  }
}

private string name;
public string Name {
        get { return name; } set { name = value;  }
}
}
}
