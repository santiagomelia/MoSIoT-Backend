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
public static class AdaptationTypeRequiredAssembler
{
public static AdaptationTypeRequiredDTOA Convert (AdaptationTypeRequiredEN en, NHibernate.ISession session = null)
{
        AdaptationTypeRequiredDTOA dto = null;
        AdaptationTypeRequiredRESTCAD adaptationTypeRequiredRESTCAD = null;
        AdaptationTypeRequiredCEN adaptationTypeRequiredCEN = null;
        AdaptationTypeRequiredCP adaptationTypeRequiredCP = null;

        if (en != null) {
                dto = new AdaptationTypeRequiredDTOA ();
                adaptationTypeRequiredRESTCAD = new AdaptationTypeRequiredRESTCAD (session);
                adaptationTypeRequiredCEN = new AdaptationTypeRequiredCEN (adaptationTypeRequiredRESTCAD);
                adaptationTypeRequiredCP = new AdaptationTypeRequiredCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.AdaptionRequest = en.AdaptionRequest;


                dto.Description = en.Description;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
