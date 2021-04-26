using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class IMNutritionOrderAssemblerDTO {
public static IList<IMNutritionOrderEN> ConvertList (IList<IMNutritionOrderDTO> lista)
{
        IList<IMNutritionOrderEN> result = new List<IMNutritionOrderEN>();
        foreach (IMNutritionOrderDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static IMNutritionOrderEN Convert (IMNutritionOrderDTO dto)
{
        IMNutritionOrderEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new IMNutritionOrderEN ();



                        if (dto.NutritionOrder_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.INutritionOrderCAD nutritionOrderCAD = new MoSIoTGenNHibernate.CAD.MosIoT.NutritionOrderCAD ();

                                newinstance.NutritionOrder = nutritionOrderCAD.ReadOIDDefault (dto.NutritionOrder_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Type = dto.Type;
                        newinstance.IsOID = dto.IsOID;
                        if (dto.TargetAssociation_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAssociationCAD associationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AssociationCAD ();

                                newinstance.TargetAssociation = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN>();
                                foreach (int entry in dto.TargetAssociation_oid) {
                                        newinstance.TargetAssociation.Add (associationCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.OriginAsociation_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IAssociationCAD associationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.AssociationCAD ();

                                newinstance.OriginAsociation = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN>();
                                foreach (int entry in dto.OriginAsociation_oid) {
                                        newinstance.OriginAsociation.Add (associationCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.AssociationType = dto.AssociationType;
                        newinstance.IsWritable = dto.IsWritable;
                        newinstance.Description = dto.Description;
                        if (dto.Entity_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityCAD entityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityCAD ();

                                newinstance.Entity = entityCAD.ReadOIDDefault (dto.Entity_oid);
                        }
                        if (dto.Trigger_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRecipeTriggerCAD recipeTriggerCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RecipeTriggerCAD ();

                                newinstance.Trigger = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN>();
                                foreach (int entry in dto.Trigger_oid) {
                                        newinstance.Trigger.Add (recipeTriggerCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Register_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRegisterCAD registerCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RegisterCAD ();

                                newinstance.Register = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN>();
                                foreach (int entry in dto.Register_oid) {
                                        newinstance.Register.Add (registerCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Value = dto.Value;
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
