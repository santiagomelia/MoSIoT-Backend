using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class SensorTelemetryAssemblerDTO {
public static IList<SensorTelemetryEN> ConvertList (IList<SensorTelemetryDTO> lista)
{
        IList<SensorTelemetryEN> result = new List<SensorTelemetryEN>();
        foreach (SensorTelemetryDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static SensorTelemetryEN Convert (SensorTelemetryDTO dto)
{
        SensorTelemetryEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new SensorTelemetryEN ();



                        newinstance.SensorType = dto.SensorType;
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
