using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class RecipeAssemblerDTO {
public static IList<RecipeEN> ConvertList (IList<RecipeDTO> lista)
{
        IList<RecipeEN> result = new List<RecipeEN>();
        foreach (RecipeDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RecipeEN Convert (RecipeDTO dto)
{
        RecipeEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RecipeEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.IsEnabled = dto.IsEnabled;

                        if (dto.Triggers != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRecipeTriggerCAD recipeTriggerCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RecipeTriggerCAD ();

                                newinstance.Triggers = RecipeTriggerAssemblerDTO.Convert (dto.Triggers);
                        }

                        if (dto.RecipeAction != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRecipeActionCAD recipeActionCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RecipeActionCAD ();

                                newinstance.RecipeAction = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN>();
                                foreach (RecipeActionDTO entry in dto.RecipeAction) {
                                        newinstance.RecipeAction.Add (RecipeActionAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.IoTScenario_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IIoTScenarioCAD ioTScenarioCAD = new MoSIoTGenNHibernate.CAD.MosIoT.IoTScenarioCAD ();

                                newinstance.IoTScenario = ioTScenarioCAD.ReadOIDDefault (dto.IoTScenario_oid);
                        }
                        newinstance.IntervalTime = dto.IntervalTime;
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
