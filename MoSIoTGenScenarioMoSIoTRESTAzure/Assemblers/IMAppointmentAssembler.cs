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
public static class IMAppointmentAssembler
{
public static IMAppointmentDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMAppointmentDTOA dto = null;
        IMAppointmentRESTCAD iMAppointmentRESTCAD = null;
        IMAppointmentCEN iMAppointmentCEN = null;
        IMAppointmentCP iMAppointmentCP = null;

        if (en != null) {
                dto = new IMAppointmentDTOA ();
                iMAppointmentRESTCAD = new IMAppointmentRESTCAD (session);
                iMAppointmentCEN = new IMAppointmentCEN (iMAppointmentRESTCAD);
                iMAppointmentCP = new IMAppointmentCP (session);


                IMAppointmentEN enHijo = iMAppointmentRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                if (enHijo != null)
                        dto.Date = enHijo.Date;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: IMAppointment o--> Appointment */
                dto.ValueAppointment = AppointmentAssembler.Convert ((AppointmentEN)enHijo.Appointment, session);


                //
                // Service
        }

        return dto;
}
}
}
