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
public static class IMAdaptationRequestAssembler
{
public static IMAdaptationRequestDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMAdaptationRequestDTOA dto = null;
        IMAdaptationRequestRESTCAD iMAdaptationRequestRESTCAD = null;
        IMAdaptationRequestCEN iMAdaptationRequestCEN = null;
        IMAdaptationRequestCP iMAdaptationRequestCP = null;

        if (en != null) {
                dto = new IMAdaptationRequestDTOA ();
                iMAdaptationRequestRESTCAD = new IMAdaptationRequestRESTCAD (session);
                iMAdaptationRequestCEN = new IMAdaptationRequestCEN (iMAdaptationRequestRESTCAD);
                iMAdaptationRequestCP = new IMAdaptationRequestCP (session);


                IMAdaptationRequestEN enHijo = iMAdaptationRequestRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: IMAdaptationRequest o--> AdaptationRequest */
                dto.ValueAdaption = AdaptationRequestAssembler.Convert ((AdaptationRequestEN)enHijo.AdaptationRequest, session);


                //
                // Service
        }

        return dto;
}
}
}
