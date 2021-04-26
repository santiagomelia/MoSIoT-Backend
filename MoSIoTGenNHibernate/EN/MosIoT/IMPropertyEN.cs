
using System;
// Definición clase IMPropertyEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMPropertyEN                                                                   : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo property
 */
private MoSIoTGenNHibernate.EN.MosIoT.PropertyEN property;






public virtual MoSIoTGenNHibernate.EN.MosIoT.PropertyEN Property {
        get { return property; } set { property = value;  }
}





public IMPropertyEN() : base ()
{
}



public IMPropertyEN(int id, MoSIoTGenNHibernate.EN.MosIoT.PropertyEN property
                    , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                    )
{
        this.init (Id, property, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMPropertyEN(IMPropertyEN iMProperty)
{
        this.init (Id, iMProperty.Property, iMProperty.Name, iMProperty.Type, iMProperty.IsOID, iMProperty.TargetAssociation, iMProperty.OriginAsociation, iMProperty.AssociationType, iMProperty.IsWritable, iMProperty.Description, iMProperty.Entity, iMProperty.Trigger, iMProperty.Register, iMProperty.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.PropertyEN property, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.Property = property;

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
        IMPropertyEN t = obj as IMPropertyEN;
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
