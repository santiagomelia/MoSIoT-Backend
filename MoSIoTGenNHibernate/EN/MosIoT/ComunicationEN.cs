
using System;
// Definición clase ComunicationEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class ComunicationEN
{
/**
 *	Atributo severity
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity;



/**
 *	Atributo message
 */
private string message;



/**
 *	Atributo sendDate
 */
private Nullable<DateTime> sendDate;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo eventTelemetry
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN> eventTelemetry;



/**
 *	Atributo careActivity
 */
private MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity;



/**
 *	Atributo carePlanTemplate
 */
private MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplate;






public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum Severity {
        get { return severity; } set { severity = value;  }
}



public virtual string Message {
        get { return message; } set { message = value;  }
}



public virtual Nullable<DateTime> SendDate {
        get { return sendDate; } set { sendDate = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN> EventTelemetry {
        get { return eventTelemetry; } set { eventTelemetry = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN CareActivity {
        get { return careActivity; } set { careActivity = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN CarePlanTemplate {
        get { return carePlanTemplate; } set { carePlanTemplate = value;  }
}





public ComunicationEN()
{
        eventTelemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN>();
}



public ComunicationEN(int id, MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity, string message, Nullable<DateTime> sendDate, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN> eventTelemetry, MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity, MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplate
                      )
{
        this.init (Id, severity, message, sendDate, eventTelemetry, careActivity, carePlanTemplate);
}


public ComunicationEN(ComunicationEN comunication)
{
        this.init (Id, comunication.Severity, comunication.Message, comunication.SendDate, comunication.EventTelemetry, comunication.CareActivity, comunication.CarePlanTemplate);
}

private void init (int id
                   , MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity, string message, Nullable<DateTime> sendDate, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN> eventTelemetry, MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity, MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplate)
{
        this.Id = id;


        this.Severity = severity;

        this.Message = message;

        this.SendDate = sendDate;

        this.EventTelemetry = eventTelemetry;

        this.CareActivity = careActivity;

        this.CarePlanTemplate = carePlanTemplate;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ComunicationEN t = obj as ComunicationEN;
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
