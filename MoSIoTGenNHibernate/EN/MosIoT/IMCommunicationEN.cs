
using System;
// Definición clase IMCommunicationEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMCommunicationEN                                                                      : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo comunication
 */
private MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN comunication;






public virtual MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN Comunication {
        get { return comunication; } set { comunication = value;  }
}





public IMCommunicationEN() : base ()
{
}



public IMCommunicationEN(int id, MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN comunication
                         , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                         )
{
        this.init (Id, comunication, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMCommunicationEN(IMCommunicationEN iMCommunication)
{
        this.init (Id, iMCommunication.Comunication, iMCommunication.Name, iMCommunication.Type, iMCommunication.IsOID, iMCommunication.TargetAssociation, iMCommunication.OriginAsociation, iMCommunication.AssociationType, iMCommunication.IsWritable, iMCommunication.Description, iMCommunication.Entity, iMCommunication.Trigger, iMCommunication.Register, iMCommunication.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN comunication, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.Comunication = comunication;

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
        IMCommunicationEN t = obj as IMCommunicationEN;
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
