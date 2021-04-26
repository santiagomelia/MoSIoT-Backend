
using System;
// Definición clase IMAdaptationRequestEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMAdaptationRequestEN                                                                  : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo adaptationRequest
 */
private MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN adaptationRequest;






public virtual MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN AdaptationRequest {
        get { return adaptationRequest; } set { adaptationRequest = value;  }
}





public IMAdaptationRequestEN() : base ()
{
}



public IMAdaptationRequestEN(int id, MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN adaptationRequest
                             , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                             )
{
        this.init (Id, adaptationRequest, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMAdaptationRequestEN(IMAdaptationRequestEN iMAdaptationRequest)
{
        this.init (Id, iMAdaptationRequest.AdaptationRequest, iMAdaptationRequest.Name, iMAdaptationRequest.Type, iMAdaptationRequest.IsOID, iMAdaptationRequest.TargetAssociation, iMAdaptationRequest.OriginAsociation, iMAdaptationRequest.AssociationType, iMAdaptationRequest.IsWritable, iMAdaptationRequest.Description, iMAdaptationRequest.Entity, iMAdaptationRequest.Trigger, iMAdaptationRequest.Register, iMAdaptationRequest.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN adaptationRequest, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.AdaptationRequest = adaptationRequest;

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
        IMAdaptationRequestEN t = obj as IMAdaptationRequestEN;
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
