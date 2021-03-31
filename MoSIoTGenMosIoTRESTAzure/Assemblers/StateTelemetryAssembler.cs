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
public static class StateTelemetryAssembler
{
public static StateTelemetryDTOA Convert (SpecificTelemetryEN en, NHibernate.ISession session = null)
{
        StateTelemetryDTOA dto = null;
        StateTelemetryRESTCAD stateTelemetryRESTCAD = null;
        StateTelemetryCEN stateTelemetryCEN = null;
        StateTelemetryCP stateTelemetryCP = null;

        if (en != null) {
                dto = new StateTelemetryDTOA ();
                stateTelemetryRESTCAD = new StateTelemetryRESTCAD (session);
                stateTelemetryCEN = new StateTelemetryCEN (stateTelemetryRESTCAD);
                stateTelemetryCP = new StateTelemetryCP (session);


                StateTelemetryEN enHijo = stateTelemetryRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                //
                // TravesalLink

                /* Rol: StateTelemetry o--> StateDevice */
                dto.States = null;
                List<StateDeviceEN> States = stateTelemetryRESTCAD.States (en.Id).ToList ();
                if (States != null) {
                        dto.States = new List<StateDeviceDTOA>();
                        foreach (StateDeviceEN entry in States)
                                dto.States.Add (StateDeviceAssembler.Convert (entry, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
