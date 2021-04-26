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
public static class TelemetryAssembler
{
public static TelemetryDTOA Convert (TelemetryEN en, NHibernate.ISession session = null)
{
        TelemetryDTOA dto = null;
        TelemetryRESTCAD telemetryRESTCAD = null;
        TelemetryCEN telemetryCEN = null;
        TelemetryCP telemetryCP = null;

        if (en != null) {
                dto = new TelemetryDTOA ();
                telemetryRESTCAD = new TelemetryRESTCAD (session);
                telemetryCEN = new TelemetryCEN (telemetryRESTCAD);
                telemetryCP = new TelemetryCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Frecuency = en.Frecuency;


                dto.Schema = en.Schema;


                dto.Unit = en.Unit;


                dto.Name = en.Name;


                dto.Type = en.Type;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
