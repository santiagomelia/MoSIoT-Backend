
using System;
// Definición clase IMCommandEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMCommandEN                                                                    : MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN


{
/**
 *	Atributo command
 */
private MoSIoTGenNHibernate.EN.MosIoT.CommandEN command;






public virtual MoSIoTGenNHibernate.EN.MosIoT.CommandEN Command {
        get { return command; } set { command = value;  }
}





public IMCommandEN() : base ()
{
}



public IMCommandEN(int id, MoSIoTGenNHibernate.EN.MosIoT.CommandEN command
                   , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> entityArgument, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN originState, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN targetState, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> triggers
                   )
{
        this.init (Id, command, name, type, serviceType, description, entityArgument, entity, ruleAction, originState, targetState, triggers);
}


public IMCommandEN(IMCommandEN iMCommand)
{
        this.init (Id, iMCommand.Command, iMCommand.Name, iMCommand.Type, iMCommand.ServiceType, iMCommand.Description, iMCommand.EntityArgument, iMCommand.Entity, iMCommand.RuleAction, iMCommand.OriginState, iMCommand.TargetState, iMCommand.Triggers);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.CommandEN command, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN> entityArgument, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN> ruleAction, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN originState, MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN targetState, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> triggers)
{
        this.Id = id;


        this.Command = command;

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
        IMCommandEN t = obj as IMCommandEN;
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
