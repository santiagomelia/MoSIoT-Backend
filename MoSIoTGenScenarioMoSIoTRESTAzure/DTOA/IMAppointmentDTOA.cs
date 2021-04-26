using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class IMAppointmentDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private string name;
public string Name
{
        get { return name; }
        set { name = value; }
}

private Nullable<DateTime> date;
public Nullable<DateTime> Date
{
        get { return date; }
        set { date = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}


/* Rol: IMAppointment o--> Appointment */
private AppointmentDTOA valueAppointment;
public AppointmentDTOA ValueAppointment
{
        get { return valueAppointment; }
        set { valueAppointment = value; }
}
}
}
