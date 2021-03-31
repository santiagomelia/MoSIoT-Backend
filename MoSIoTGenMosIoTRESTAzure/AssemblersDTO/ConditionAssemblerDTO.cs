using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class ConditionAssemblerDTO {
public static IList<ConditionEN> ConvertList (IList<ConditionDTO> lista)
{
        IList<ConditionEN> result = new List<ConditionEN>();
        foreach (ConditionDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static ConditionEN Convert (ConditionDTO dto)
{
        ConditionEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new ConditionEN ();



                        if (dto.PatientProfile_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IPatientProfileCAD patientProfileCAD = new MoSIoTGenNHibernate.CAD.MosIoT.PatientProfileCAD ();

                                newinstance.PatientProfile = patientProfileCAD.ReadOIDDefault (dto.PatientProfile_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.DateInitial = dto.DateInitial;
                        newinstance.DateEnd = dto.DateEnd;
                        newinstance.Description = dto.Description;
                        if (dto.Disabilities_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IDisabilityCAD disabilityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.DisabilityCAD ();

                                newinstance.Disabilities = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN>();
                                foreach (int entry in dto.Disabilities_oid) {
                                        newinstance.Disabilities.Add (disabilityCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.ClinicalStatus = dto.ClinicalStatus;
                        newinstance.Disease = dto.Disease;
                        if (dto.CarePlan_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICarePlanTemplateCAD carePlanTemplateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CarePlanTemplateCAD ();

                                newinstance.CarePlan = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN>();
                                foreach (int entry in dto.CarePlan_oid) {
                                        newinstance.CarePlan.Add (carePlanTemplateCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Goal_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IGoalCAD goalCAD = new MoSIoTGenNHibernate.CAD.MosIoT.GoalCAD ();

                                newinstance.Goal = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.GoalEN>();
                                foreach (int entry in dto.Goal_oid) {
                                        newinstance.Goal.Add (goalCAD.ReadOIDDefault (entry));
                                }
                        }
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
