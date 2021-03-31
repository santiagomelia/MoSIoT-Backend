using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class ComunicationAssemblerDTO {
public static IList<ComunicationEN> ConvertList (IList<ComunicationDTO> lista)
{
        IList<ComunicationEN> result = new List<ComunicationEN>();
        foreach (ComunicationDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static ComunicationEN Convert (ComunicationDTO dto)
{
        ComunicationEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new ComunicationEN ();



                        newinstance.Severity = dto.Severity;
                        newinstance.Message = dto.Message;
                        newinstance.SendDate = dto.SendDate;
                        newinstance.Id = dto.Id;
                        if (dto.EventTelemetry_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEventTelemetryCAD eventTelemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EventTelemetryCAD ();

                                newinstance.EventTelemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN>();
                                foreach (int entry in dto.EventTelemetry_oid) {
                                        newinstance.EventTelemetry.Add (eventTelemetryCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.CareActivity_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICareActivityCAD careActivityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CareActivityCAD ();

                                newinstance.CareActivity = careActivityCAD.ReadOIDDefault (dto.CareActivity_oid);
                        }
                        if (dto.CarePlanTemplate_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICarePlanTemplateCAD carePlanTemplateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CarePlanTemplateCAD ();

                                newinstance.CarePlanTemplate = carePlanTemplateCAD.ReadOIDDefault (dto.CarePlanTemplate_oid);
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
