
using System;
// Definición clase SensorTelemetryEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class SensorTelemetryEN                                                                      : MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN


{
/**
 *	Atributo sensorType
 */
private string sensorType;






public virtual string SensorType {
        get { return sensorType; } set { sensorType = value;  }
}





public SensorTelemetryEN() : base ()
{
}



public SensorTelemetryEN(int id, string sensorType
                         , MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name
                         )
{
        this.init (Id, sensorType, telemetry, name);
}


public SensorTelemetryEN(SensorTelemetryEN sensorTelemetry)
{
        this.init (Id, sensorTelemetry.SensorType, sensorTelemetry.Telemetry, sensorTelemetry.Name);
}

private void init (int id
                   , string sensorType, MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name)
{
        this.Id = id;


        this.SensorType = sensorType;

        this.Telemetry = telemetry;

        this.Name = name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SensorTelemetryEN t = obj as SensorTelemetryEN;
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
