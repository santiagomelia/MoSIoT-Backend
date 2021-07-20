using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class ConditionDTO
{
private int patientProfile_oid;
public int PatientProfile_oid {
        get { return patientProfile_oid; } set { patientProfile_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}


private System.Collections.Generic.IList<int> disabilities_oid;
public System.Collections.Generic.IList<int> Disabilities_oid {
        get { return disabilities_oid; } set { disabilities_oid = value;  }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum clinicalStatus;
public MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum ClinicalStatus {
        get { return clinicalStatus; } set { clinicalStatus = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum disease;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum Disease {
        get { return disease; } set { disease = value;  }
}


private System.Collections.Generic.IList<int> carePlanTemplate_oid;
public System.Collections.Generic.IList<int> CarePlanTemplate_oid {
        get { return carePlanTemplate_oid; } set { carePlanTemplate_oid = value;  }
}



private System.Collections.Generic.IList<int> goal_oid;
public System.Collections.Generic.IList<int> Goal_oid {
        get { return goal_oid; } set { goal_oid = value;  }
}

private string name;
public string Name {
        get { return name; } set { name = value;  }
}
}
}
