
using System;
// Definición clase RegisterEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RegisterEN                                                                     : MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN


{
/**
 *	Atributo entityAttributes
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN entityAttributes;






public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN EntityAttributes {
        get { return entityAttributes; } set { entityAttributes = value;  }
}





public RegisterEN() : base ()
{
}



public RegisterEN(int id, MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN entityAttributes
                  , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> entityArgument, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN originState, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN targetState, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> triggers
                  )
{
        this.init (Id, entityAttributes, name, type, serviceType, description, entityArgument, entity, ruleAction, originState, targetState, triggers);
}


public RegisterEN(RegisterEN register)
{
        this.init (Id, register.EntityAttributes, register.Name, register.Type, register.ServiceType, register.Description, register.EntityArgument, register.Entity, register.RuleAction, register.OriginState, register.TargetState, register.Triggers);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN entityAttributes, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> entityArgument, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN originState, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN targetState, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> triggers)
{
        this.Id = id;


        this.EntityAttributes = entityAttributes;

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
        RegisterEN t = obj as RegisterEN;
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
