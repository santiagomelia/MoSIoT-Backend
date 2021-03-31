using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class HealthDataAssemblerDTO {
public static IList<HealthDataEN> ConvertList (IList<HealthDataDTO> lista)
{
        IList<HealthDataEN> result = new List<HealthDataEN>();
        foreach (HealthDataDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static HealthDataEN Convert (HealthDataDTO dto)
{
        HealthDataEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new HealthDataEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Description = dto.Description;
                        newinstance.Language = dto.Language;
                        newinstance.System = dto.System;
                        newinstance.Code = dto.Code;
                        newinstance.Display = dto.Display;
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
