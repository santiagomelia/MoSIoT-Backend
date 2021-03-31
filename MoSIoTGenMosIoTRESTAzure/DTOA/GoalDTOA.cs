using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class GoalDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum priority;
public MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum Priority
{
        get { return priority; }
        set { priority = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum Status
{
        get { return status; }
        set { status = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum category;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum Category
{
        get { return category; }
        set { category = value; }
}

private string outcomeCode;
public string OutcomeCode
{
        get { return outcomeCode; }
        set { outcomeCode = value; }
}


/* Rol: Goal o--> Target */
private IList<TargetDTOA> targets;
public IList<TargetDTOA> Targets
{
        get { return targets; }
        set { targets = value; }
}
}
}
