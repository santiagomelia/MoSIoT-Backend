
using System;
// Definición clase DisabilityEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class DisabilityEN
{
/**
 *	Atributo patient
 */
private MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patient;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo type
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum type;



/**
 *	Atributo severity
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum severity;



/**
 *	Atributo origin
 */
private MoSIoTGenNHibernate.EN.MosIoT.ConditionEN origin;



/**
 *	Atributo accessMode
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN> accessMode;



/**
 *	Atributo description
 */
private string description;






public virtual MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN Patient {
        get { return patient; } set { patient = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum Severity {
        get { return severity; } set { severity = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.ConditionEN Origin {
        get { return origin; } set { origin = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN> AccessMode {
        get { return accessMode; } set { accessMode = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}





public DisabilityEN()
{
        accessMode = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN>();
}



public DisabilityEN(int id, MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patient, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum severity, MoSIoTGenNHibernate.EN.MosIoT.ConditionEN origin, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN> accessMode, string description
                    )
{
        this.init (Id, patient, name, type, severity, origin, accessMode, description);
}


public DisabilityEN(DisabilityEN disability)
{
        this.init (Id, disability.Patient, disability.Name, disability.Type, disability.Severity, disability.Origin, disability.AccessMode, disability.Description);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patient, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum severity, MoSIoTGenNHibernate.EN.MosIoT.ConditionEN origin, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN> accessMode, string description)
{
        this.Id = id;


        this.Patient = patient;

        this.Name = name;

        this.Type = type;

        this.Severity = severity;

        this.Origin = origin;

        this.AccessMode = accessMode;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DisabilityEN t = obj as DisabilityEN;
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
