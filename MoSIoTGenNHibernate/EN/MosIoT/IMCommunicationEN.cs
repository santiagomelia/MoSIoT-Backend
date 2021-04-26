
using System;
// Definición clase IMCommunicationEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMCommunicationEN                                                                      : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo comunication
 */
private MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN comunication;






public virtual MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN Comunication {
        get { return comunication; } set { comunication = value;  }
}





public IMCommunicationEN() : base ()
{
}



public IMCommunicationEN(int id, MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN comunication
                         , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                         )
{
        this.init (Id, comunication, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public IMCommunicationEN(IMCommunicationEN iMCommunication)
{
        this.init (Id, iMCommunication.Comunication, iMCommunication.Name, iMCommunication.OriginAssociation, iMCommunication.TargetAssociation, iMCommunication.Scenario, iMCommunication.Description, iMCommunication.Operations, iMCommunication.Attributes, iMCommunication.States);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN comunication, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.Comunication = comunication;

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
        IMCommunicationEN t = obj as IMCommunicationEN;
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
