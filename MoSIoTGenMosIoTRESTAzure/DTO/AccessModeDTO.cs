using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class AccessModeDTO
{
private int patient_oid;
public int Patient_oid {
        get { return patient_oid; } set { patient_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum typeAccessMode;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum TypeAccessMode {
        get { return typeAccessMode; } set { typeAccessMode = value;  }
}
private System.Collections.Generic.IList<AdaptationDetailRequiredDTO> adaptationDetailRequired;
public System.Collections.Generic.IList<AdaptationDetailRequiredDTO> AdaptationDetailRequired {
        get { return adaptationDetailRequired; } set { adaptationDetailRequired = value;  }
}


private System.Collections.Generic.IList<int> deviceTemplate_oid;
public System.Collections.Generic.IList<int> DeviceTemplate_oid {
        get { return deviceTemplate_oid; } set { deviceTemplate_oid = value;  }
}

private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private System.Collections.Generic.IList<AdaptationTypeRequiredDTO> adaptationTypeRequired;
public System.Collections.Generic.IList<AdaptationTypeRequiredDTO> AdaptationTypeRequired {
        get { return adaptationTypeRequired; } set { adaptationTypeRequired = value;  }
}
private System.Collections.Generic.IList<AdaptationRequestDTO> adaptationRequest;
public System.Collections.Generic.IList<AdaptationRequestDTO> AdaptationRequest {
        get { return adaptationRequest; } set { adaptationRequest = value;  }
}


private int disability_oid;
public int Disability_oid {
        get { return disability_oid; } set { disability_oid = value;  }
}

private string name;
public string Name {
        get { return name; } set { name = value;  }
}
}
}
