using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class AdaptationRequestDTO
{
private MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum accessModeTarget;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum AccessModeTarget {
        get { return accessModeTarget; } set { accessModeTarget = value;  }
}
private int id;
public int Id {
        get { return id; } set { id = value;  }
}


private int accessMode_oid;
public int AccessMode_oid {
        get { return accessMode_oid; } set { accessMode_oid = value;  }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum languageOfAdaptation;
public MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum LanguageOfAdaptation {
        get { return languageOfAdaptation; } set { languageOfAdaptation = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
