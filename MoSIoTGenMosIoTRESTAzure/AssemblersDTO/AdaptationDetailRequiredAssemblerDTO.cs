using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class AdaptationDetailRequiredAssemblerDTO {
public static IList<AdaptationDetailRequiredEN> ConvertList (IList<AdaptationDetailRequiredDTO> lista)
{
        IList<AdaptationDetailRequiredEN> result = new List<AdaptationDetailRequiredEN>();
        foreach (AdaptationDetailRequiredDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static AdaptationDetailRequiredEN Convert (AdaptationDetailRequiredDTO dto)
{
        AdaptationDetailRequiredEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new AdaptationDetailRequiredEN ();



                        newinstance.Id = dto.Id;
                        newinstance.AdaptationRequest = dto.AdaptationRequest;
                        if (dto.AccessMode_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAccessModeCAD accessModeCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AccessModeCAD ();

                                newinstance.AccessMode = accessModeCAD.ReadOIDDefault (dto.AccessMode_oid);
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
