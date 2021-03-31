using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class CareActivityDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum periodicity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum Periodicity
{
        get { return periodicity; }
        set { periodicity = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}

private int duration;
public int Duration
{
        get { return duration; }
        set { duration = value; }
}

private string location;
public string Location
{
        get { return location; }
        set { location = value; }
}


/* Rol: CareActivity o--> Medication */
private MedicationDTOA medications;
public MedicationDTOA Medications
{
        get { return medications; }
        set { medications = value; }
}

/* GetAll: Appointment */
private IList<AppointmentDTOA> appointments;
public IList<AppointmentDTOA> Appointments
{
        get { return appointments; }
        set { appointments = value; }
}

/* Rol: CareActivity o--> NutritionOrder */
private NutritionOrderDTOA nutritionOrders;
public NutritionOrderDTOA NutritionOrders
{
        get { return nutritionOrders; }
        set { nutritionOrders = value; }
}
}
}