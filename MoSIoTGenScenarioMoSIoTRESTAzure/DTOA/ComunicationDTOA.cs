using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class ComunicationDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum severity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEventEnum Severity
{
        get { return severity; }
        set { severity = value; }
}

private string message;
public string Message
{
        get { return message; }
        set { message = value; }
}

private Nullable<DateTime> sendDate;
public Nullable<DateTime> SendDate
{
        get { return sendDate; }
        set { sendDate = value; }
}
}
}
