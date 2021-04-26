using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class IMTelemetryDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private string name;
public string Name
{
        get { return name; }
        set { name = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}


/* Rol: IMTelemetry o--> Telemetry */
private TelemetryDTOA telemetry;
public TelemetryDTOA Telemetry
{
        get { return telemetry; }
        set { telemetry = value; }
}
}
}
