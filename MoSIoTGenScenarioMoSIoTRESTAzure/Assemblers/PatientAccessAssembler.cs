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
public static class PatientAccessAssembler
{
public static PatientAccessDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        PatientAccessDTOA dto = null;
        PatientAccessRESTCAD patientAccessRESTCAD = null;
        PatientAccessCEN patientAccessCEN = null;
        PatientAccessCP patientAccessCP = null;

        if (en != null) {
                dto = new PatientAccessDTOA ();
                patientAccessRESTCAD = new PatientAccessRESTCAD (session);
                patientAccessCEN = new PatientAccessCEN (patientAccessRESTCAD);
                patientAccessCP = new PatientAccessCP (session);


                PatientAccessEN enHijo = patientAccessRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: PatientAccess o--> AccessMode */
                dto.AccessMode = AccessModeAssembler.Convert ((AccessModeEN)enHijo.AccessMode, session);


                //
                // Service
        }

        return dto;
}
}
}
