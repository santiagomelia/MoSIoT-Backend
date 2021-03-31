using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class UserAssemblerDTO {
public static IList<UserEN> ConvertList (IList<UserDTO> lista)
{
        IList<UserEN> result = new List<UserEN>();
        foreach (UserDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static UserEN Convert (UserDTO dto)
{
        UserEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new UserEN ();



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
