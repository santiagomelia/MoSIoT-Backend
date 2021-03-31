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
public static class EventTelemetryAssembler
{
public static EventTelemetryDTOA Convert (SpecificTelemetryEN en, NHibernate.ISession session = null)
{
        EventTelemetryDTOA dto = null;
        EventTelemetryRESTCAD eventTelemetryRESTCAD = null;
        EventTelemetryCEN eventTelemetryCEN = null;
        EventTelemetryCP eventTelemetryCP = null;

        if (en != null) {
                dto = new EventTelemetryDTOA ();
                eventTelemetryRESTCAD = new EventTelemetryRESTCAD (session);
                eventTelemetryCEN = new EventTelemetryCEN (eventTelemetryRESTCAD);
                eventTelemetryCP = new EventTelemetryCP (session);


                EventTelemetryEN enHijo = eventTelemetryRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                if (enHijo != null)
                        dto.Severity = enHijo.Severity;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
