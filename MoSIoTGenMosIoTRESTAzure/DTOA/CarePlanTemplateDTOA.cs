using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class CarePlanTemplateDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum Status
{
        get { return status; }
        set { status = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanIntentEnum intent;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanIntentEnum Intent
{
        get { return intent; }
        set { intent = value; }
}

private string title;
public string Title
{
        get { return title; }
        set { title = value; }
}

private Nullable<DateTime> modified;
public Nullable<DateTime> Modified
{
        get { return modified; }
        set { modified = value; }
}

private int durationDays;
public int DurationDays
{
        get { return durationDays; }
        set { durationDays = value; }
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


/* Rol: CarePlanTemplate o--> CareActivity */
private IList<CareActivityDTOA> careActivities;
public IList<CareActivityDTOA> CareActivities
{
        get { return careActivities; }
        set { careActivities = value; }
}

/* Rol: CarePlanTemplate o--> Goal */
private IList<GoalDTOA> goals;
public IList<GoalDTOA> Goals
{
        get { return goals; }
        set { goals = value; }
}

/* Rol: CarePlanTemplate o--> PatientProfileCare */
private PatientProfileCareDTOA patient;
public PatientProfileCareDTOA Patient
{
        get { return patient; }
        set { patient = value; }
}

/* Rol: CarePlanTemplate o--> Condition_CarePlan */
private IList<Condition_CarePlanDTOA> addressConditions;
public IList<Condition_CarePlanDTOA> AddressConditions
{
        get { return addressConditions; }
        set { addressConditions = value; }
}
}
}
