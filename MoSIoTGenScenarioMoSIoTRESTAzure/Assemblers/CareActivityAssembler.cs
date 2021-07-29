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

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.Periodicity = en.Periodicity;


                dto.Duration = en.Duration;


                dto.Location = en.Location;


                dto.OutcomeCode = en.OutcomeCode;


                dto.TypeActivity = en.TypeActivity;


                dto.ActivityCode = en.ActivityCode;


                //
                // TravesalLink

                /* Rol: CareActivity o--> Comunication */
                dto.Comunications = null;
                List<ComunicationEN> Comunications = careActivityRESTCAD.Comunications (en.Id).ToList ();
                if (Comunications != null) {
                        dto.Comunications = new List<ComunicationDTOA>();
                        foreach (ComunicationEN entry in Comunications)
                                dto.Comunications.Add (ComunicationAssembler.Convert (entry, session));
                }

                /* Rol: CareActivity o--> Appointment */
                dto.Appointments = AppointmentAssembler.Convert ((AppointmentEN)en.Appointment, session);

                /* Rol: CareActivity o--> Medication */
                dto.Medications = MedicationAssembler.Convert ((MedicationEN)en.Medication, session);

                /* Rol: CareActivity o--> NutritionOrder */
                dto.NutritionOrders = NutritionOrderAssembler.Convert ((NutritionOrderEN)en.NutritionOrder, session);


                //
                // Service
        }

        return dto;
}
}
}
