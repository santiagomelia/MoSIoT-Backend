using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class AccessModeAssemblerDTO {
public static IList<AccessModeEN> ConvertList (IList<AccessModeDTO> lista)
{
        IList<AccessModeEN> result = new List<AccessModeEN>();
        foreach (AccessModeDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static AccessModeEN Convert (AccessModeDTO dto)
{
        AccessModeEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new AccessModeEN ();



                        if (dto.Patient_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IPatientProfileCAD patientProfileCAD = new MoSIoTGenNHibernate.CAD.MosIoT.PatientProfileCAD ();

                                newinstance.Patient = patientProfileCAD.ReadOIDDefault (dto.Patient_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.TypeAccessMode = dto.TypeAccessMode;

                        if (dto.AdaptationDetailRequired != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAdaptationDetailRequiredCAD adaptationDetailRequiredCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AdaptationDetailRequiredCAD ();

                                newinstance.AdaptationDetailRequired = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN>();
                                foreach (AdaptationDetailRequiredDTO entry in dto.AdaptationDetailRequired) {
                                        newinstance.AdaptationDetailRequired.Add (AdaptationDetailRequiredAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.DeviceTemplate_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IDeviceTemplateCAD deviceTemplateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.DeviceTemplateCAD ();

                                newinstance.DeviceTemplate = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN>();
                                foreach (int entry in dto.DeviceTemplate_oid) {
                                        newinstance.DeviceTemplate.Add (deviceTemplateCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Description = dto.Description;

                        if (dto.AdaptationTypeRequired != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAdaptationTypeRequiredCAD adaptationTypeRequiredCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AdaptationTypeRequiredCAD ();

                                newinstance.AdaptationTypeRequired = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN>();
                                foreach (AdaptationTypeRequiredDTO entry in dto.AdaptationTypeRequired) {
                                        newinstance.AdaptationTypeRequired.Add (AdaptationTypeRequiredAssemblerDTO.Convert (entry));
                                }
                        }

                        if (dto.AdaptationRequest != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAdaptationRequestCAD adaptationRequestCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AdaptationRequestCAD ();

                                newinstance.AdaptationRequest = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN>();
                                foreach (AdaptationRequestDTO entry in dto.AdaptationRequest) {
                                        newinstance.AdaptationRequest.Add (AdaptationRequestAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.Disability_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IDisabilityCAD disabilityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.DisabilityCAD ();

                                newinstance.Disability = disabilityCAD.ReadOIDDefault (dto.Disability_oid);
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
