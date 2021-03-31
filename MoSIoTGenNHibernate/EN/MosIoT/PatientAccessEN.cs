
using System;
// Definición clase PatientAccessEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class PatientAccessEN                                                                        : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo accessMode
 */
private MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode;






public virtual MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN AccessMode {
        get { return accessMode; } set { accessMode = value;  }
}





public PatientAccessEN() : base ()
{
}



public PatientAccessEN(int id, MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode
                       , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                       )
{
        this.init (Id, accessMode, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public PatientAccessEN(PatientAccessEN patientAccess)
{
        this.init (Id, patientAccess.AccessMode, patientAccess.Name, patientAccess.OriginAssociation, patientAccess.TargetAssociation, patientAccess.Scenario, patientAccess.Description, patientAccess.Operations, patientAccess.Attributes, patientAccess.States);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.AccessMode = accessMode;

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
        PatientAccessEN t = obj as PatientAccessEN;
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
