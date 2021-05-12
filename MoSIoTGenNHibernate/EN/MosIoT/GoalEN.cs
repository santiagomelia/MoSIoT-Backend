
using System;
// Definición clase GoalEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class GoalEN
{
/**
 *	Atributo carePlanTemplate
 */
private MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplate;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo priority
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum priority;



/**
 *	Atributo targets
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TargetEN> targets;



/**
 *	Atributo status
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status;



/**
 *	Atributo condition
 */
private MoSIoTGenNHibernate.EN.MosIoT.ConditionEN condition;



/**
 *	Atributo description Es un Codeable concept.
 */
private string description;



/**
 *	Atributo category
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum category;



/**
 *	Atributo outcomeCode
 */
private string outcomeCode;



/**
 *	Atributo name
 */
private string name;






public virtual MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN CarePlanTemplate {
        get { return carePlanTemplate; } set { carePlanTemplate = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum Priority {
        get { return priority; } set { priority = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TargetEN> Targets {
        get { return targets; } set { targets = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum Status {
        get { return status; } set { status = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.ConditionEN Condition {
        get { return condition; } set { condition = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum Category {
        get { return category; } set { category = value;  }
}



public virtual string OutcomeCode {
        get { return outcomeCode; } set { outcomeCode = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}





public GoalEN()
{
        targets = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TargetEN>();
}



public GoalEN(int id, MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplate, MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum priority, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TargetEN> targets, MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status, MoSIoTGenNHibernate.EN.MosIoT.ConditionEN condition, string description, MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum category, string outcomeCode, string name
              )
{
        this.init (Id, carePlanTemplate, priority, targets, status, condition, description, category, outcomeCode, name);
}


public GoalEN(GoalEN goal)
{
        this.init (Id, goal.CarePlanTemplate, goal.Priority, goal.Targets, goal.Status, goal.Condition, goal.Description, goal.Category, goal.OutcomeCode, goal.Name);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplate, MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum priority, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TargetEN> targets, MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status, MoSIoTGenNHibernate.EN.MosIoT.ConditionEN condition, string description, MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum category, string outcomeCode, string name)
{
        this.Id = id;


        this.CarePlanTemplate = carePlanTemplate;

        this.Priority = priority;

        this.Targets = targets;

        this.Status = status;

        this.Condition = condition;

        this.Description = description;

        this.Category = category;

        this.OutcomeCode = outcomeCode;

        this.Name = name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        GoalEN t = obj as GoalEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
