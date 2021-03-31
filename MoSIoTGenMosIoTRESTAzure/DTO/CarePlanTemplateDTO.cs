using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class CarePlanTemplateDTO
{
private System.Collections.Generic.IList<CareActivityDTO> careActivity;
public System.Collections.Generic.IList<CareActivityDTO> CareActivity {
        get { return careActivity; } set { careActivity = value;  }
}


private int patientProfile_oid;
public int PatientProfile_oid {
        get { return patientProfile_oid; } set { patientProfile_oid = value;  }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum Status {
        get { return status; } set { status = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanInentEnum intent;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanInentEnum Intent {
        get { return intent; } set { intent = value;  }
}
private string title;
public string Title {
        get { return title; } set { title = value;  }
}
private Nullable<DateTime> modified;
public Nullable<DateTime> Modified {
        get { return modified; } set { modified = value;  }
}
private System.Collections.Generic.IList<GoalDTO> goals;
public System.Collections.Generic.IList<GoalDTO> Goals {
        get { return goals; } set { goals = value;  }
}


private System.Collections.Generic.IList<int> addressConditions_oid;
public System.Collections.Generic.IList<int> AddressConditions_oid {
        get { return addressConditions_oid; } set { addressConditions_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private int durationDays;
public int DurationDays {
        get { return durationDays; } set { durationDays = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private System.Collections.Generic.IList<ComunicationDTO> comunication;
public System.Collections.Generic.IList<ComunicationDTO> Comunication {
        get { return comunication; } set { comunication = value;  }
}
}
}
