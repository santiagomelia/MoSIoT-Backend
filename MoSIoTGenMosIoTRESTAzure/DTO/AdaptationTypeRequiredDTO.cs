using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class AdaptationTypeRequiredDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum adaptionRequest;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum AdaptionRequest {
        get { return adaptionRequest; } set { adaptionRequest = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}


private int accessMode_oid;
public int AccessMode_oid {
        get { return accessMode_oid; } set { accessMode_oid = value;  }
}
}
}
