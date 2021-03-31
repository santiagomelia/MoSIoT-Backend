using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class RuleAssemblerDTO {
public static IList<RuleEN> ConvertList (IList<RuleDTO> lista)
{
        IList<RuleEN> result = new List<RuleEN>();
        foreach (RuleDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static RuleEN Convert (RuleDTO dto)
{
        RuleEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new RuleEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.IsEnabled = dto.IsEnabled;

                        if (dto.Condition != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRuleConditionCAD ruleConditionCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RuleConditionCAD ();

                                newinstance.Condition = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RuleConditionEN>();
                                foreach (RuleConditionDTO entry in dto.Condition) {
                                        newinstance.Condition.Add (RuleConditionAssemblerDTO.Convert (entry));
                                }
                        }

                        if (dto.RuleAction != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IRuleActionCAD ruleActionCAD = new MoSIoTGenNHibernate.CAD.MosIoT.RuleActionCAD ();

                                newinstance.RuleAction = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RuleActionEN>();
                                foreach (RuleActionDTO entry in dto.RuleAction) {
                                        newinstance.RuleAction.Add (RuleActionAssemblerDTO.Convert (entry));
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
