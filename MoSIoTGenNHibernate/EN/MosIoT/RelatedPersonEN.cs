
using System;
// Definición clase RelatedPersonEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RelatedPersonEN                                                                        : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo userRelatedPerson
 */
private MoSIoTGenNHibernate.EN.MosIoT.UserEN userRelatedPerson;






public virtual MoSIoTGenNHibernate.EN.MosIoT.UserEN UserRelatedPerson {
        get { return userRelatedPerson; } set { userRelatedPerson = value;  }
}





public RelatedPersonEN() : base ()
{
}



public RelatedPersonEN(int id, MoSIoTGenNHibernate.EN.MosIoT.UserEN userRelatedPerson
                       , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                       )
{
        this.init (Id, userRelatedPerson, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public RelatedPersonEN(RelatedPersonEN relatedPerson)
{
        this.init (Id, relatedPerson.UserRelatedPerson, relatedPerson.Name, relatedPerson.OriginAssociation, relatedPerson.TargetAssociation, relatedPerson.Scenario, relatedPerson.Description, relatedPerson.Operations, relatedPerson.Attributes, relatedPerson.States);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.UserEN userRelatedPerson, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.UserRelatedPerson = userRelatedPerson;

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
        RelatedPersonEN t = obj as RelatedPersonEN;
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
