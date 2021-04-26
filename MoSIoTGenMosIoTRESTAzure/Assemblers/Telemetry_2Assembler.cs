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
public static class Telemetry_2Assembler
{
public static Telemetry_2DTOA Convert (TelemetryEN en, NHibernate.ISession session = null)
{
        Telemetry_2DTOA dto = null;
        Telemetry_2RESTCAD telemetry_2RESTCAD = null;
        TelemetryCEN telemetryCEN = null;
        TelemetryCP telemetryCP = null;

        if (en != null) {
                dto = new Telemetry_2DTOA ();
                telemetry_2RESTCAD = new Telemetry_2RESTCAD (session);
                telemetryCEN = new TelemetryCEN (telemetry_2RESTCAD);
                telemetryCP = new TelemetryCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Type = en.Type;


                dto.Frecuency = en.Frecuency;


                dto.Schema = en.Schema;


                dto.Unit = en.Unit;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
