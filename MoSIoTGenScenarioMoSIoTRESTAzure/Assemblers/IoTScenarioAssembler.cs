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
public static class IoTScenarioAssembler
{
public static IoTScenarioDTOA Convert (IoTScenarioEN en, NHibernate.ISession session = null)
{
        IoTScenarioDTOA dto = null;
        IoTScenarioRESTCAD ioTScenarioRESTCAD = null;
        IoTScenarioCEN ioTScenarioCEN = null;
        IoTScenarioCP ioTScenarioCP = null;

        if (en != null) {
                dto = new IoTScenarioDTOA ();
                ioTScenarioRESTCAD = new IoTScenarioRESTCAD (session);
                ioTScenarioCEN = new IoTScenarioCEN (ioTScenarioRESTCAD);
                ioTScenarioCP = new IoTScenarioCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
