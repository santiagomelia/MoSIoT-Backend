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
public static class PatientProfileAssembler
{
public static PatientProfileDTOA Convert (PatientProfileEN en, NHibernate.ISession session = null)
{
        PatientProfileDTOA dto = null;
        PatientProfileRESTCAD patientProfileRESTCAD = null;
        PatientProfileCEN patientProfileCEN = null;
        PatientProfileCP patientProfileCP = null;

        if (en != null) {
                dto = new PatientProfileDTOA ();
                patientProfileRESTCAD = new PatientProfileRESTCAD (session);
                patientProfileCEN = new PatientProfileCEN (patientProfileRESTCAD);
                patientProfileCP = new PatientProfileCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.PreferredLanguage = en.PreferredLanguage;


                dto.Region = en.Region;


                dto.HazardAvoidance = en.HazardAvoidance;


                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: PatientProfile o--> AccessMode */
                dto.AccessMode = null;
                List<AccessModeEN> AccessMode = patientProfileRESTCAD.AccessMode (en.Id).ToList ();
                if (AccessMode != null) {
                        dto.AccessMode = new List<AccessModeDTOA>();
                        foreach (AccessModeEN entry in AccessMode)
                                dto.AccessMode.Add (AccessModeAssembler.Convert (entry, session));
                }

                /* Rol: PatientProfile o--> Condition */
                dto.Condition = null;
                List<ConditionEN> Condition = patientProfileRESTCAD.Condition (en.Id).ToList ();
                if (Condition != null) {
                        dto.Condition = new List<ConditionDTOA>();
                        foreach (ConditionEN entry in Condition)
                                dto.Condition.Add (ConditionAssembler.Convert (entry, session));
                }

                /* Rol: PatientProfile o--> Disability */
                dto.Disabilities = null;
                List<DisabilityEN> Disabilities = patientProfileRESTCAD.Disabilities (en.Id).ToList ();
                if (Disabilities != null) {
                        dto.Disabilities = new List<DisabilityDTOA>();
                        foreach (DisabilityEN entry in Disabilities)
                                dto.Disabilities.Add (DisabilityAssembler.Convert (entry, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
