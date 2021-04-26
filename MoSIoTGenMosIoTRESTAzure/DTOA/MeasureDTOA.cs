using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class MeasureDTOA
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

private string lOINCcode;
public string LOINCcode
{
        get { return lOINCcode; }
        set { lOINCcode = value; }
}


/* Rol: Measure o--> Telemetry_2 */
private IList<Telemetry_2DTOA> telemetriesMeasure;
public IList<Telemetry_2DTOA> TelemetriesMeasure
{
        get { return telemetriesMeasure; }
        set { telemetriesMeasure = value; }
}
}
}
