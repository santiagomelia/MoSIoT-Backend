using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class RuleActionAssemblerDTO {
public static IList<RuleActionEN> ConvertList (IList<RuleActionDTO> lista)
{
        IList<RuleActionEN> result = new List<RuleActionEN>();
        foreach (RuleActionDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RuleActionEN Convert (RuleActionDTO dto)
{
        RuleActionEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RuleActionEN ();



                        newinstance.Id = dto.Id;
                        if (dto.Rule_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRuleCAD ruleCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RuleCAD ();

                                newinstance.Rule = ruleCAD.ReadOIDDefault (dto.Rule_oid);
                        }
                        if (dto.Operation_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IEntityOperationCAD entityOperationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.EntityOperationCAD ();

                                newinstance.Operation = entityOperationCAD.ReadOIDDefault (dto.Operation_oid);
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
