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
public static class PractitionerAssembler
{
public static PractitionerDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        PractitionerDTOA dto = null;
        PractitionerRESTCAD practitionerRESTCAD = null;
        PractitionerCEN practitionerCEN = null;
        PractitionerCP practitionerCP = null;

        if (en != null) {
                dto = new PractitionerDTOA ();
                practitionerRESTCAD = new PractitionerRESTCAD (session);
                practitionerCEN = new PractitionerCEN (practitionerRESTCAD);
                practitionerCP = new PractitionerCP (session);


                PractitionerEN enHijo = practitionerRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: Practitioner o--> User */
                dto.PractitionerData = UserAssembler.Convert ((UserEN)enHijo.UserPractitioner, session);


                //
                // Service
        }

        return dto;
}
}
}
