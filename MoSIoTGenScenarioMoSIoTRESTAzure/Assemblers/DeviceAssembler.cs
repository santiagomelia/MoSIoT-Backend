using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using MoSIoTGenScenarioMoSIoTRESTAzure.DTOA;
using MoSIoTGenScenarioMoSIoTRESTAzure.CAD;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.Assemblers
{
public static class DeviceAssembler
{
public static DeviceDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        DeviceDTOA dto = null;
        DeviceRESTCAD deviceRESTCAD = null;
        DeviceCEN deviceCEN = null;
        DeviceCP deviceCP = null;

        if (en != null) {
                dto = new DeviceDTOA ();
                deviceRESTCAD = new DeviceRESTCAD (session);
                deviceCEN = new DeviceCEN (deviceRESTCAD);
                deviceCP = new DeviceCP (session);


                DeviceEN enHijo = deviceRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                if (enHijo != null)
                        dto.DeviceSwitch = enHijo.DeviceSwitch;


                if (enHijo != null)
                        dto.Tag = enHijo.Tag;


                if (enHijo != null)
                        dto.IsSimulated = enHijo.IsSimulated;


                if (enHijo != null)
                        dto.SerialNumber = enHijo.SerialNumber;


                if (enHijo != null)
                        dto.FirmVersion = enHijo.FirmVersion;


                if (enHijo != null)
                        dto.Trademark = enHijo.Trademark;


                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: Device o--> DeviceTemplate */
                dto.DeviceTemplate = DeviceTemplateAssembler.Convert ((DeviceTemplateEN)enHijo.DeviceTemplate, session);


                //
                // Service
        }

        return dto;
}
}
}
