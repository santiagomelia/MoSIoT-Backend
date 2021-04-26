using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class RecipeTriggerAssemblerDTO {
public static IList<RecipeTriggerEN> ConvertList (IList<RecipeTriggerDTO> lista)
{
        IList<RecipeTriggerEN> result = new List<RecipeTriggerEN>();
        foreach (RecipeTriggerDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RecipeTriggerEN Convert (RecipeTriggerDTO dto)
{
        RecipeTriggerEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RecipeTriggerEN ();



                        if (dto.Recipe_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRecipeCAD recipeCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RecipeCAD ();

                                newinstance.Recipe = recipeCAD.ReadOIDDefault (dto.Recipe_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Operator_ = dto.Operator_;
                        newinstance.Value = dto.Value;
                        if (dto.EntityAttributes_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityAttributesCAD entityAttributesCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityAttributesCAD ();

                                newinstance.EntityAttributes = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN>();
                                foreach (int entry in dto.EntityAttributes_oid) {
                                        newinstance.EntityAttributes.Add (entityAttributesCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Event__oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityOperationCAD entityOperationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityOperationCAD ();

                                newinstance.Event_ = entityOperationCAD.ReadOIDDefault (dto.Event__oid);
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
