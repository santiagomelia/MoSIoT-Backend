using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class CareActivityAssemblerDTO {
public static IList<CareActivityEN> ConvertList (IList<CareActivityDTO> lista)
{
        IList<CareActivityEN> result = new List<CareActivityEN>();
        foreach (CareActivityDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static CareActivityEN Convert (CareActivityDTO dto)
{
        CareActivityEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new CareActivityEN ();



                        if (dto.CarePlan_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICarePlanTemplateCAD carePlanTemplateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CarePlanTemplateCAD ();

                                newinstance.CarePlan = carePlanTemplateCAD.ReadOIDDefault (dto.CarePlan_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Periodicity = dto.Periodicity;
                        newinstance.Description = dto.Description;
                        newinstance.Duration = dto.Duration;

                        if (dto.Medication != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IMedicationCAD medicationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.MedicationCAD ();

                                newinstance.Medication = MedicationAssemblerDTO.Convert (dto.Medication);
                        }
                        newinstance.Location = dto.Location;
                        newinstance.OutcomeCode = dto.OutcomeCode;

                        if (dto.NutritionOrder != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.INutritionOrderCAD nutritionOrderCAD = new MoSIoTGenNHibernate.CAD.MosIoT.NutritionOrderCAD ();

                                newinstance.NutritionOrder = NutritionOrderAssemblerDTO.Convert (dto.NutritionOrder);
                        }
                        newinstance.TypeActivity = dto.TypeActivity;
                        if (dto.NextActivity_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICareActivityCAD careActivityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CareActivityCAD ();

                                newinstance.NextActivity = careActivityCAD.ReadOIDDefault (dto.NextActivity_oid);
                        }
                        if (dto.PreviousActivity_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICareActivityCAD careActivityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CareActivityCAD ();

                                newinstance.PreviousActivity = careActivityCAD.ReadOIDDefault (dto.PreviousActivity_oid);
                        }

                        if (dto.Notification != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IComunicationCAD comunicationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.ComunicationCAD ();

                                newinstance.Notification = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN>();
                                foreach (ComunicationDTO entry in dto.Notification) {
                                        newinstance.Notification.Add (ComunicationAssemblerDTO.Convert (entry));
                                }
                        }
                        newinstance.ActivityCode = dto.ActivityCode;
                        newinstance.Name = dto.Name;

                        if (dto.Appointment != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAppointmentCAD appointmentCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AppointmentCAD ();

                                newinstance.Appointment = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN>();
                                foreach (AppointmentDTO entry in dto.Appointment) {
                                        newinstance.Appointment.Add (AppointmentAssemblerDTO.Convert (entry));
                                }
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
