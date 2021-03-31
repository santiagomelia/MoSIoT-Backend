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
public static class PatientProfileCareAssembler
{
public static PatientProfileCareDTOA Convert (PatientProfileEN en, NHibernate.ISession session = null)
{
        PatientProfileCareDTOA dto = null;
        PatientProfileCareRESTCAD patientProfileCareRESTCAD = null;
        PatientProfileCEN patientProfileCEN = null;
        PatientProfileCP patientProfileCP = null;

        if (en != null) {
                dto = new PatientProfileCareDTOA ();
                patientProfileCareRESTCAD = new PatientProfileCareRESTCAD (session);
                patientProfileCEN = new PatientProfileCEN (patientProfileCareRESTCAD);
                patientProfileCP = new PatientProfileCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.PreferredLanguage = en.PreferredLanguage;


                dto.Region = en.Region;


                dto.HazardAvoidance = en.HazardAvoidance;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
