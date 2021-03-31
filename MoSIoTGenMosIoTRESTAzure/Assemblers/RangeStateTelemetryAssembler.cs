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
public static class RangeStateTelemetryAssembler
{
public static RangeStateTelemetryDTOA Convert (RangeStateTelemetryEN en, NHibernate.ISession session = null)
{
        RangeStateTelemetryDTOA dto = null;
        RangeStateTelemetryRESTCAD rangeStateTelemetryRESTCAD = null;
        RangeStateTelemetryCEN rangeStateTelemetryCEN = null;
        RangeStateTelemetryCP rangeStateTelemetryCP = null;

        if (en != null) {
                dto = new RangeStateTelemetryDTOA ();
                rangeStateTelemetryRESTCAD = new RangeStateTelemetryRESTCAD (session);
                rangeStateTelemetryCEN = new RangeStateTelemetryCEN (rangeStateTelemetryRESTCAD);
                rangeStateTelemetryCP = new RangeStateTelemetryCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Value = en.Value;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
