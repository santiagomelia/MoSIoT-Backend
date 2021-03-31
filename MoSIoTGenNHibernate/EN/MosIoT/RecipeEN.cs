
using System;
// Definición clase RecipeEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RecipeEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo isEnabled
 */
private bool isEnabled;



/**
 *	Atributo triggers
 */
private MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN triggers;



/**
 *	Atributo recipeAction
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> recipeAction;



/**
 *	Atributo ioTScenario
 */
private MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ioTScenario;



/**
 *	Atributo intervalTime
 */
private double intervalTime;



/**
 *	Atributo description
 */
private string description;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual bool IsEnabled {
        get { return isEnabled; } set { isEnabled = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN Triggers {
        get { return triggers; } set { triggers = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> RecipeAction {
        get { return recipeAction; } set { recipeAction = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN IoTScenario {
        get { return ioTScenario; } set { ioTScenario = value;  }
}



public virtual double IntervalTime {
        get { return intervalTime; } set { intervalTime = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}





public RecipeEN()
{
        recipeAction = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN>();
}



public RecipeEN(int id, string name, bool isEnabled, MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN triggers, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> recipeAction, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ioTScenario, double intervalTime, string description
                )
{
        this.init (Id, name, isEnabled, triggers, recipeAction, ioTScenario, intervalTime, description);
}


public RecipeEN(RecipeEN recipe)
{
        this.init (Id, recipe.Name, recipe.IsEnabled, recipe.Triggers, recipe.RecipeAction, recipe.IoTScenario, recipe.IntervalTime, recipe.Description);
}

private void init (int id
                   , string name, bool isEnabled, MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN triggers, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> recipeAction, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ioTScenario, double intervalTime, string description)
{
        this.Id = id;


        this.Name = name;

        this.IsEnabled = isEnabled;

        this.Triggers = triggers;

        this.RecipeAction = recipeAction;

        this.IoTScenario = ioTScenario;

        this.IntervalTime = intervalTime;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RecipeEN t = obj as RecipeEN;
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
