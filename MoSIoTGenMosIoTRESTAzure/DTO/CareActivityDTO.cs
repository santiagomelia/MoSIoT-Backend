using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class CareActivityDTO
{
private int carePlan_oid;
public int CarePlan_oid {
        get { return carePlan_oid; } set { carePlan_oid = value;  }
}

private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum periodicity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum Periodicity {
        get { return periodicity; } set { periodicity = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private int duration;
public int Duration {
        get { return duration; } set { duration = value;  }
}
private MedicationDTO medication;
public MedicationDTO Medication {
        get { return medication; } set { medication = value;  }
}
private string location;
public string Location {
        get { return location; } set { location = value;  }
}
private string outcomeCode;
public string OutcomeCode {
        get { return outcomeCode; } set { outcomeCode = value;  }
}
private NutritionOrderDTO nutritionOrder;
public NutritionOrderDTO NutritionOrder {
        get { return nutritionOrder; } set { nutritionOrder = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum typeActivity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum TypeActivity {
        get { return typeActivity; } set { typeActivity = value;  }
}


private int nextActivity_oid;
public int NextActivity_oid {
        get { return nextActivity_oid; } set { nextActivity_oid = value;  }
}



private int previousActivity_oid;
public int PreviousActivity_oid {
        get { return previousActivity_oid; } set { previousActivity_oid = value;  }
}

private System.Collections.Generic.IList<ComunicationDTO> notification;
public System.Collections.Generic.IList<ComunicationDTO> Notification {
        get { return notification; } set { notification = value;  }
}
private string activityCode;
public string ActivityCode {
        get { return activityCode; } set { activityCode = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private System.Collections.Generic.IList<AppointmentDTO> appointment;
public System.Collections.Generic.IList<AppointmentDTO> Appointment {
        get { return appointment; } set { appointment = value;  }
}
}
}
