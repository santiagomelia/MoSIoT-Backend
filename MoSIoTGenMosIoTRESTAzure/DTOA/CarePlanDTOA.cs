using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class CarePlanDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private Nullable<DateTime> startDate;
public Nullable<DateTime> StartDate
{
        get { return startDate; }
        set { startDate = value; }
}

private Nullable<DateTime> endDate;
public Nullable<DateTime> EndDate
{
        get { return endDate; }
        set { endDate = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum Status
{
        get { return status; }
        set { status = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanInentEnum intent;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanInentEnum Intent
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


/* Rol: CarePlan o--> CareActivity */
private IList<CareActivityDTOA> careActivities;
public IList<CareActivityDTOA> CareActivities
{
        get { return careActivities; }
        set { careActivities = value; }
}

/* Rol: CarePlan o--> VitalSign */
private IList<VitalSignDTOA> vitalSigns;
public IList<VitalSignDTOA> VitalSigns
{
        get { return vitalSigns; }
        set { vitalSigns = value; }
}

/* Rol: CarePlan o--> Goal */
private IList<GoalDTOA> goals;
public IList<GoalDTOA> Goals
{
        get { return goals; }
        set { goals = value; }
}

/* Rol: CarePlan o--> PatientProfileCare */
private PatientProfileCareDTOA patient;
public PatientProfileCareDTOA Patient
{
        get { return patient; }
        set { patient = value; }
}
}
}
