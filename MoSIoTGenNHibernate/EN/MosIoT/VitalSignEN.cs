
using System;
// Definición clase VitalSignEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class VitalSignEN                                                                    : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo measure
 */
private MoSIoTGenNHibernate.EN.MosIoT.MeasureEN measure;






public virtual MoSIoTGenNHibernate.EN.MosIoT.MeasureEN Measure {
        get { return measure; } set { measure = value;  }
}





public VitalSignEN() : base ()
{
}



public VitalSignEN(int id, MoSIoTGenNHibernate.EN.MosIoT.MeasureEN measure
                   , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                   )
{
        this.init (Id, measure, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public VitalSignEN(VitalSignEN vitalSign)
{
        this.init (Id, vitalSign.Measure, vitalSign.Name, vitalSign.OriginAssociation, vitalSign.TargetAssociation, vitalSign.Scenario, vitalSign.Description, vitalSign.Operations, vitalSign.Attributes, vitalSign.States);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.MeasureEN measure, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.Measure = measure;

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
        VitalSignEN t = obj as VitalSignEN;
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
