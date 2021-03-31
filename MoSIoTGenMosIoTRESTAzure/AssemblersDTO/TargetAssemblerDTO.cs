using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class TargetAssemblerDTO {
public static IList<TargetEN> ConvertList (IList<TargetDTO> lista)
{
        IList<TargetEN> result = new List<TargetEN>();
        foreach (TargetDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static TargetEN Convert (TargetDTO dto)
{
        TargetEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new TargetEN ();



                        newinstance.Id = dto.Id;
                        if (dto.Goal_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IGoalCAD goalCAD = new MoSIoTGenNHibernate.CAD.MosIoT.GoalCAD ();

                                newinstance.Goal = goalCAD.ReadOIDDefault (dto.Goal_oid);
                        }
                        newinstance.DesiredValue = dto.DesiredValue;
                        if (dto.Measure_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IMeasureCAD measureCAD = new MoSIoTGenNHibernate.CAD.MosIoT.MeasureCAD ();

                                newinstance.Measure = measureCAD.ReadOIDDefault (dto.Measure_oid);
                        }
                        newinstance.Description = dto.Description;
                        newinstance.DueDate = dto.DueDate;
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
