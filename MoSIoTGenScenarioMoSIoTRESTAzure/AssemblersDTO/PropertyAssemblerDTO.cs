using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class PropertyAssemblerDTO {
public static IList<PropertyEN> ConvertList (IList<PropertyDTO> lista)
{
        IList<PropertyEN> result = new List<PropertyEN>();
        foreach (PropertyDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static PropertyEN Convert (PropertyDTO dto)
{
        PropertyEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new PropertyEN ();



                        if (dto.DeviceTemplate_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IDeviceTemplateCAD deviceTemplateCAD = new MoSIoTGenNHibernate.CAD.MosIoT.DeviceTemplateCAD ();

                                newinstance.DeviceTemplate = deviceTemplateCAD.ReadOIDDefault (dto.DeviceTemplate_oid);
                        }
                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        newinstance.IsWritable = dto.IsWritable;
                        newinstance.IsCloudable = dto.IsCloudable;
                        if (dto.Telemetry_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ITelemetryCAD telemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.TelemetryCAD ();

                                newinstance.Telemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN>();
                                foreach (int entry in dto.Telemetry_oid) {
                                        newinstance.Telemetry.Add (telemetryCAD.ReadOIDDefault (entry));
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
