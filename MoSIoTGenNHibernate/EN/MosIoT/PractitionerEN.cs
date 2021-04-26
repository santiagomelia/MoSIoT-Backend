
using System;
// Definición clase PractitionerEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class PractitionerEN                                                                 : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo userPractitioner
 */
private MoSIoTGenNHibernate.EN.MosIoT.UserEN userPractitioner;






public virtual MoSIoTGenNHibernate.EN.MosIoT.UserEN UserPractitioner {
        get { return userPractitioner; } set { userPractitioner = value;  }
}





public PractitionerEN() : base ()
{
}



public PractitionerEN(int id, MoSIoTGenNHibernate.EN.MosIoT.UserEN userPractitioner
                      , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                      )
{
        this.init (Id, userPractitioner, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public PractitionerEN(PractitionerEN practitioner)
{
        this.init (Id, practitioner.UserPractitioner, practitioner.Name, practitioner.OriginAssociation, practitioner.TargetAssociation, practitioner.Scenario, practitioner.Description, practitioner.Operations, practitioner.Attributes, practitioner.States);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.UserEN userPractitioner, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.UserPractitioner = userPractitioner;

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
        PractitionerEN t = obj as PractitionerEN;
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
