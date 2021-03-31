using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class TelemetryAssemblerDTO {
public static IList<TelemetryEN> ConvertList (IList<TelemetryDTO> lista)
{
        IList<TelemetryEN> result = new List<TelemetryEN>();
        foreach (TelemetryDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static TelemetryEN Convert (TelemetryDTO dto)
{
        TelemetryEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new TelemetryEN ();



                        if (dto.DeviceTemplate_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IDeviceTemplateCAD deviceTemplateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.DeviceTemplateCAD ();

                                newinstance.DeviceTemplate = deviceTemplateCAD.ReadOIDDefault (dto.DeviceTemplate_oid);
                        }
                        newinstance.Frecuency = dto.Frecuency;
                        if (dto.TypeTelemetry_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ISpecificTelemetryCAD specificTelemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.SpecificTelemetryCAD ();

                                newinstance.TypeTelemetry = specificTelemetryCAD.ReadOIDDefault (dto.TypeTelemetry_oid);
                        }
                        newinstance.Schema = dto.Schema;
                        newinstance.Unit = dto.Unit;
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.Type = dto.Type;
                        if (dto.Properties_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IPropertyCAD propertyCAD = new MoSIoTGenNHibernate.CAD.MosIoT.PropertyCAD ();

                                newinstance.Properties = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN>();
                                foreach (int entry in dto.Properties_oid) {
                                        newinstance.Properties.Add (propertyCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.VitalSign_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IMeasureCAD measureCAD = new MoSIoTGenNHibernate.CAD.MosIoT.MeasureCAD ();

                                newinstance.VitalSign = measureCAD.ReadOIDDefault (dto.VitalSign_oid);
                        }
                        if (dto.IMTelemetry_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IIMTelemetryCAD iMTelemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.IMTelemetryCAD ();

                                newinstance.IMTelemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN>();
                                foreach (int entry in dto.IMTelemetry_oid) {
                                        newinstance.IMTelemetry.Add (iMTelemetryCAD.ReadOIDDefault (entry));
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
