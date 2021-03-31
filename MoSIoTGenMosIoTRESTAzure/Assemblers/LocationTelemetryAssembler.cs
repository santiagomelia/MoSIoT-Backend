using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using MoSIoTGenMosIoTRESTAzure.DTOA;
using MoSIoTGenMosIoTRESTAzure.CAD;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.Assemblers
{
public static class LocationTelemetryAssembler
{
public static LocationTelemetryDTOA Convert (SpecificTelemetryEN en, NHibernate.ISession session = null)
{
        LocationTelemetryDTOA dto = null;
        LocationTelemetryRESTCAD locationTelemetryRESTCAD = null;
        LocationTelemetryCEN locationTelemetryCEN = null;
        LocationTelemetryCP locationTelemetryCP = null;

        if (en != null) {
                dto = new LocationTelemetryDTOA ();
                locationTelemetryRESTCAD = new LocationTelemetryRESTCAD (session);
                locationTelemetryCEN = new LocationTelemetryCEN (locationTelemetryRESTCAD);
                locationTelemetryCP = new LocationTelemetryCP (session);


                LocationTelemetryEN enHijo = locationTelemetryRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                if (enHijo != null)
                        dto.Latitude = enHijo.Latitude;


                if (enHijo != null)
                        dto.Longitude = enHijo.Longitude;


                if (enHijo != null)
                        dto.Altitude = enHijo.Altitude;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
