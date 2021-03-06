using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class CareActivityDTO
{
private int carePlanTemplate_oid;
public int CarePlanTemplate_oid {
        get { return carePlanTemplate_oid; } set { carePlanTemplate_oid = value;  }
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
private AppointmentDTO appointment;
public AppointmentDTO Appointment {
        get { return appointment; } set { appointment = value;  }
}
}
}
