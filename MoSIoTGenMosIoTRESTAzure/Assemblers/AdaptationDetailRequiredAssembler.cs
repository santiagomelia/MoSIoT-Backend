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
public static class AdaptationDetailRequiredAssembler
{
public static AdaptationDetailRequiredDTOA Convert (AdaptationDetailRequiredEN en, NHibernate.ISession session = null)
{
        AdaptationDetailRequiredDTOA dto = null;
        AdaptationDetailRequiredRESTCAD adaptationDetailRequiredRESTCAD = null;
        AdaptationDetailRequiredCEN adaptationDetailRequiredCEN = null;
        AdaptationDetailRequiredCP adaptationDetailRequiredCP = null;

        if (en != null) {
                dto = new AdaptationDetailRequiredDTOA ();
                adaptationDetailRequiredRESTCAD = new AdaptationDetailRequiredRESTCAD (session);
                adaptationDetailRequiredCEN = new AdaptationDetailRequiredCEN (adaptationDetailRequiredRESTCAD);
                adaptationDetailRequiredCP = new AdaptationDetailRequiredCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.AdaptationRequest = en.AdaptationRequest;


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
