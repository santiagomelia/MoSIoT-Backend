
using System;
// Definición clase PatientEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class PatientEN                                                                      : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo patientProfile
 */
private MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile;



/**
 *	Atributo userPatient
 */
private MoSIoTGenNHibernate.EN.MosIoT.UserEN userPatient;






public virtual MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN PatientProfile {
        get { return patientProfile; } set { patientProfile = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.UserEN UserPatient {
        get { return userPatient; } set { userPatient = value;  }
}





public PatientEN() : base ()
{
}



public PatientEN(int id, MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile, MoSIoTGenNHibernate.EN.MosIoT.UserEN userPatient
                 , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                 )
{
        this.init (Id, patientProfile, userPatient, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public PatientEN(PatientEN patient)
{
        this.init (Id, patient.PatientProfile, patient.UserPatient, patient.Name, patient.OriginAssociation, patient.TargetAssociation, patient.Scenario, patient.Description, patient.Operations, patient.Attributes, patient.States);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile, MoSIoTGenNHibernate.EN.MosIoT.UserEN userPatient, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.PatientProfile = patientProfile;

        this.UserPatient = userPatient;

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
        PatientEN t = obj as PatientEN;
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
