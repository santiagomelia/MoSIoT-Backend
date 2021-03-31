using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class NutritionOrderAssemblerDTO {
public static IList<NutritionOrderEN> ConvertList (IList<NutritionOrderDTO> lista)
{
        IList<NutritionOrderEN> result = new List<NutritionOrderEN>();
        foreach (NutritionOrderDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static NutritionOrderEN Convert (NutritionOrderDTO dto)
{
        NutritionOrderEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new NutritionOrderEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Description = dto.Description;
                        newinstance.DietCode = dto.DietCode;
                        if (dto.CareActivity_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICareActivityCAD careActivityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CareActivityCAD ();

                                newinstance.CareActivity = careActivityCAD.ReadOIDDefault (dto.CareActivity_oid);
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
