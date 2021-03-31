using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class AdaptationTypeRequiredAssemblerDTO {
public static IList<AdaptationTypeRequiredEN> ConvertList (IList<AdaptationTypeRequiredDTO> lista)
{
        IList<AdaptationTypeRequiredEN> result = new List<AdaptationTypeRequiredEN>();
        foreach (AdaptationTypeRequiredDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static AdaptationTypeRequiredEN Convert (AdaptationTypeRequiredDTO dto)
{
        AdaptationTypeRequiredEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new AdaptationTypeRequiredEN ();



                        newinstance.Id = dto.Id;
                        newinstance.AdaptionRequest = dto.AdaptionRequest;
                        newinstance.Description = dto.Description;
                        if (dto.AccessMode_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAccessModeCAD accessModeCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AccessModeCAD ();

                                newinstance.AccessMode = accessModeCAD.ReadOIDDefault (dto.AccessMode_oid);
                        }
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
