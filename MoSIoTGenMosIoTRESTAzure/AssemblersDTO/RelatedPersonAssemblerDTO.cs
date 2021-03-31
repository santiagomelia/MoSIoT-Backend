using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class RelatedPersonAssemblerDTO {
public static IList<RelatedPersonEN> ConvertList (IList<RelatedPersonDTO> lista)
{
        IList<RelatedPersonEN> result = new List<RelatedPersonEN>();
        foreach (RelatedPersonDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RelatedPersonEN Convert (RelatedPersonDTO dto)
{
        RelatedPersonEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RelatedPersonEN ();



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
