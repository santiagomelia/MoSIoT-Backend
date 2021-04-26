
using System;
// Definición clase IMConditionEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMConditionEN                                                                  : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo condition
 */
private MoSIoTGenNHibernate.EN.MosIoT.ConditionEN condition;






public virtual MoSIoTGenNHibernate.EN.MosIoT.ConditionEN Condition {
        get { return condition; } set { condition = value;  }
}





public IMConditionEN() : base ()
{
}



public IMConditionEN(int id, MoSIoTGenNHibernate.EN.MosIoT.ConditionEN condition
                     , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                     )
{
        this.init (Id, condition, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMConditionEN(IMConditionEN iMCondition)
{
        this.init (Id, iMCondition.Condition, iMCondition.Name, iMCondition.Type, iMCondition.IsOID, iMCondition.TargetAssociation, iMCondition.OriginAsociation, iMCondition.AssociationType, iMCondition.IsWritable, iMCondition.Description, iMCondition.Entity, iMCondition.Trigger, iMCondition.Register, iMCondition.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.ConditionEN condition, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.Condition = condition;

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
        IMConditionEN t = obj as IMConditionEN;
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
