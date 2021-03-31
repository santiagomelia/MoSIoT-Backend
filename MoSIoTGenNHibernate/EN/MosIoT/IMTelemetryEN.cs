
using System;
// Definición clase IMTelemetryEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMTelemetryEN                                                                  : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo telemetry
 */
private MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry;






public virtual MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN Telemetry {
        get { return telemetry; } set { telemetry = value;  }
}





public IMTelemetryEN() : base ()
{
}



public IMTelemetryEN(int id, MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry
                     , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                     )
{
        this.init (Id, telemetry, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public IMTelemetryEN(IMTelemetryEN iMTelemetry)
{
        this.init (Id, iMTelemetry.Telemetry, iMTelemetry.Name, iMTelemetry.OriginAssociation, iMTelemetry.TargetAssociation, iMTelemetry.Scenario, iMTelemetry.Description, iMTelemetry.Operations, iMTelemetry.Attributes, iMTelemetry.States);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.Telemetry = telemetry;

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
        IMTelemetryEN t = obj as IMTelemetryEN;
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
