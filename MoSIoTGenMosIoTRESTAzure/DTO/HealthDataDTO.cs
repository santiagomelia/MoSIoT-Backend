using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class HealthDataDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum language;
public MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum Language {
        get { return language; } set { language = value;  }
}
private string system;
public string System {
        get { return system; } set { system = value;  }
}
private string code;
public string Code {
        get { return code; } set { code = value;  }
}
private string display;
public string Display {
        get { return display; } set { display = value;  }
}
}
}
