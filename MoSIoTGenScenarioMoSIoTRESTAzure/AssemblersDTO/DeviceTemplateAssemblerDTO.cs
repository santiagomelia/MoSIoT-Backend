using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenScenarioMoSIoTRESTAzure.DTO;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.AssemblersDTO
{
public class DeviceTemplateAssemblerDTO {
public static IList<DeviceTemplateEN> ConvertList (IList<DeviceTemplateDTO> lista)
{
        IList<DeviceTemplateEN> result = new List<DeviceTemplateEN>();
        foreach (DeviceTemplateDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static DeviceTemplateEN Convert (DeviceTemplateDTO dto)
{
        DeviceTemplateEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new DeviceTemplateEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;

                        if (dto.Property != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IPropertyCAD propertyCAD = new MoSIoTGenNHibernate.CAD.MosIoT.PropertyCAD ();

                                newinstance.Property = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN>();
                                foreach (PropertyDTO entry in dto.Property) {
                                        newinstance.Property.Add (PropertyAssemblerDTO.Convert (entry));
                                }
                        }

                        if (dto.Command != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICommandCAD commandCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CommandCAD ();

                                newinstance.Command = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.CommandEN>();
                                foreach (CommandDTO entry in dto.Command) {
                                        newinstance.Command.Add (CommandAssemblerDTO.Convert (entry));
                                }
                        }

                        if (dto.Telemetry != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ITelemetryCAD telemetryCAD = new MoSIoTGenNHibernate.CAD.MosIoT.TelemetryCAD ();

                                newinstance.Telemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN>();
                                foreach (TelemetryDTO entry in dto.Telemetry) {
                                        newinstance.Telemetry.Add (TelemetryAssemblerDTO.Convert (entry));
                                }
                        }
                        newinstance.Type = dto.Type;
                        newinstance.IsEdge = dto.IsEdge;
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
