using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
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
                        if (dto.IMAdaptationType_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IIMAdaptationTypeCAD iMAdaptationTypeCAD = new MoSIoTGenNHibernate.CAD.MosIoT.IMAdaptationTypeCAD ();

                                newinstance.IMAdaptationType = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.IMAdaptationTypeEN>();
                                foreach (int entry in dto.IMAdaptationType_oid) {
                                        newinstance.IMAdaptationType.Add (iMAdaptationTypeCAD.ReadOIDDefault (entry));
                                }
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
