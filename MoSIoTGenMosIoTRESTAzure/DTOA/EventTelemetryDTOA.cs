using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class EventTelemetryDTOA
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
}
}
