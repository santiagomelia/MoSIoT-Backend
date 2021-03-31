
using System;
// Definición clase EventTelemetryEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class EventTelemetryEN                                                                       : MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN


{
/**
 *	Atributo severity
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity;



/**
 *	Atributo eventCommand
 */
private MoSIoTGenNHibernate.EN.MosIoT.CommandEN eventCommand;



/**
 *	Atributo notification
 */
private MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN notification;






public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum Severity {
        get { return severity; } set { severity = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.CommandEN EventCommand {
        get { return eventCommand; } set { eventCommand = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN Notification {
        get { return notification; } set { notification = value;  }
}





public EventTelemetryEN() : base ()
{
}



public EventTelemetryEN(int id, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity, MoSIoTGenNHibernate.EN.MosIoT.CommandEN eventCommand, MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN notification
                        , MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name
                        )
{
        this.init (Id, severity, eventCommand, notification, telemetry, name);
}


public EventTelemetryEN(EventTelemetryEN eventTelemetry)
{
        this.init (Id, eventTelemetry.Severity, eventTelemetry.EventCommand, eventTelemetry.Notification, eventTelemetry.Telemetry, eventTelemetry.Name);
}

private void init (int id
                   , MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity, MoSIoTGenNHibernate.EN.MosIoT.CommandEN eventCommand, MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN notification, MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name)
{
        this.Id = id;


        this.Severity = severity;

        this.EventCommand = eventCommand;

        this.Notification = notification;

        this.Telemetry = telemetry;

        this.Name = name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EventTelemetryEN t = obj as EventTelemetryEN;
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
