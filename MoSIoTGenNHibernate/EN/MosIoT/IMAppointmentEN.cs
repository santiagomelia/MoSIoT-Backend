
using System;
// Definición clase IMAppointmentEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMAppointmentEN                                                                        : MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN


{
/**
 *	Atributo date
 */
private Nullable<DateTime> date;



/**
 *	Atributo appointment
 */
private MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN appointment;






public virtual Nullable<DateTime> Date {
        get { return date; } set { date = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN Appointment {
        get { return appointment; } set { appointment = value;  }
}





public IMAppointmentEN() : base ()
{
}



public IMAppointmentEN(int id, Nullable<DateTime> date, MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN appointment
                       , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                       )
{
        this.init (Id, date, appointment, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public IMAppointmentEN(IMAppointmentEN iMAppointment)
{
        this.init (Id, iMAppointment.Date, iMAppointment.Appointment, iMAppointment.Name, iMAppointment.Type, iMAppointment.IsOID, iMAppointment.TargetAssociation, iMAppointment.OriginAsociation, iMAppointment.AssociationType, iMAppointment.IsWritable, iMAppointment.Description, iMAppointment.Entity, iMAppointment.Trigger, iMAppointment.Register, iMAppointment.Value);
}

private void init (int id
                   , Nullable<DateTime> date, MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN appointment, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.Date = date;

        this.Appointment = appointment;

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
        IMAppointmentEN t = obj as IMAppointmentEN;
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
