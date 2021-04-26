
using System;
// Definición clase CarePlanTemplateEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class CarePlanTemplateEN
{
/**
 *	Atributo careActivity
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN> careActivity;



/**
 *	Atributo patientProfile
 */
private MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile;



/**
 *	Atributo status
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status;



/**
 *	Atributo intent
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanIntentEnum intent;



/**
 *	Atributo title
 */
private string title;



/**
 *	Atributo modified
 */
private Nullable<DateTime> modified;



/**
 *	Atributo goals
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.GoalEN> goals;



/**
 *	Atributo addressConditions
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN> addressConditions;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo durationDays
 */
private int durationDays;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo comunication
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN> comunication;






public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN> CareActivity {
        get { return careActivity; } set { careActivity = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN PatientProfile {
        get { return patientProfile; } set { patientProfile = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum Status {
        get { return status; } set { status = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanIntentEnum Intent {
        get { return intent; } set { intent = value;  }
}



public virtual string Title {
        get { return title; } set { title = value;  }
}



public virtual Nullable<DateTime> Modified {
        get { return modified; } set { modified = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.GoalEN> Goals {
        get { return goals; } set { goals = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN> AddressConditions {
        get { return addressConditions; } set { addressConditions = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int DurationDays {
        get { return durationDays; } set { durationDays = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN> Comunication {
        get { return comunication; } set { comunication = value;  }
}





public CarePlanTemplateEN()
{
        careActivity = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN>();
        goals = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.GoalEN>();
        addressConditions = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN>();
        comunication = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN>();
}



public CarePlanTemplateEN(int id, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN> careActivity, MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile, MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status, MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanIntentEnum intent, string title, Nullable<DateTime> modified, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.GoalEN> goals, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN> addressConditions, int durationDays, string name, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN> comunication
                          )
{
        this.init (Id, careActivity, patientProfile, status, intent, title, modified, goals, addressConditions, durationDays, name, description, comunication);
}


public CarePlanTemplateEN(CarePlanTemplateEN carePlanTemplate)
{
        this.init (Id, carePlanTemplate.CareActivity, carePlanTemplate.PatientProfile, carePlanTemplate.Status, carePlanTemplate.Intent, carePlanTemplate.Title, carePlanTemplate.Modified, carePlanTemplate.Goals, carePlanTemplate.AddressConditions, carePlanTemplate.DurationDays, carePlanTemplate.Name, carePlanTemplate.Description, carePlanTemplate.Comunication);
}

private void init (int id
                   , System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN> careActivity, MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile, MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum status, MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanIntentEnum intent, string title, Nullable<DateTime> modified, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.GoalEN> goals, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN> addressConditions, int durationDays, string name, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN> comunication)
{
        this.Id = id;


        this.CareActivity = careActivity;

        this.PatientProfile = patientProfile;

        this.Status = status;

        this.Intent = intent;

        this.Title = title;

        this.Modified = modified;

        this.Goals = goals;

        this.AddressConditions = addressConditions;

        this.DurationDays = durationDays;

        this.Name = name;

        this.Description = description;

        this.Comunication = comunication;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CarePlanTemplateEN t = obj as CarePlanTemplateEN;
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
