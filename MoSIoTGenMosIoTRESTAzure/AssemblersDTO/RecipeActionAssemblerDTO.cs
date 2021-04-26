using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class RecipeActionAssemblerDTO {
public static IList<RecipeActionEN> ConvertList (IList<RecipeActionDTO> lista)
{
        IList<RecipeActionEN> result = new List<RecipeActionEN>();
        foreach (RecipeActionDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RecipeActionEN Convert (RecipeActionDTO dto)
{
        RecipeActionEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RecipeActionEN ();



                        newinstance.Id = dto.Id;
                        if (dto.Recipe_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRecipeCAD recipeCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RecipeCAD ();

                                newinstance.Recipe = recipeCAD.ReadOIDDefault (dto.Recipe_oid);
                        }
                        if (dto.Operation_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityOperationCAD entityOperationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityOperationCAD ();

                                newinstance.Operation = entityOperationCAD.ReadOIDDefault (dto.Operation_oid);
                        }
                        newinstance.Name = dto.Name;
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
