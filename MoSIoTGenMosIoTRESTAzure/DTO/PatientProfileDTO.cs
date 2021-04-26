using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class PatientProfileDTO
{
private System.Collections.Generic.IList<AccessModeDTO> accessMode;
public System.Collections.Generic.IList<AccessModeDTO> AccessMode {
        get { return accessMode; } set { accessMode = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum preferredLanguage;
public MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum PreferredLanguage {
        get { return preferredLanguage; } set { preferredLanguage = value;  }
}
private string region;
public string Region {
        get { return region; } set { region = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum hazardAvoidance;
public MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum HazardAvoidance {
        get { return hazardAvoidance; } set { hazardAvoidance = value;  }
}
private System.Collections.Generic.IList<DisabilityDTO> disability;
public System.Collections.Generic.IList<DisabilityDTO> Disability {
        get { return disability; } set { disability = value;  }
}
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private System.Collections.Generic.IList<ConditionDTO> diseases;
public System.Collections.Generic.IList<ConditionDTO> Diseases {
        get { return diseases; } set { diseases = value;  }
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
