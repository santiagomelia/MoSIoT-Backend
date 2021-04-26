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
public static class RelatedPersonAssembler
{
public static RelatedPersonDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        RelatedPersonDTOA dto = null;
        RelatedPersonRESTCAD relatedPersonRESTCAD = null;
        RelatedPersonCEN relatedPersonCEN = null;
        RelatedPersonCP relatedPersonCP = null;

        if (en != null) {
                dto = new RelatedPersonDTOA ();
                relatedPersonRESTCAD = new RelatedPersonRESTCAD (session);
                relatedPersonCEN = new RelatedPersonCEN (relatedPersonRESTCAD);
                relatedPersonCP = new RelatedPersonCP (session);


                RelatedPersonEN enHijo = relatedPersonRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: RelatedPerson o--> User */
                dto.RpData = UserAssembler.Convert ((UserEN)enHijo.UserRelatedPerson, session);


                //
                // Service
        }

        return dto;
}
}
}
