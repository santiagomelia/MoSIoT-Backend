using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class RuleConditionAssemblerDTO {
public static IList<RuleConditionEN> ConvertList (IList<RuleConditionDTO> lista)
{
        IList<RuleConditionEN> result = new List<RuleConditionEN>();
        foreach (RuleConditionDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RuleConditionEN Convert (RuleConditionDTO dto)
{
        RuleConditionEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RuleConditionEN ();



                        if (dto.Rule_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRuleCAD ruleCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RuleCAD ();

                                newinstance.Rule = ruleCAD.ReadOIDDefault (dto.Rule_oid);
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
