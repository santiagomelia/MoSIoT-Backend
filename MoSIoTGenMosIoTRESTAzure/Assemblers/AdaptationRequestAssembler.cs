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
public static class AdaptationRequestAssembler
{
public static AdaptationRequestDTOA Convert (AdaptationRequestEN en, NHibernate.ISession session = null)
{
        AdaptationRequestDTOA dto = null;
        AdaptationRequestRESTCAD adaptationRequestRESTCAD = null;
        AdaptationRequestCEN adaptationRequestCEN = null;
        AdaptationRequestCP adaptationRequestCP = null;

        if (en != null) {
                dto = new AdaptationRequestDTOA ();
                adaptationRequestRESTCAD = new AdaptationRequestRESTCAD (session);
                adaptationRequestCEN = new AdaptationRequestCEN (adaptationRequestRESTCAD);
                adaptationRequestCP = new AdaptationRequestCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.AccessModeTarget = en.AccessModeTarget;


                dto.LanguageOfAdaptation = en.LanguageOfAdaptation;


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
