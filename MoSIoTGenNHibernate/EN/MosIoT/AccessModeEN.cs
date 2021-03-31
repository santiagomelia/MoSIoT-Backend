
using System;
// Definición clase AccessModeEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class AccessModeEN
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
 *	Atributo typeAccessMode
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum typeAccessMode;



/**
 *	Atributo adaptationDetailRequired
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN> adaptationDetailRequired;



/**
 *	Atributo deviceTemplate
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN> deviceTemplate;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo adaptationTypeRequired
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN> adaptationTypeRequired;



/**
 *	Atributo adaptationRequest
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN> adaptationRequest;



/**
 *	Atributo disability
 */
private MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN disability;



/**
 *	Atributo name
 */
private string name;






public virtual MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN Patient {
        get { return patient; } set { patient = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum TypeAccessMode {
        get { return typeAccessMode; } set { typeAccessMode = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN> AdaptationDetailRequired {
        get { return adaptationDetailRequired; } set { adaptationDetailRequired = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN> DeviceTemplate {
        get { return deviceTemplate; } set { deviceTemplate = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN> AdaptationTypeRequired {
        get { return adaptationTypeRequired; } set { adaptationTypeRequired = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN> AdaptationRequest {
        get { return adaptationRequest; } set { adaptationRequest = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN Disability {
        get { return disability; } set { disability = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}





public AccessModeEN()
{
        adaptationDetailRequired = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN>();
        deviceTemplate = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN>();
        adaptationTypeRequired = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN>();
        adaptationRequest = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN>();
}



public AccessModeEN(int id, MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patient, MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum typeAccessMode, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN> adaptationDetailRequired, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN> deviceTemplate, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN> adaptationTypeRequired, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN> adaptationRequest, MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN disability, string name
                    )
{
        this.init (Id, patient, typeAccessMode, adaptationDetailRequired, deviceTemplate, description, adaptationTypeRequired, adaptationRequest, disability, name);
}


public AccessModeEN(AccessModeEN accessMode)
{
        this.init (Id, accessMode.Patient, accessMode.TypeAccessMode, accessMode.AdaptationDetailRequired, accessMode.DeviceTemplate, accessMode.Description, accessMode.AdaptationTypeRequired, accessMode.AdaptationRequest, accessMode.Disability, accessMode.Name);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patient, MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum typeAccessMode, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN> adaptationDetailRequired, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN> deviceTemplate, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN> adaptationTypeRequired, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN> adaptationRequest, MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN disability, string name)
{
        this.Id = id;


        this.Patient = patient;

        this.TypeAccessMode = typeAccessMode;

        this.AdaptationDetailRequired = adaptationDetailRequired;

        this.DeviceTemplate = deviceTemplate;

        this.Description = description;

        this.AdaptationTypeRequired = adaptationTypeRequired;

        this.AdaptationRequest = adaptationRequest;

        this.Disability = disability;

        this.Name = name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AccessModeEN t = obj as AccessModeEN;
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
