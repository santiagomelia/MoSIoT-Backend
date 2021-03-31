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
public static class CarePlanAssembler
{
public static CarePlanDTOA Convert (CarePlanEN en, NHibernate.ISession session = null)
{
        CarePlanDTOA dto = null;
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanCEN carePlanCEN = null;
        CarePlanCP carePlanCP = null;

        if (en != null) {
                dto = new CarePlanDTOA ();
                carePlanRESTCAD = new CarePlanRESTCAD (session);
                carePlanCEN = new CarePlanCEN (carePlanRESTCAD);
                carePlanCP = new CarePlanCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.StartDate = en.StartDate;


                dto.EndDate = en.EndDate;


                dto.Status = en.Status;


                dto.Intent = en.Intent;


                dto.Title = en.Title;


                dto.Modified = en.Modified;


                //
                // TravesalLink

                /* Rol: CarePlan o--> CareActivity */
                dto.CareActivities = null;
                List<CareActivityEN> CareActivities = carePlanRESTCAD.CareActivities (en.Id).ToList ();
                if (CareActivities != null) {
                        dto.CareActivities = new List<CareActivityDTOA>();
                        foreach (CareActivityEN entry in CareActivities)
                                dto.CareActivities.Add (CareActivityAssembler.Convert (entry, session));
                }

                /* Rol: CarePlan o--> VitalSign */
                dto.VitalSigns = null;
                List<VitalSignEN> VitalSigns = carePlanRESTCAD.VitalSigns (en.Id).ToList ();
                if (VitalSigns != null) {
                        dto.VitalSigns = new List<VitalSignDTOA>();
                        foreach (VitalSignEN entry in VitalSigns)
                                dto.VitalSigns.Add (VitalSignAssembler.Convert (entry, session));
                }

                /* Rol: CarePlan o--> Goal */
                dto.Goals = null;
                List<GoalEN> Goals = carePlanRESTCAD.Goals (en.Id).ToList ();
                if (Goals != null) {
                        dto.Goals = new List<GoalDTOA>();
                        foreach (GoalEN entry in Goals)
                                dto.Goals.Add (GoalAssembler.Convert (entry, session));
                }

                /* Rol: CarePlan o--> PatientProfileCare */
                dto.Patient = PatientProfileCareAssembler.Convert ((PatientProfileEN)en.PatientProfile, session);


                //
                // Service
        }

        return dto;
}
}
}
