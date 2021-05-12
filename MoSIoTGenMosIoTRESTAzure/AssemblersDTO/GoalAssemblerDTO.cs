using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class GoalAssemblerDTO {
public static IList<GoalEN> ConvertList (IList<GoalDTO> lista)
{
        IList<GoalEN> result = new List<GoalEN>();
        foreach (GoalDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static GoalEN Convert (GoalDTO dto)
{
        GoalEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new GoalEN ();



                        if (dto.CarePlanTemplate_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICarePlanTemplateCAD carePlanTemplateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CarePlanTemplateCAD ();

                                newinstance.CarePlanTemplate = carePlanTemplateCAD.ReadOIDDefault (dto.CarePlanTemplate_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Priority = dto.Priority;

                        if (dto.Targets != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ITargetCAD targetCAD = new MoSIoTGenNHibernate.CAD.MosIoT.TargetCAD ();

                                newinstance.Targets = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TargetEN>();
                                foreach (TargetDTO entry in dto.Targets) {
                                        newinstance.Targets.Add (TargetAssemblerDTO.Convert (entry));
                                }
                        }
                        newinstance.Status = dto.Status;
                        if (dto.Condition_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IConditionCAD conditionCAD = new MoSIoTGenNHibernate.CAD.MosIoT.ConditionCAD ();

                                newinstance.Condition = conditionCAD.ReadOIDDefault (dto.Condition_oid);
                        }
                        newinstance.Description = dto.Description;
                        newinstance.Category = dto.Category;
                        newinstance.OutcomeCode = dto.OutcomeCode;
                        newinstance.Name = dto.Name;
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
