

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
 *      Definition of the class LocationTelemetryCEN
 *
 */
public partial class LocationTelemetryCEN
{
private ILocationTelemetryCAD _ILocationTelemetryCAD;

public LocationTelemetryCEN()
{
        this._ILocationTelemetryCAD = new LocationTelemetryCAD ();
}

public LocationTelemetryCEN(ILocationTelemetryCAD _ILocationTelemetryCAD)
{
        this._ILocationTelemetryCAD = _ILocationTelemetryCAD;
}

public ILocationTelemetryCAD get_ILocationTelemetryCAD ()
{
        return this._ILocationTelemetryCAD;
}

public int New_ (int p_telemetry, string p_name, int p_latitude, int p_longitude, int p_altitude)
{
        LocationTelemetryEN locationTelemetryEN = null;
        int oid;

        //Initialized LocationTelemetryEN
        locationTelemetryEN = new LocationTelemetryEN ();

        if (p_telemetry != -1) {
                // El argumento p_telemetry -> Property telemetry es oid = false
                // Lista de oids id
                locationTelemetryEN.Telemetry = new MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN ();
                locationTelemetryEN.Telemetry.Id = p_telemetry;
        }

        locationTelemetryEN.Name = p_name;

        locationTelemetryEN.Latitude = p_latitude;

        locationTelemetryEN.Longitude = p_longitude;

        locationTelemetryEN.Altitude = p_altitude;

        //Call to LocationTelemetryCAD

        oid = _ILocationTelemetryCAD.New_ (locationTelemetryEN);
        return oid;
}

public void Modify (int p_LocationTelemetry_OID, string p_name, int p_latitude, int p_longitude, int p_altitude)
{
        LocationTelemetryEN locationTelemetryEN = null;

        //Initialized LocationTelemetryEN
        locationTelemetryEN = new LocationTelemetryEN ();
        locationTelemetryEN.Id = p_LocationTelemetry_OID;
        locationTelemetryEN.Name = p_name;
        locationTelemetryEN.Latitude = p_latitude;
        locationTelemetryEN.Longitude = p_longitude;
        locationTelemetryEN.Altitude = p_altitude;
        //Call to LocationTelemetryCAD

        _ILocationTelemetryCAD.Modify (locationTelemetryEN);
}

public void Destroy (int id
                     )
{
        _ILocationTelemetryCAD.Destroy (id);
}

public LocationTelemetryEN ReadOID (int id
                                    )
{
        LocationTelemetryEN locationTelemetryEN = null;

        locationTelemetryEN = _ILocationTelemetryCAD.ReadOID (id);
        return locationTelemetryEN;
}

public System.Collections.Generic.IList<LocationTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LocationTelemetryEN> list = null;

        list = _ILocationTelemetryCAD.ReadAll (first, size);
        return list;
}
}
}
