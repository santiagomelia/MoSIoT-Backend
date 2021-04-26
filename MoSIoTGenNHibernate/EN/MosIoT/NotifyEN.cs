
using System;
// Definición clase NotifyEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class NotifyEN                                                                       : MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN


{
/**
 *	Atributo users
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.UserEN> users;






public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.UserEN> Users {
        get { return users; } set { users = value;  }
}





public NotifyEN() : base ()
{
        users = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.UserEN>();
}



public NotifyEN(int id, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.UserEN> users
                , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> entityArgument, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN originState, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN targetState, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> triggers
                )
{
        this.init (Id, users, name, type, serviceType, description, entityArgument, entity, ruleAction, originState, targetState, triggers);
}


public NotifyEN(NotifyEN notify)
{
        this.init (Id, notify.Users, notify.Name, notify.Type, notify.ServiceType, notify.Description, notify.EntityArgument, notify.Entity, notify.RuleAction, notify.OriginState, notify.TargetState, notify.Triggers);
}

private void init (int id
                   , System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.UserEN> users, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> entityArgument, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN originState, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN targetState, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> triggers)
{
        this.Id = id;


        this.Users = users;

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
        NotifyEN t = obj as NotifyEN;
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
