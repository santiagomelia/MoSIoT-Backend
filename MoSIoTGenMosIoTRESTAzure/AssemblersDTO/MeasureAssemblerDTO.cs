using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class MeasureAssemblerDTO {
public static IList<MeasureEN> ConvertList (IList<MeasureDTO> lista)
{
        IList<MeasureEN> result = new List<MeasureEN>();
        foreach (MeasureDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static MeasureEN Convert (MeasureDTO dto)
{
        MeasureEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new MeasureEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Description = dto.Description;
                        if (dto.Target_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ITargetCAD targetCAD = new MoSIoTGenNHibernate.CAD.MosIoT.TargetCAD ();

                                newinstance.Target = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TargetEN>();
                                foreach (int entry in dto.Target_oid) {
                                        newinstance.Target.Add (targetCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.Telemetry_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ITelemetryCAD telemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.TelemetryCAD ();

                                newinstance.Telemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN>();
                                foreach (int entry in dto.Telemetry_oid) {
                                        newinstance.Telemetry.Add (telemetryCAD.ReadOIDDefault (entry));
                                }
                        }
                        newinstance.LOINCcode = dto.LOINCcode;
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
