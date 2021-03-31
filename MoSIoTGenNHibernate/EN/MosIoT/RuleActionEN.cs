
using System;
// Definición clase RuleActionEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RuleActionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo rule
 */
private MoSIoTGenNHibernate.EN.MosIoT.RuleEN rule;



/**
 *	Atributo operation
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN operation;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.RuleEN Rule {
        get { return rule; } set { rule = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN Operation {
        get { return operation; } set { operation = value;  }
}





public RuleActionEN()
{
}



public RuleActionEN(int id, MoSIoTGenNHibernate.EN.MosIoT.RuleEN rule, MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN operation
                    )
{
        this.init (Id, rule, operation);
}


public RuleActionEN(RuleActionEN ruleAction)
{
        this.init (Id, ruleAction.Rule, ruleAction.Operation);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.RuleEN rule, MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN operation)
{
        this.Id = id;


        this.Rule = rule;

        this.Operation = operation;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RuleActionEN t = obj as RuleActionEN;
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
