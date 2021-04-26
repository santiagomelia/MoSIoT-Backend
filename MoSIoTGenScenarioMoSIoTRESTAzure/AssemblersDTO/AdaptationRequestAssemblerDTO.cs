using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class AdaptationRequestAssemblerDTO {
public static IList<AdaptationRequestEN> ConvertList (IList<AdaptationRequestDTO> lista)
{
        IList<AdaptationRequestEN> result = new List<AdaptationRequestEN>();
        foreach (AdaptationRequestDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static AdaptationRequestEN Convert (AdaptationRequestDTO dto)
{
        AdaptationRequestEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new AdaptationRequestEN ();



                        newinstance.AccessModeTarget = dto.AccessModeTarget;
                        newinstance.Id = dto.Id;
                        if (dto.AccessMode_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAccessModeCAD accessModeCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AccessModeCAD ();

                                newinstance.AccessMode = accessModeCAD.ReadOIDDefault (dto.AccessMode_oid);
                        }
                        newinstance.LanguageOfAdaptation = dto.LanguageOfAdaptation;
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
