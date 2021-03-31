using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class CommandAssemblerDTO {
public static IList<CommandEN> ConvertList (IList<CommandDTO> lista)
{
        IList<CommandEN> result = new List<CommandEN>();
        foreach (CommandDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static CommandEN Convert (CommandDTO dto)
{
        CommandEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new CommandEN ();



                        if (dto.DeviceTemplate_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IDeviceTemplateCAD deviceTemplateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.DeviceTemplateCAD ();

                                newinstance.DeviceTemplate = deviceTemplateCAD.ReadOIDDefault (dto.DeviceTemplate_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.IsSynchronous = dto.IsSynchronous;
                        if (dto.Telemetries_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEventTelemetryCAD eventTelemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EventTelemetryCAD ();

                                newinstance.Telemetries = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN>();
                                foreach (int entry in dto.Telemetries_oid) {
                                        newinstance.Telemetries.Add (eventTelemetryCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Type = dto.Type;
                        newinstance.Description = dto.Description;
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
