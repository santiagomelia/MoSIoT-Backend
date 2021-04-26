
using System;
// Definición clase IMAppointmentEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMAppointmentEN                                                                        : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


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
                       , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                       )
{
        this.init (Id, date, appointment, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public IMAppointmentEN(IMAppointmentEN iMAppointment)
{
        this.init (Id, iMAppointment.Date, iMAppointment.Appointment, iMAppointment.Name, iMAppointment.OriginAssociation, iMAppointment.TargetAssociation, iMAppointment.Scenario, iMAppointment.Description, iMAppointment.Operations, iMAppointment.Attributes, iMAppointment.States);
}

private void init (int id
                   , Nullable<DateTime> date, MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN appointment, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.Date = date;

        this.Appointment = appointment;

        this.Name = name;

        this.OriginAssociation = originAssociation;

        this.TargetAssociation = targetAssociation;

        this.Scenario = scenario;

        this.Description = description;

        this.Operations = operations;

        this.Attributes = attributes;

        this.States = states;
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
