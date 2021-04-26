using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class EntityStateAssemblerDTO {
public static IList<EntityStateEN> ConvertList (IList<EntityStateDTO> lista)
{
        IList<EntityStateEN> result = new List<EntityStateEN>();
        foreach (EntityStateDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static EntityStateEN Convert (EntityStateDTO dto)
{
        EntityStateEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new EntityStateEN ();



                        newinstance.Id = dto.Id;
                        if (dto.VirtualEntity_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityCAD entityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityCAD ();

                                newinstance.VirtualEntity = entityCAD.ReadOIDDefault (dto.VirtualEntity_oid);
                        }
                        if (dto.OriginOperations_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityOperationCAD entityOperationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityOperationCAD ();

                                newinstance.OriginOperations = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN>();
                                foreach (int entry in dto.OriginOperations_oid) {
                                        newinstance.OriginOperations.Add (entityOperationCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.TargetOperations_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityOperationCAD entityOperationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityOperationCAD ();

                                newinstance.TargetOperations = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN>();
                                foreach (int entry in dto.TargetOperations_oid) {
                                        newinstance.TargetOperations.Add (entityOperationCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.Type = dto.Type;
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
