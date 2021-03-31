
using System;
// Definición clase ConditionEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class ConditionEN
{
/**
 *	Atributo patientProfile
 */
private MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo dateInitial
 */
private Nullable<DateTime> dateInitial;



/**
 *	Atributo dateEnd
 */
private Nullable<DateTime> dateEnd;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo disabilities
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN> disabilities;



/**
 *	Atributo clinicalStatus
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum clinicalStatus;



/**
 *	Atributo disease
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum disease;



/**
 *	Atributo carePlan
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN> carePlan;



/**
 *	Atributo goal
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.GoalEN> goal;



/**
 *	Atributo name
 */
private string name;






public virtual MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN PatientProfile {
        get { return patientProfile; } set { patientProfile = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> DateInitial {
        get { return dateInitial; } set { dateInitial = value;  }
}



public virtual Nullable<DateTime> DateEnd {
        get { return dateEnd; } set { dateEnd = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN> Disabilities {
        get { return disabilities; } set { disabilities = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum ClinicalStatus {
        get { return clinicalStatus; } set { clinicalStatus = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum Disease {
        get { return disease; } set { disease = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN> CarePlan {
        get { return carePlan; } set { carePlan = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.GoalEN> Goal {
        get { return goal; } set { goal = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}





public ConditionEN()
{
        disabilities = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN>();
        carePlan = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN>();
        goal = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.GoalEN>();
}



public ConditionEN(int id, MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile, Nullable<DateTime> dateInitial, Nullable<DateTime> dateEnd, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN> disabilities, MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum clinicalStatus, MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum disease, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN> carePlan, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.GoalEN> goal, string name
                   )
{
        this.init (Id, patientProfile, dateInitial, dateEnd, description, disabilities, clinicalStatus, disease, carePlan, goal, name);
}


public ConditionEN(ConditionEN condition)
{
        this.init (Id, condition.PatientProfile, condition.DateInitial, condition.DateEnd, condition.Description, condition.Disabilities, condition.ClinicalStatus, condition.Disease, condition.CarePlan, condition.Goal, condition.Name);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile, Nullable<DateTime> dateInitial, Nullable<DateTime> dateEnd, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN> disabilities, MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum clinicalStatus, MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum disease, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN> carePlan, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.GoalEN> goal, string name)
{
        this.Id = id;


        this.PatientProfile = patientProfile;

        this.DateInitial = dateInitial;

        this.DateEnd = dateEnd;

        this.Description = description;

        this.Disabilities = disabilities;

        this.ClinicalStatus = clinicalStatus;

        this.Disease = disease;

        this.CarePlan = carePlan;

        this.Goal = goal;

        this.Name = name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ConditionEN t = obj as ConditionEN;
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
