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
public static class CarePlanTemplateAssembler
{
public static CarePlanTemplateDTOA Convert (CarePlanTemplateEN en, NHibernate.ISession session = null)
{
        CarePlanTemplateDTOA dto = null;
        CarePlanTemplateRESTCAD carePlanTemplateRESTCAD = null;
        CarePlanTemplateCEN carePlanTemplateCEN = null;
        CarePlanTemplateCP carePlanTemplateCP = null;

        if (en != null) {
                dto = new CarePlanTemplateDTOA ();
                carePlanTemplateRESTCAD = new CarePlanTemplateRESTCAD (session);
                carePlanTemplateCEN = new CarePlanTemplateCEN (carePlanTemplateRESTCAD);
                carePlanTemplateCP = new CarePlanTemplateCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Status = en.Status;


                dto.Intent = en.Intent;


                dto.Title = en.Title;


                dto.Modified = en.Modified;


                //
                // TravesalLink

                /* Rol: CarePlanTemplate o--> CareActivity */
                dto.CareActivities = null;
                List<CareActivityEN> CareActivities = carePlanTemplateRESTCAD.CareActivities (en.Id).ToList ();
                if (CareActivities != null) {
                        dto.CareActivities = new List<CareActivityDTOA>();
                        foreach (CareActivityEN entry in CareActivities)
                                dto.CareActivities.Add (CareActivityAssembler.Convert (entry, session));
                }

                /* Rol: CarePlanTemplate o--> Goal */
                dto.Goals = null;
                List<GoalEN> Goals = carePlanTemplateRESTCAD.Goals (en.Id).ToList ();
                if (Goals != null) {
                        dto.Goals = new List<GoalDTOA>();
                        foreach (GoalEN entry in Goals)
                                dto.Goals.Add (GoalAssembler.Convert (entry, session));
                }

                /* Rol: CarePlanTemplate o--> PatientProfileCare */
                dto.Patient = PatientProfileCareAssembler.Convert ((PatientProfileEN)en.PatientProfile, session);


                //
                // Service
        }

        return dto;
}
}
}
