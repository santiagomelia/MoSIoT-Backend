using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class IMTelemetryValuesDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private Nullable<DateTime> timeStamp;
public Nullable<DateTime> TimeStamp
{
        get { return timeStamp; }
        set { timeStamp = value; }
}

private string valu;
public string Valu
{
        get { return valu; }
        set { valu = value; }
}
}
}
