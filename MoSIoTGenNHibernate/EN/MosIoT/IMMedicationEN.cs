
using System;
// Definición clase IMMedicationEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMMedicationEN                                                                 : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo medication
 */
private MoSIoTGenNHibernate.EN.MosIoT.MedicationEN medication;






public virtual MoSIoTGenNHibernate.EN.MosIoT.MedicationEN Medication {
        get { return medication; } set { medication = value;  }
}





public IMMedicationEN() : base ()
{
}



public IMMedicationEN(int id, MoSIoTGenNHibernate.EN.MosIoT.MedicationEN medication
                      , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                      )
{
        this.init (Id, medication, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMMedicationEN(IMMedicationEN iMMedication)
{
        this.init (Id, iMMedication.Medication, iMMedication.Name, iMMedication.Type, iMMedication.IsOID, iMMedication.TargetAssociation, iMMedication.OriginAsociation, iMMedication.AssociationType, iMMedication.IsWritable, iMMedication.Description, iMMedication.Entity, iMMedication.Trigger, iMMedication.Register, iMMedication.Value);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.MedicationEN medication, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.Medication = medication;

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
        IMMedicationEN t = obj as IMMedicationEN;
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
