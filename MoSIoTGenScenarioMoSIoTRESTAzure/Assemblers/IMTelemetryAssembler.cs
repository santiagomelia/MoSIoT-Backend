using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using MoSIoTGenScenarioMoSIoTRESTAzure.DTOA;
using MoSIoTGenScenarioMoSIoTRESTAzure.CAD;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.Assemblers
{
public static class IMTelemetryAssembler
{
public static IMTelemetryDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        IMTelemetryDTOA dto = null;
        IMTelemetryRESTCAD iMTelemetryRESTCAD = null;
        IMTelemetryCEN iMTelemetryCEN = null;
        IMTelemetryCP iMTelemetryCP = null;

        if (en != null) {
                dto = new IMTelemetryDTOA ();
                iMTelemetryRESTCAD = new IMTelemetryRESTCAD (session);
                iMTelemetryCEN = new IMTelemetryCEN (iMTelemetryRESTCAD);
                iMTelemetryCP = new IMTelemetryCP (session);


                IMTelemetryEN enHijo = iMTelemetryRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: IMTelemetry o--> Telemetry */
                dto.Telemetry = TelemetryAssembler.Convert ((TelemetryEN)enHijo.Telemetry, session);


                //
                // Service
        }

        return dto;
}
}
}
