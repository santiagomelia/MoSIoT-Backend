using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class IMAppointmentDTO                   :                           EntityAttributesDTO


{
private Nullable<DateTime> date;
public Nullable<DateTime> Date {
        get { return date; } set { date = value;  }
}


private int appointment_oid;
public int Appointment_oid {
        get { return appointment_oid; } set { appointment_oid = value;  }
}
}
}
