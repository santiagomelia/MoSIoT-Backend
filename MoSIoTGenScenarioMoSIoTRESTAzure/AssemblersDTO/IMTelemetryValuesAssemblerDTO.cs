using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class IMTelemetryValuesAssemblerDTO {
public static IList<IMTelemetryValuesEN> ConvertList (IList<IMTelemetryValuesDTO> lista)
{
        IList<IMTelemetryValuesEN> result = new List<IMTelemetryValuesEN>();
        foreach (IMTelemetryValuesDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static IMTelemetryValuesEN Convert (IMTelemetryValuesDTO dto)
{
        IMTelemetryValuesEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new IMTelemetryValuesEN ();



                        newinstance.Id = dto.Id;
                        newinstance.TimeStamp = dto.TimeStamp;
                        newinstance.Valu = dto.Valu;
                        if (dto.IMTelemetry_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IIMTelemetryCAD iMTelemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.IMTelemetryCAD ();

                                newinstance.IMTelemetry = iMTelemetryCAD.ReadOIDDefault (dto.IMTelemetry_oid);
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
