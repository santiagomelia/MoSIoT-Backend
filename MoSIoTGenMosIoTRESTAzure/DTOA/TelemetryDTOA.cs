using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class TelemetryDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private double frecuency;
public double Frecuency
{
        get { return frecuency; }
        set { frecuency = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum schema;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Schema
{
        get { return schema; }
        set { schema = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum unit;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum Unit
{
        get { return unit; }
        set { unit = value; }
}

private string name;
public string Name
{
        get { return name; }
        set { name = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum Type
{
        get { return type; }
        set { type = value; }
}


/* Rol: Telemetry o--> SensorTelemetry */
private SensorTelemetryDTOA sensor;
public SensorTelemetryDTOA Sensor
{
        get { return sensor; }
        set { sensor = value; }
}

/* Rol: Telemetry o--> StateTelemetry */
private StateTelemetryDTOA state;
public StateTelemetryDTOA State
{
        get { return state; }
        set { state = value; }
}

/* Rol: Telemetry o--> LocationTelemetry */
private LocationTelemetryDTOA location;
public LocationTelemetryDTOA Location
{
        get { return location; }
        set { location = value; }
}

/* Rol: Telemetry o--> EventTelemetry */
private EventTelemetryDTOA event_;
public EventTelemetryDTOA Event_
{
        get { return event_; }
        set { event_ = value; }
}
}
}
