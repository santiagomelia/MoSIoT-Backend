
using System;
// Definición clase CareActivityEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class CareActivityEN
{
/**
 *	Atributo carePlanTemplate
 */
private MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplate;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo periodicity
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum periodicity;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo duration
 */
private int duration;



/**
 *	Atributo medication
 */
private MoSIoTGenNHibernate.EN.MosIoT.MedicationEN medication;



/**
 *	Atributo location
 */
private string location;



/**
 *	Atributo outcomeCode
 */
private string outcomeCode;



/**
 *	Atributo nutritionOrder
 */
private MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN nutritionOrder;



/**
 *	Atributo typeActivity
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum typeActivity;



/**
 *	Atributo notification
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN> notification;



/**
 *	Atributo activityCode https://www.hl7.org/fhir/valueset-procedure-code.html
 */
private string activityCode;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo appointment
 */
private MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN appointment;






public virtual MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN CarePlanTemplate {
        get { return carePlanTemplate; } set { carePlanTemplate = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum Periodicity {
        get { return periodicity; } set { periodicity = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual int Duration {
        get { return duration; } set { duration = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.MedicationEN Medication {
        get { return medication; } set { medication = value;  }
}



public virtual string Location {
        get { return location; } set { location = value;  }
}



public virtual string OutcomeCode {
        get { return outcomeCode; } set { outcomeCode = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN NutritionOrder {
        get { return nutritionOrder; } set { nutritionOrder = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum TypeActivity {
        get { return typeActivity; } set { typeActivity = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN> Notification {
        get { return notification; } set { notification = value;  }
}



public virtual string ActivityCode {
        get { return activityCode; } set { activityCode = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN Appointment {
        get { return appointment; } set { appointment = value;  }
}





public CareActivityEN()
{
        notification = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN>();
}



public CareActivityEN(int id, MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplate, MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum periodicity, string description, int duration, MoSIoTGenNHibernate.EN.MosIoT.MedicationEN medication, string location, string outcomeCode, MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN nutritionOrder, MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum typeActivity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN> notification, string activityCode, string name, MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN appointment
                      )
{
        this.init (Id, carePlanTemplate, periodicity, description, duration, medication, location, outcomeCode, nutritionOrder, typeActivity, notification, activityCode, name, appointment);
}


public CareActivityEN(CareActivityEN careActivity)
{
        this.init (Id, careActivity.CarePlanTemplate, careActivity.Periodicity, careActivity.Description, careActivity.Duration, careActivity.Medication, careActivity.Location, careActivity.OutcomeCode, careActivity.NutritionOrder, careActivity.TypeActivity, careActivity.Notification, careActivity.ActivityCode, careActivity.Name, careActivity.Appointment);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplate, MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum periodicity, string description, int duration, MoSIoTGenNHibernate.EN.MosIoT.MedicationEN medication, string location, string outcomeCode, MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN nutritionOrder, MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum typeActivity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN> notification, string activityCode, string name, MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN appointment)
{
        this.Id = id;


        this.CarePlanTemplate = carePlanTemplate;

        this.Periodicity = periodicity;

        this.Description = description;

        this.Duration = duration;

        this.Medication = medication;

        this.Location = location;

        this.OutcomeCode = outcomeCode;

        this.NutritionOrder = nutritionOrder;

        this.TypeActivity = typeActivity;

        this.Notification = notification;

        this.ActivityCode = activityCode;

        this.Name = name;

        this.Appointment = appointment;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CareActivityEN t = obj as CareActivityEN;
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
