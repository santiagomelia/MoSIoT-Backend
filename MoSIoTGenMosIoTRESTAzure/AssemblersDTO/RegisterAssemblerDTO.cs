using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class RegisterAssemblerDTO {
public static IList<RegisterEN> ConvertList (IList<RegisterDTO> lista)
{
        IList<RegisterEN> result = new List<RegisterEN>();
        foreach (RegisterDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RegisterEN Convert (RegisterDTO dto)
{
        RegisterEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RegisterEN ();



                        if (dto.EntityAttributes_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityAttributesCAD entityAttributesCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityAttributesCAD ();

                                newinstance.EntityAttributes = entityAttributesCAD.ReadOIDDefault (dto.EntityAttributes_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Type = dto.Type;
                        newinstance.ServiceType = dto.ServiceType;
                        newinstance.Description = dto.Description;

                        if (dto.EntityArgument != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityArgumentCAD entityArgumentCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityArgumentCAD ();

                                newinstance.EntityArgument = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityArgumentEN>();
                                foreach (EntityArgumentDTO entry in dto.EntityArgument) {
                                        newinstance.EntityArgument.Add (EntityArgumentAssemblerDTO.Convert (entry));
                                }
                        }
                        if (dto.Entity_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityCAD entityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityCAD ();

                                newinstance.Entity = entityCAD.ReadOIDDefault (dto.Entity_oid);
                        }
                        if (dto.RuleAction_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRecipeActionCAD recipeActionCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RecipeActionCAD ();

                                newinstance.RuleAction = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeActionEN>();
                                foreach (int entry in dto.RuleAction_oid) {
                                        newinstance.RuleAction.Add (recipeActionCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.OriginState_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityStateCAD entityStateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityStateCAD ();

                                newinstance.OriginState = entityStateCAD.ReadOIDDefault (dto.OriginState_oid);
                        }
                        if (dto.TargetState_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityStateCAD entityStateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityStateCAD ();

                                newinstance.TargetState = entityStateCAD.ReadOIDDefault (dto.TargetState_oid);
                        }
                        if (dto.Triggers_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRecipeTriggerCAD recipeTriggerCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RecipeTriggerCAD ();

                                newinstance.Triggers = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN>();
                                foreach (int entry in dto.Triggers_oid) {
                                        newinstance.Triggers.Add (recipeTriggerCAD.ReadOIDDefault (entry));
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
