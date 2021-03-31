using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class DisabilityAssemblerDTO {
public static IList<DisabilityEN> ConvertList (IList<DisabilityDTO> lista)
{
        IList<DisabilityEN> result = new List<DisabilityEN>();
        foreach (DisabilityDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static DisabilityEN Convert (DisabilityDTO dto)
{
        DisabilityEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new DisabilityEN ();



                        if (dto.Patient_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IPatientProfileCAD patientProfileCAD = new MoSIoTGenNHibernate.CAD.MosIoT.PatientProfileCAD ();

                                newinstance.Patient = patientProfileCAD.ReadOIDDefault (dto.Patient_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Type = dto.Type;
                        newinstance.Severity = dto.Severity;
                        if (dto.Origin_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IConditionCAD conditionCAD = new MoSIoTGenNHibernate.CAD.MosIoT.ConditionCAD ();

                                newinstance.Origin = conditionCAD.ReadOIDDefault (dto.Origin_oid);
                        }
                        if (dto.AccessMode_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAccessModeCAD accessModeCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AccessModeCAD ();

                                newinstance.AccessMode = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN>();
                                foreach (int entry in dto.AccessMode_oid) {
                                        newinstance.AccessMode.Add (accessModeCAD.ReadOIDDefault (entry));
                                }
                        }
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
