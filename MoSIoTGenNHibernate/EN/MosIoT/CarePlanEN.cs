
using System;
// Definición clase CarePlanEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class CarePlanEN                                                                     : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo template
 */
private MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN template;






public virtual MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN Template {
        get { return template; } set { template = value;  }
}





public CarePlanEN() : base ()
{
}



public CarePlanEN(int id, MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN template
                  , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                  )
{
        this.init (Id, template, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public CarePlanEN(CarePlanEN carePlan)
{
        this.init (Id, carePlan.Template, carePlan.Name, carePlan.OriginAssociation, carePlan.TargetAssociation, carePlan.Scenario, carePlan.Description, carePlan.Operations, carePlan.Attributes, carePlan.States);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN template, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.Template = template;

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
        CarePlanEN t = obj as CarePlanEN;
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
