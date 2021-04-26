
using System;
// Definición clase IMGoalEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMGoalEN                                                                       : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo goal
 */
private MoSIoTGenNHibernate.EN.MosIoT.GoalEN goal;






public virtual MoSIoTGenNHibernate.EN.MosIoT.GoalEN Goal {
        get { return goal; } set { goal = value;  }
}





public IMGoalEN() : base ()
{
}



public IMGoalEN(int id, MoSIoTGenNHibernate.EN.MosIoT.GoalEN goal
                , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                )
{
        this.init (Id, goal, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMGoalEN(IMGoalEN iMGoal)
{
        this.init (Id, iMGoal.Goal, iMGoal.Name, iMGoal.Type, iMGoal.IsOID, iMGoal.TargetAssociation, iMGoal.OriginAsociation, iMGoal.AssociationType, iMGoal.IsWritable, iMGoal.Description, iMGoal.Entity, iMGoal.Trigger, iMGoal.Register, iMGoal.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.GoalEN goal, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.Goal = goal;

        this.Name = name;

        this.Type = type;

        this.IsOID = isOID;

        this.TargetAssociation = targetAssociation;

        this.OriginAsociation = originAsociation;

        this.AssociationType = associationType;

        this.IsWritable = isWritable;

        this.Description = description;

        this.Entity = entity;

        this.Trigger = trigger;

        this.Register = register;

        this.Value = value;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IMGoalEN t = obj as IMGoalEN;
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
