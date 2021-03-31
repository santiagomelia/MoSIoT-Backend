using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class IoTScenarioAssemblerDTO {
public static IList<IoTScenarioEN> ConvertList (IList<IoTScenarioDTO> lista)
{
        IList<IoTScenarioEN> result = new List<IoTScenarioEN>();
        foreach (IoTScenarioDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static IoTScenarioEN Convert (IoTScenarioDTO dto)
{
        IoTScenarioEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new IoTScenarioEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;

                        if (dto.Entity != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityCAD entityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityCAD ();

                                newinstance.Entity = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityEN>();
                                foreach (EntityDTO entry in dto.Entity) {
                                        newinstance.Entity.Add (EntityAssemblerDTO.Convert (entry));
                                }
                        }

                        if (dto.Recipes != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRecipeCAD recipeCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RecipeCAD ();

                                newinstance.Recipes = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeEN>();
                                foreach (RecipeDTO entry in dto.Recipes) {
                                        newinstance.Recipes.Add (RecipeAssemblerDTO.Convert (entry));
                                }
                        }

                        if (dto.Association != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAssociationCAD associationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AssociationCAD ();

                                newinstance.Association = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN>();
                                foreach (AssociationDTO entry in dto.Association) {
                                        newinstance.Association.Add (AssociationAssemblerDTO.Convert (entry));
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
