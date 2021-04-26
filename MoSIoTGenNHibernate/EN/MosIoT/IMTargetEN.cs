
using System;
// Definición clase IMTargetEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMTargetEN                                                                     : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo target
 */
private MoSIoTGenNHibernate.EN.MosIoT.TargetEN target;






public virtual MoSIoTGenNHibernate.EN.MosIoT.TargetEN Target {
        get { return target; } set { target = value;  }
}





public IMTargetEN() : base ()
{
}



public IMTargetEN(int id, MoSIoTGenNHibernate.EN.MosIoT.TargetEN target
                  , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                  )
{
        this.init (Id, target, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMTargetEN(IMTargetEN iMTarget)
{
        this.init (Id, iMTarget.Target, iMTarget.Name, iMTarget.Type, iMTarget.IsOID, iMTarget.TargetAssociation, iMTarget.OriginAsociation, iMTarget.AssociationType, iMTarget.IsWritable, iMTarget.Description, iMTarget.Entity, iMTarget.Trigger, iMTarget.Register, iMTarget.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.TargetEN target, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.Target = target;

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
        IMTargetEN t = obj as IMTargetEN;
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
