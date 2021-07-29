using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class PatientProfileAssemblerDTO {
public static IList<PatientProfileEN> ConvertList (IList<PatientProfileDTO> lista)
{
        IList<PatientProfileEN> result = new List<PatientProfileEN>();
        foreach (PatientProfileDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PatientProfileEN Convert (PatientProfileDTO dto)
{
        PatientProfileEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PatientProfileEN ();




                        if (dto.AccessMode != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAccessModeCAD accessModeCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AccessModeCAD ();

                                newinstance.AccessMode = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN>();
                                foreach (AccessModeDTO entry in dto.AccessMode) {
                                        newinstance.AccessMode.Add (AccessModeAssemblerDTO.Convert (entry));
                                }
                        }
                        newinstance.PreferredLanguage = dto.PreferredLanguage;
                        newinstance.Region = dto.Region;
                        newinstance.HazardAvoidance = dto.HazardAvoidance;

                        if (dto.Disability != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IDisabilityCAD disabilityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.DisabilityCAD ();

                                newinstance.Disability = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN>();
                                foreach (DisabilityDTO entry in dto.Disability) {
                                        newinstance.Disability.Add (DisabilityAssemblerDTO.Convert (entry));
                                }
                        }
                        newinstance.Id = dto.Id;
                        if (dto.CarePlanTemplate_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICarePlanTemplateCAD carePlanTemplateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CarePlanTemplateCAD ();

                                newinstance.CarePlanTemplate = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN>();
                                foreach (int entry in dto.CarePlanTemplate_oid) {
                                        newinstance.CarePlanTemplate.Add (carePlanTemplateCAD.ReadOIDDefault (entry));
                                }
                        }

                        if (dto.Diseases != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IConditionCAD conditionCAD = new MoSIoTGenNHibernate.CAD.MosIoT.ConditionCAD ();

                                newinstance.Diseases = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN>();
                                foreach (ConditionDTO entry in dto.Diseases) {
                                        newinstance.Diseases.Add (ConditionAssemblerDTO.Convert (entry));
                                }
                        }
                        newinstance.Name = dto.Name;
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
