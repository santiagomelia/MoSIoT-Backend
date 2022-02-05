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
public static class IMTelemetryValuesAssembler
{
public static IMTelemetryValuesDTOA Convert (IMTelemetryValuesEN en, NHibernate.ISession session = null)
{
        IMTelemetryValuesDTOA dto = null;
        IMTelemetryValuesRESTCAD iMTelemetryValuesRESTCAD = null;
        IMTelemetryValuesCEN iMTelemetryValuesCEN = null;
        IMTelemetryValuesCP iMTelemetryValuesCP = null;

        if (en != null) {
                dto = new IMTelemetryValuesDTOA ();
                iMTelemetryValuesRESTCAD = new IMTelemetryValuesRESTCAD (session);
                iMTelemetryValuesCEN = new IMTelemetryValuesCEN (iMTelemetryValuesRESTCAD);
                iMTelemetryValuesCP = new IMTelemetryValuesCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.TimeStamp = en.TimeStamp;


                dto.Valu = en.Valu;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
