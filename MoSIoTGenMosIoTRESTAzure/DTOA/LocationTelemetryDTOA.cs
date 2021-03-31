using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class LocationTelemetryDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private int latitude;
public int Latitude
{
        get { return latitude; }
        set { latitude = value; }
}

private int longitude;
public int Longitude
{
        get { return longitude; }
        set { longitude = value; }
}

private int altitude;
public int Altitude
{
        get { return altitude; }
        set { altitude = value; }
}
}
}
