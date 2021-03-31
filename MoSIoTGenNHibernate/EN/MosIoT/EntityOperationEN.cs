
using System;
// Definición clase EntityOperationEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class EntityOperationEN
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
 *	Atributo type
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type;



/**
 *	Atributo serviceType
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo entityArgument
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> entityArgument;



/**
 *	Atributo entity
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity;



/**
 *	Atributo ruleAction
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> ruleAction;



/**
 *	Atributo originState
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN originState;



/**
 *	Atributo targetState
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN targetState;



/**
 *	Atributo triggers
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> triggers;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum ServiceType {
        get { return serviceType; } set { serviceType = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> EntityArgument {
        get { return entityArgument; } set { entityArgument = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityEN Entity {
        get { return entity; } set { entity = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> RuleAction {
        get { return ruleAction; } set { ruleAction = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN OriginState {
        get { return originState; } set { originState = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN TargetState {
        get { return targetState; } set { targetState = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> Triggers {
        get { return triggers; } set { triggers = value;  }
}





public EntityOperationEN()
{
        entityArgument = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN>();
        ruleAction = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN>();
        triggers = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN>();
}



public EntityOperationEN(int id, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> entityArgument, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN originState, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN targetState, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> triggers
                         )
{
        this.init (Id, name, type, serviceType, description, entityArgument, entity, ruleAction, originState, targetState, triggers);
}


public EntityOperationEN(EntityOperationEN entityOperation)
{
        this.init (Id, entityOperation.Name, entityOperation.Type, entityOperation.ServiceType, entityOperation.Description, entityOperation.EntityArgument, entityOperation.Entity, entityOperation.RuleAction, entityOperation.OriginState, entityOperation.TargetState, entityOperation.Triggers);
}

private void init (int id
                   , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> entityArgument, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN originState, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN targetState, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> triggers)
{
        this.Id = id;


        this.Name = name;

        this.Type = type;

        this.ServiceType = serviceType;

        this.Description = description;

        this.EntityArgument = entityArgument;

        this.Entity = entity;

        this.RuleAction = ruleAction;

        this.OriginState = originState;

        this.TargetState = targetState;

        this.Triggers = triggers;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EntityOperationEN t = obj as EntityOperationEN;
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
