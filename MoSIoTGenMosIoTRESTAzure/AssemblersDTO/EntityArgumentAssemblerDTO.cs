using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class EntityArgumentAssemblerDTO {
public static IList<EntityArgumentEN> ConvertList (IList<EntityArgumentDTO> lista)
{
        IList<EntityArgumentEN> result = new List<EntityArgumentEN>();
        foreach (EntityArgumentDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static EntityArgumentEN Convert (EntityArgumentDTO dto)
{
        EntityArgumentEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new EntityArgumentEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Type = dto.Type;
                        if (dto.EntityOperation_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityOperationCAD entityOperationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityOperationCAD ();

                                newinstance.EntityOperation = entityOperationCAD.ReadOIDDefault (dto.EntityOperation_oid);
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
