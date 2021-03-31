
using System;
// Definición clase AppointmentEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class AppointmentEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo isVirtual
 */
private bool isVirtual;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo direction
 */
private string direction;



/**
 *	Atributo reasonCode https://www.hl7.org/fhir/valueset-encounter-reason.html
 */
private string reasonCode;



/**
 *	Atributo careActivity
 */
private MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual bool IsVirtual {
        get { return isVirtual; } set { isVirtual = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual string Direction {
        get { return direction; } set { direction = value;  }
}



public virtual string ReasonCode {
        get { return reasonCode; } set { reasonCode = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN CareActivity {
        get { return careActivity; } set { careActivity = value;  }
}





public AppointmentEN()
{
}



public AppointmentEN(int id, bool isVirtual, string description, string direction, string reasonCode, MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity
                     )
{
        this.init (Id, isVirtual, description, direction, reasonCode, careActivity);
}


public AppointmentEN(AppointmentEN appointment)
{
        this.init (Id, appointment.IsVirtual, appointment.Description, appointment.Direction, appointment.ReasonCode, appointment.CareActivity);
}

private void init (int id
                   , bool isVirtual, string description, string direction, string reasonCode, MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity)
{
        this.Id = id;


        this.IsVirtual = isVirtual;

        this.Description = description;

        this.Direction = direction;

        this.ReasonCode = reasonCode;

        this.CareActivity = careActivity;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AppointmentEN t = obj as AppointmentEN;
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
