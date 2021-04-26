
using System;
// Definición clase IMAdaptationDetailEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMAdaptationDetailEN                                                                   : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo adaptationDetailRequired
 */
private MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN adaptationDetailRequired;






public virtual MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN AdaptationDetailRequired {
        get { return adaptationDetailRequired; } set { adaptationDetailRequired = value;  }
}





public IMAdaptationDetailEN() : base ()
{
}



public IMAdaptationDetailEN(int id, MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN adaptationDetailRequired
                            , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                            )
{
        this.init (Id, adaptationDetailRequired, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMAdaptationDetailEN(IMAdaptationDetailEN iMAdaptationDetail)
{
        this.init (Id, iMAdaptationDetail.AdaptationDetailRequired, iMAdaptationDetail.Name, iMAdaptationDetail.Type, iMAdaptationDetail.IsOID, iMAdaptationDetail.TargetAssociation, iMAdaptationDetail.OriginAsociation, iMAdaptationDetail.AssociationType, iMAdaptationDetail.IsWritable, iMAdaptationDetail.Description, iMAdaptationDetail.Entity, iMAdaptationDetail.Trigger, iMAdaptationDetail.Register, iMAdaptationDetail.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN adaptationDetailRequired, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.AdaptationDetailRequired = adaptationDetailRequired;

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
        IMAdaptationDetailEN t = obj as IMAdaptationDetailEN;
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
