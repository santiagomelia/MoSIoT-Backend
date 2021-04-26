
using System;
// Definición clase IMAdaptationTypeEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMAdaptationTypeEN                                                                     : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo adaptationTypeRequired
 */
private MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN adaptationTypeRequired;






public virtual MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN AdaptationTypeRequired {
        get { return adaptationTypeRequired; } set { adaptationTypeRequired = value;  }
}





public IMAdaptationTypeEN() : base ()
{
}



public IMAdaptationTypeEN(int id, MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN adaptationTypeRequired
                          , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                          )
{
        this.init (Id, adaptationTypeRequired, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMAdaptationTypeEN(IMAdaptationTypeEN iMAdaptationType)
{
        this.init (Id, iMAdaptationType.AdaptationTypeRequired, iMAdaptationType.Name, iMAdaptationType.Type, iMAdaptationType.IsOID, iMAdaptationType.TargetAssociation, iMAdaptationType.OriginAsociation, iMAdaptationType.AssociationType, iMAdaptationType.IsWritable, iMAdaptationType.Description, iMAdaptationType.Entity, iMAdaptationType.Trigger, iMAdaptationType.Register, iMAdaptationType.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN adaptationTypeRequired, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.AdaptationTypeRequired = adaptationTypeRequired;

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
        IMAdaptationTypeEN t = obj as IMAdaptationTypeEN;
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
