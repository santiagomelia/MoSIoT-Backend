
using System;
// Definición clase StateTelemetryEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class StateTelemetryEN                                                                       : MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN


{
/**
 *	Atributo rangeStates
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.StateDeviceEN> rangeStates;






public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.StateDeviceEN> RangeStates {
        get { return rangeStates; } set { rangeStates = value;  }
}





public StateTelemetryEN() : base ()
{
        rangeStates = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.StateDeviceEN>();
}



public StateTelemetryEN(int id, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.StateDeviceEN> rangeStates
                        , MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name
                        )
{
        this.init (Id, rangeStates, telemetry, name);
}


public StateTelemetryEN(StateTelemetryEN stateTelemetry)
{
        this.init (Id, stateTelemetry.RangeStates, stateTelemetry.Telemetry, stateTelemetry.Name);
}

private void init (int id
                   , System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.StateDeviceEN> rangeStates, MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name)
{
        this.Id = id;


        this.RangeStates = rangeStates;

        this.Telemetry = telemetry;

        this.Name = name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        StateTelemetryEN t = obj as StateTelemetryEN;
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
