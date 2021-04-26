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
public static class AppointmentAssembler
{
public static AppointmentDTOA Convert (AppointmentEN en, NHibernate.ISession session = null)
{
        AppointmentDTOA dto = null;
        AppointmentRESTCAD appointmentRESTCAD = null;
        AppointmentCEN appointmentCEN = null;
        AppointmentCP appointmentCP = null;

        if (en != null) {
                dto = new AppointmentDTOA ();
                appointmentRESTCAD = new AppointmentRESTCAD (session);
                appointmentCEN = new AppointmentCEN (appointmentRESTCAD);
                appointmentCP = new AppointmentCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.IsVirtual = en.IsVirtual;


                dto.Description = en.Description;


                dto.Direction = en.Direction;


                dto.ReasonCode = en.ReasonCode;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
