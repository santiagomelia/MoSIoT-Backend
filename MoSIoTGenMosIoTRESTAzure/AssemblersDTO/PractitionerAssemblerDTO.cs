using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class PractitionerAssemblerDTO {
public static IList<PractitionerEN> ConvertList (IList<PractitionerDTO> lista)
{
        IList<PractitionerEN> result = new List<PractitionerEN>();
        foreach (PractitionerDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PractitionerEN Convert (PractitionerDTO dto)
{
        PractitionerEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PractitionerEN ();



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
