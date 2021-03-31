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
public static class SensorTelemetryAssembler
{
public static SensorTelemetryDTOA Convert (SpecificTelemetryEN en, NHibernate.ISession session = null)
{
        SensorTelemetryDTOA dto = null;
        SensorTelemetryRESTCAD sensorTelemetryRESTCAD = null;
        SensorTelemetryCEN sensorTelemetryCEN = null;
        SensorTelemetryCP sensorTelemetryCP = null;

        if (en != null) {
                dto = new SensorTelemetryDTOA ();
                sensorTelemetryRESTCAD = new SensorTelemetryRESTCAD (session);
                sensorTelemetryCEN = new SensorTelemetryCEN (sensorTelemetryRESTCAD);
                sensorTelemetryCP = new SensorTelemetryCP (session);


                SensorTelemetryEN enHijo = sensorTelemetryRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                if (enHijo != null)
                        dto.SensorType = enHijo.SensorType;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
