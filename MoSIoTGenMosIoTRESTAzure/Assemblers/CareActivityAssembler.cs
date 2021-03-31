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
public static class CareActivityAssembler
{
public static CareActivityDTOA Convert (CareActivityEN en, NHibernate.ISession session = null)
{
        CareActivityDTOA dto = null;
        CareActivityRESTCAD careActivityRESTCAD = null;
        CareActivityCEN careActivityCEN = null;
        CareActivityCP careActivityCP = null;

        if (en != null) {
                dto = new CareActivityDTOA ();
                careActivityRESTCAD = new CareActivityRESTCAD (session);
                careActivityCEN = new CareActivityCEN (careActivityRESTCAD);
                careActivityCP = new CareActivityCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Periodicity = en.Periodicity;


                dto.Description = en.Description;


                dto.Duration = en.Duration;


                dto.Location = en.Location;


                //
                // TravesalLink

                /* Rol: CareActivity o--> Medication */
                dto.Medications = MedicationAssembler.Convert ((MedicationEN)en.Medication, session);

                /* GetAll: Appointment */
                dto.Appointments = null;
                List<AppointmentEN> appointments_list = new AppointmentCAD (session).ReadAllDefault (0, -1).ToList ();
                if (appointments_list != null) {
                        dto.Appointments = new List<AppointmentDTOA>();
                        foreach (AppointmentEN entry in appointments_list)
                                dto.Appointments.Add (AppointmentAssembler.Convert (entry, session));
                }

                /* Rol: CareActivity o--> NutritionOrder */
                dto.NutritionOrders = NutritionOrderAssembler.Convert ((NutritionOrderEN)en.NutritionOrder, session);


                //
                // Service
        }

        return dto;
}
}
}
