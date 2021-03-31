using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class PatientAssemblerDTO {
public static IList<PatientEN> ConvertList (IList<PatientDTO> lista)
{
        IList<PatientEN> result = new List<PatientEN>();
        foreach (PatientDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PatientEN Convert (PatientDTO dto)
{
        PatientEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PatientEN ();



                        if (dto.PatientProfile_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IPatientProfileCAD patientProfileCAD = new MoSIoTGenNHibernate.CAD.MosIoT.PatientProfileCAD ();

                                newinstance.PatientProfile = patientProfileCAD.ReadOIDDefault (dto.PatientProfile_oid);
                        }
                        newinstance.BirthDate = dto.BirthDate;
                        newinstance.Address = dto.Address;
                        newinstance.Surnames = dto.Surnames;
                        newinstance.Phone = dto.Phone;
                        newinstance.Photo = dto.Photo;
                        newinstance.IsActive = dto.IsActive;
                        newinstance.Type = dto.Type;
                        newinstance.IsDiseased = dto.IsDiseased;
                        newinstance.Pass = dto.Pass;
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Description = dto.Description;
                        newinstance.Email = dto.Email;
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
