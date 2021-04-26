
using System;
// Definición clase PatientProfileEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class PatientProfileEN
{
/**
 *	Atributo accessMode
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN> accessMode;



/**
 *	Atributo preferredLanguage
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum preferredLanguage;



/**
 *	Atributo region
 */
private string region;



/**
 *	Atributo hazardAvoidance
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum hazardAvoidance;



/**
 *	Atributo disability
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN> disability;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo diseases
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN> diseases;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo description
 */
private string description;






public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN> AccessMode {
        get { return accessMode; } set { accessMode = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum PreferredLanguage {
        get { return preferredLanguage; } set { preferredLanguage = value;  }
}



public virtual string Region {
        get { return region; } set { region = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum HazardAvoidance {
        get { return hazardAvoidance; } set { hazardAvoidance = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN> Disability {
        get { return disability; } set { disability = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN> Diseases {
        get { return diseases; } set { diseases = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}





public PatientProfileEN()
{
        accessMode = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN>();
        disability = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN>();
        diseases = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN>();
}



public PatientProfileEN(int id, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN> accessMode, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum preferredLanguage, string region, MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum hazardAvoidance, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN> disability, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN> diseases, string name, string description
                        )
{
        this.init (Id, accessMode, preferredLanguage, region, hazardAvoidance, disability, diseases, name, description);
}


public PatientProfileEN(PatientProfileEN patientProfile)
{
        this.init (Id, patientProfile.AccessMode, patientProfile.PreferredLanguage, patientProfile.Region, patientProfile.HazardAvoidance, patientProfile.Disability, patientProfile.Diseases, patientProfile.Name, patientProfile.Description);
}

private void init (int id
                   , System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN> accessMode, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum preferredLanguage, string region, MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum hazardAvoidance, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN> disability, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN> diseases, string name, string description)
{
        this.Id = id;


        this.AccessMode = accessMode;

        this.PreferredLanguage = preferredLanguage;

        this.Region = region;

        this.HazardAvoidance = hazardAvoidance;

        this.Disability = disability;

        this.Diseases = diseases;

        this.Name = name;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PatientProfileEN t = obj as PatientProfileEN;
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
