using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class SpecificTelemetryAssemblerDTO {
public static IList<SpecificTelemetryEN> ConvertList (IList<SpecificTelemetryDTO> lista)
{
        IList<SpecificTelemetryEN> result = new List<SpecificTelemetryEN>();
        foreach (SpecificTelemetryDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static SpecificTelemetryEN Convert (SpecificTelemetryDTO dto)
{
        SpecificTelemetryEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new SpecificTelemetryEN ();



                        if (dto.Telemetry_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ITelemetryCAD telemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.TelemetryCAD ();

                                newinstance.Telemetry = telemetryCAD.ReadOIDDefault (dto.Telemetry_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                }
        }
        catch (Exception ex)
        {
                throw ex;
        }
        return newinstance;
}
}
}
