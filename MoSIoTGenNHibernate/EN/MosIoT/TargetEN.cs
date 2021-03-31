
using System;
// Definición clase TargetEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class TargetEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo goal
 */
private MoSIoTGenNHibernate.EN.MosIoT.GoalEN goal;



/**
 *	Atributo desiredValue
 */
private string desiredValue;



/**
 *	Atributo measure
 */
private MoSIoTGenNHibernate.EN.MosIoT.MeasureEN measure;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo dueDate
 */
private Nullable<DateTime> dueDate;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.GoalEN Goal {
        get { return goal; } set { goal = value;  }
}



public virtual string DesiredValue {
        get { return desiredValue; } set { desiredValue = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.MeasureEN Measure {
        get { return measure; } set { measure = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual Nullable<DateTime> DueDate {
        get { return dueDate; } set { dueDate = value;  }
}





public TargetEN()
{
}



public TargetEN(int id, MoSIoTGenNHibernate.EN.MosIoT.GoalEN goal, string desiredValue, MoSIoTGenNHibernate.EN.MosIoT.MeasureEN measure, string description, Nullable<DateTime> dueDate
                )
{
        this.init (Id, goal, desiredValue, measure, description, dueDate);
}


public TargetEN(TargetEN target)
{
        this.init (Id, target.Goal, target.DesiredValue, target.Measure, target.Description, target.DueDate);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.GoalEN goal, string desiredValue, MoSIoTGenNHibernate.EN.MosIoT.MeasureEN measure, string description, Nullable<DateTime> dueDate)
{
        this.Id = id;


        this.Goal = goal;

        this.DesiredValue = desiredValue;

        this.Measure = measure;

        this.Description = description;

        this.DueDate = dueDate;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TargetEN t = obj as TargetEN;
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
