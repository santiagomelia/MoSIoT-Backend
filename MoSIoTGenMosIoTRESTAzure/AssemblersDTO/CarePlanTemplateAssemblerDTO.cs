using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class CarePlanTemplateAssemblerDTO {
public static IList<CarePlanTemplateEN> ConvertList (IList<CarePlanTemplateDTO> lista)
{
        IList<CarePlanTemplateEN> result = new List<CarePlanTemplateEN>();
        foreach (CarePlanTemplateDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static CarePlanTemplateEN Convert (CarePlanTemplateDTO dto)
{
        CarePlanTemplateEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new CarePlanTemplateEN ();




                        if (dto.CareActivity != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICareActivityCAD careActivityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CareActivityCAD ();

                                newinstance.CareActivity = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN>();
                                foreach (CareActivityDTO entry in dto.CareActivity) {
                                        newinstance.CareActivity.Add (CareActivityAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.PatientProfile_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IPatientProfileCAD patientProfileCAD = new MoSIoTGenNHibernate.CAD.MosIoT.PatientProfileCAD ();

                                newinstance.PatientProfile = patientProfileCAD.ReadOIDDefault (dto.PatientProfile_oid);
                        }
                        newinstance.Status = dto.Status;
                        newinstance.Intent = dto.Intent;
                        newinstance.Title = dto.Title;
                        newinstance.Modified = dto.Modified;

                        if (dto.Goals != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IGoalCAD goalCAD = new MoSIoTGenNHibernate.CAD.MosIoT.GoalCAD ();

                                newinstance.Goals = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.GoalEN>();
                                foreach (GoalDTO entry in dto.Goals) {
                                        newinstance.Goals.Add (GoalAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.AddressConditions_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IConditionCAD conditionCAD = new MoSIoTGenNHibernate.CAD.MosIoT.ConditionCAD ();

                                newinstance.AddressConditions = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN>();
                                foreach (int entry in dto.AddressConditions_oid) {
                                        newinstance.AddressConditions.Add (conditionCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Id = dto.Id;
                        newinstance.DurationDays = dto.DurationDays;
                        newinstance.Name = dto.Name;
                        newinstance.Description = dto.Description;

                        if (dto.Comunication != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IComunicationCAD comunicationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.ComunicationCAD ();

                                newinstance.Comunication = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN>();
                                foreach (ComunicationDTO entry in dto.Comunication) {
                                        newinstance.Comunication.Add (ComunicationAssemblerDTO.Convert (entry));
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
