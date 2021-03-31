using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class EventTelemetryAssemblerDTO {
public static IList<EventTelemetryEN> ConvertList (IList<EventTelemetryDTO> lista)
{
        IList<EventTelemetryEN> result = new List<EventTelemetryEN>();
        foreach (EventTelemetryDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static EventTelemetryEN Convert (EventTelemetryDTO dto)
{
        EventTelemetryEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new EventTelemetryEN ();



                        newinstance.Severity = dto.Severity;
                        if (dto.EventCommand_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICommandCAD commandCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CommandCAD ();

                                newinstance.EventCommand = commandCAD.ReadOIDDefault (dto.EventCommand_oid);
                        }
                        if (dto.Notification_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IComunicationCAD comunicationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.ComunicationCAD ();

                                newinstance.Notification = comunicationCAD.ReadOIDDefault (dto.Notification_oid);
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
