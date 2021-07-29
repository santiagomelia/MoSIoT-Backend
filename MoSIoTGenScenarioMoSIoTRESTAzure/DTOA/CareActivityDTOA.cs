using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class CareActivityDTOA
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

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum periodicity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum Periodicity
{
        get { return periodicity; }
        set { periodicity = value; }
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

private string outcomeCode;
public string OutcomeCode
{
        get { return outcomeCode; }
        set { outcomeCode = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum typeActivity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum TypeActivity
{
        get { return typeActivity; }
        set { typeActivity = value; }
}

private string activityCode;
public string ActivityCode
{
        get { return activityCode; }
        set { activityCode = value; }
}


/* Rol: CareActivity o--> Comunication */
private IList<ComunicationDTOA> comunications;
public IList<ComunicationDTOA> Comunications
{
        get { return comunications; }
        set { comunications = value; }
}

/* Rol: CareActivity o--> Appointment */
private AppointmentDTOA appointments;
public AppointmentDTOA Appointments
{
        get { return appointments; }
        set { appointments = value; }
}

/* Rol: CareActivity o--> Medication */
private MedicationDTOA medications;
public MedicationDTOA Medications
{
        get { return medications; }
        set { medications = value; }
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
