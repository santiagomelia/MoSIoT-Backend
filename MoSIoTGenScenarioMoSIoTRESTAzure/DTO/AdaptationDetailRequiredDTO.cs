using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class AdaptationDetailRequiredDTO
{
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum adaptationRequest;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum AdaptationRequest {
        get { return adaptationRequest; } set { adaptationRequest = value;  }
}


private int accessMode_oid;
public int AccessMode_oid {
        get { return accessMode_oid; } set { accessMode_oid = value;  }
}

private string description;
public string Description {
        get { return description; } set { description = value;  }
}
}
}
