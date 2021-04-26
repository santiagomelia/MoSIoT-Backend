
using System;
// Definición clase IMCareActivityEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMCareActivityEN                                                                       : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo careActivity
 */
private MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity;






public virtual MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN CareActivity {
        get { return careActivity; } set { careActivity = value;  }
}





public IMCareActivityEN() : base ()
{
}



public IMCareActivityEN(int id, MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity
                        , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                        )
{
        this.init (Id, careActivity, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public IMCareActivityEN(IMCareActivityEN iMCareActivity)
{
        this.init (Id, iMCareActivity.CareActivity, iMCareActivity.Name, iMCareActivity.OriginAssociation, iMCareActivity.TargetAssociation, iMCareActivity.Scenario, iMCareActivity.Description, iMCareActivity.Operations, iMCareActivity.Attributes, iMCareActivity.States);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.CareActivity = careActivity;

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
        IMCareActivityEN t = obj as IMCareActivityEN;
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
