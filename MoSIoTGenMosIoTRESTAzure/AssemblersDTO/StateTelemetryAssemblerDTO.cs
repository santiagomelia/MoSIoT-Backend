using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class StateTelemetryAssemblerDTO {
public static IList<StateTelemetryEN> ConvertList (IList<StateTelemetryDTO> lista)
{
        IList<StateTelemetryEN> result = new List<StateTelemetryEN>();
        foreach (StateTelemetryDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static StateTelemetryEN Convert (StateTelemetryDTO dto)
{
        StateTelemetryEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new StateTelemetryEN ();




                        if (dto.RangeStates != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IStateDeviceCAD stateDeviceCAD = new MoSIoTGenNHibernate.CAD.MosIoT.StateDeviceCAD ();

                                newinstance.RangeStates = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.StateDeviceEN>();
                                foreach (StateDeviceDTO entry in dto.RangeStates) {
                                        newinstance.RangeStates.Add (StateDeviceAssemblerDTO.Convert (entry));
                                }
                        }
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
