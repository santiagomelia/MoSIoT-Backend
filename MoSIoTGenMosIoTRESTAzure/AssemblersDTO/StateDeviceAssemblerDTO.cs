using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class StateDeviceAssemblerDTO {
public static IList<StateDeviceEN> ConvertList (IList<StateDeviceDTO> lista)
{
        IList<StateDeviceEN> result = new List<StateDeviceEN>();
        foreach (StateDeviceDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static StateDeviceEN Convert (StateDeviceDTO dto)
{
        StateDeviceEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new StateDeviceEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Value = dto.Value;
                        if (dto.StateTelemetry_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IStateTelemetryCAD stateTelemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.StateTelemetryCAD ();

                                newinstance.StateTelemetry = stateTelemetryCAD.ReadOIDDefault (dto.StateTelemetry_oid);
                        }
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
