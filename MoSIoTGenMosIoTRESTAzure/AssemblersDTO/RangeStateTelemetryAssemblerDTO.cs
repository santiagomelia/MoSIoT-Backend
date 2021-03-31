using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class RangeStateTelemetryAssemblerDTO {
public static IList<RangeStateTelemetryEN> ConvertList (IList<RangeStateTelemetryDTO> lista)
{
        IList<RangeStateTelemetryEN> result = new List<RangeStateTelemetryEN>();
        foreach (RangeStateTelemetryDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RangeStateTelemetryEN Convert (RangeStateTelemetryDTO dto)
{
        RangeStateTelemetryEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RangeStateTelemetryEN ();



                        if (dto.StateTelemetry_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IStateTelemetryCAD stateTelemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.StateTelemetryCAD ();

                                newinstance.StateTelemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN>();
                                foreach (int entry in dto.StateTelemetry_oid) {
                                        newinstance.StateTelemetry.Add (stateTelemetryCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Value = dto.Value;
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
