
using System;
// Definición clase LocationTelemetryEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class LocationTelemetryEN                                                                    : MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN


{
/**
 *	Atributo latitude
 */
private int latitude;



/**
 *	Atributo longitude
 */
private int longitude;



/**
 *	Atributo altitude
 */
private int altitude;






public virtual int Latitude {
        get { return latitude; } set { latitude = value;  }
}



public virtual int Longitude {
        get { return longitude; } set { longitude = value;  }
}



public virtual int Altitude {
        get { return altitude; } set { altitude = value;  }
}





public LocationTelemetryEN() : base ()
{
}



public LocationTelemetryEN(int id, int latitude, int longitude, int altitude
                           , MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name
                           )
{
        this.init (Id, latitude, longitude, altitude, telemetry, name);
}


public LocationTelemetryEN(LocationTelemetryEN locationTelemetry)
{
        this.init (Id, locationTelemetry.Latitude, locationTelemetry.Longitude, locationTelemetry.Altitude, locationTelemetry.Telemetry, locationTelemetry.Name);
}

private void init (int id
                   , int latitude, int longitude, int altitude, MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name)
{
        this.Id = id;


        this.Latitude = latitude;

        this.Longitude = longitude;

        this.Altitude = altitude;

        this.Telemetry = telemetry;

        this.Name = name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LocationTelemetryEN t = obj as LocationTelemetryEN;
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
