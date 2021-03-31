
using System;
// Definición clase RuleConditionEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RuleConditionEN
{
/**
 *	Atributo rule
 */
private MoSIoTGenNHibernate.EN.MosIoT.RuleEN rule;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo operator_
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum operator_;



/**
 *	Atributo value
 */
private string value;



/**
 *	Atributo entityAttributes
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> entityAttributes;






public virtual MoSIoTGenNHibernate.EN.MosIoT.RuleEN Rule {
        get { return rule; } set { rule = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum Operator_ {
        get { return operator_; } set { operator_ = value;  }
}



public virtual string Value {
        get { return value; } set { value = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> EntityAttributes {
        get { return entityAttributes; } set { entityAttributes = value;  }
}





public RuleConditionEN()
{
        entityAttributes = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN>();
}



public RuleConditionEN(int id, MoSIoTGenNHibernate.EN.MosIoT.RuleEN rule, MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum operator_, string value, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> entityAttributes
                       )
{
        this.init (Id, rule, operator_, value, entityAttributes);
}


public RuleConditionEN(RuleConditionEN ruleCondition)
{
        this.init (Id, ruleCondition.Rule, ruleCondition.Operator_, ruleCondition.Value, ruleCondition.EntityAttributes);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.RuleEN rule, MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum operator_, string value, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> entityAttributes)
{
        this.Id = id;


        this.Rule = rule;

        this.Operator_ = operator_;

        this.Value = value;

        this.EntityAttributes = entityAttributes;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RuleConditionEN t = obj as RuleConditionEN;
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
