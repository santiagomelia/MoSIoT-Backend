
using System;
// Definición clase RuleEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RuleEN
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
 *	Atributo condition
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RuleConditionEN> condition;



/**
 *	Atributo ruleAction
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RuleActionEN> ruleAction;



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



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RuleConditionEN> Condition {
        get { return condition; } set { condition = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RuleActionEN> RuleAction {
        get { return ruleAction; } set { ruleAction = value;  }
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





public RuleEN()
{
        condition = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RuleConditionEN>();
        ruleAction = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RuleActionEN>();
}



public RuleEN(int id, string name, bool isEnabled, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RuleConditionEN> condition, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RuleActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ioTScenario, double intervalTime, string description
              )
{
        this.init (Id, name, isEnabled, condition, ruleAction, ioTScenario, intervalTime, description);
}


public RuleEN(RuleEN rule)
{
        this.init (Id, rule.Name, rule.IsEnabled, rule.Condition, rule.RuleAction, rule.IoTScenario, rule.IntervalTime, rule.Description);
}

private void init (int id
                   , string name, bool isEnabled, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RuleConditionEN> condition, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RuleActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ioTScenario, double intervalTime, string description)
{
        this.Id = id;


        this.Name = name;

        this.IsEnabled = isEnabled;

        this.Condition = condition;

        this.RuleAction = ruleAction;

        this.IoTScenario = ioTScenario;

        this.IntervalTime = intervalTime;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RuleEN t = obj as RuleEN;
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
