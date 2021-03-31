

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;

using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


namespace MoSIoTGenNHibernate.CEN.MosIoT
{
/*
 *      Definition of the class EventTelemetryCEN
 *
 */
public partial class EventTelemetryCEN
{
private IEventTelemetryCAD _IEventTelemetryCAD;

public EventTelemetryCEN()
{
        this._IEventTelemetryCAD = new EventTelemetryCAD ();
}

public EventTelemetryCEN(IEventTelemetryCAD _IEventTelemetryCAD)
{
        this._IEventTelemetryCAD = _IEventTelemetryCAD;
}

public IEventTelemetryCAD get_IEventTelemetryCAD ()
{
        return this._IEventTelemetryCAD;
}

public int New_ (int p_telemetry, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum p_severity)
{
        EventTelemetryEN eventTelemetryEN = null;
        int oid;

        //Initialized EventTelemetryEN
        eventTelemetryEN = new EventTelemetryEN ();

        if (p_telemetry != -1) {
                // El argumento p_telemetry -> Property telemetry es oid = false
                // Lista de oids id
                eventTelemetryEN.Telemetry = new MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN ();
                eventTelemetryEN.Telemetry.Id = p_telemetry;
        }

        eventTelemetryEN.Name = p_name;

        eventTelemetryEN.Severity = p_severity;

        //Call to EventTelemetryCAD

        oid = _IEventTelemetryCAD.New_ (eventTelemetryEN);
        return oid;
}

public void Modify (int p_EventTelemetry_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum p_severity)
{
        EventTelemetryEN eventTelemetryEN = null;

        //Initialized EventTelemetryEN
        eventTelemetryEN = new EventTelemetryEN ();
        eventTelemetryEN.Id = p_EventTelemetry_OID;
        eventTelemetryEN.Name = p_name;
        eventTelemetryEN.Severity = p_severity;
        //Call to EventTelemetryCAD

        _IEventTelemetryCAD.Modify (eventTelemetryEN);
}

public void Destroy (int id
                     )
{
        _IEventTelemetryCAD.Destroy (id);
}

public EventTelemetryEN ReadOID (int id
                                 )
{
        EventTelemetryEN eventTelemetryEN = null;

        eventTelemetryEN = _IEventTelemetryCAD.ReadOID (id);
        return eventTelemetryEN;
}

public System.Collections.Generic.IList<EventTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EventTelemetryEN> list = null;

        list = _IEventTelemetryCAD.ReadAll (first, size);
        return list;
}
}
}
