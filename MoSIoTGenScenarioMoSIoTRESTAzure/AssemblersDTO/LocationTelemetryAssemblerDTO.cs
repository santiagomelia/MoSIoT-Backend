using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class LocationTelemetryAssemblerDTO {
public static IList<LocationTelemetryEN> ConvertList (IList<LocationTelemetryDTO> lista)
{
        IList<LocationTelemetryEN> result = new List<LocationTelemetryEN>();
        foreach (LocationTelemetryDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static LocationTelemetryEN Convert (LocationTelemetryDTO dto)
{
        LocationTelemetryEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new LocationTelemetryEN ();



                        newinstance.Latitude = dto.Latitude;
                        newinstance.Longitude = dto.Longitude;
                        newinstance.Altitude = dto.Altitude;
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
