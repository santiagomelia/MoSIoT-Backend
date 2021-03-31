using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using MoSIoTGenMosIoTRESTAzure.DTOA;
using MoSIoTGenMosIoTRESTAzure.CAD;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.Assemblers
{
public static class DeviceTemplateAssembler
{
public static DeviceTemplateDTOA Convert (DeviceTemplateEN en, NHibernate.ISession session = null)
{
        DeviceTemplateDTOA dto = null;
        DeviceTemplateRESTCAD deviceTemplateRESTCAD = null;
        DeviceTemplateCEN deviceTemplateCEN = null;
        DeviceTemplateCP deviceTemplateCP = null;

        if (en != null) {
                dto = new DeviceTemplateDTOA ();
                deviceTemplateRESTCAD = new DeviceTemplateRESTCAD (session);
                deviceTemplateCEN = new DeviceTemplateCEN (deviceTemplateRESTCAD);
                deviceTemplateCP = new DeviceTemplateCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Type = en.Type;


                dto.IsEdge = en.IsEdge;


                //
                // TravesalLink

                /* Rol: DeviceTemplate o--> Property */
                dto.Properties = null;
                List<PropertyEN> Properties = deviceTemplateRESTCAD.Properties (en.Id).ToList ();
                if (Properties != null) {
                        dto.Properties = new List<PropertyDTOA>();
                        foreach (PropertyEN entry in Properties)
                                dto.Properties.Add (PropertyAssembler.Convert (entry, session));
                }

                /* Rol: DeviceTemplate o--> Command */
                dto.Commands = null;
                List<CommandEN> Commands = deviceTemplateRESTCAD.Commands (en.Id).ToList ();
                if (Commands != null) {
                        dto.Commands = new List<CommandDTOA>();
                        foreach (CommandEN entry in Commands)
                                dto.Commands.Add (CommandAssembler.Convert (entry, session));
                }

                /* Rol: DeviceTemplate o--> Telemetry */
                dto.Telemetries = null;
                List<TelemetryEN> Telemetries = deviceTemplateRESTCAD.Telemetries (en.Id).ToList ();
                if (Telemetries != null) {
                        dto.Telemetries = new List<TelemetryDTOA>();
                        foreach (TelemetryEN entry in Telemetries)
                                dto.Telemetries.Add (TelemetryAssembler.Convert (entry, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
