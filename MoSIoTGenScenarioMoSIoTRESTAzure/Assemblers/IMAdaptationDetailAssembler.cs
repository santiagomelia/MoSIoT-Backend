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
public static class IMAdaptationDetailAssembler
{
public static IMAdaptationDetailDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMAdaptationDetailDTOA dto = null;
        IMAdaptationDetailRESTCAD iMAdaptationDetailRESTCAD = null;
        IMAdaptationDetailCEN iMAdaptationDetailCEN = null;
        IMAdaptationDetailCP iMAdaptationDetailCP = null;

        if (en != null) {
                dto = new IMAdaptationDetailDTOA ();
                iMAdaptationDetailRESTCAD = new IMAdaptationDetailRESTCAD (session);
                iMAdaptationDetailCEN = new IMAdaptationDetailCEN (iMAdaptationDetailRESTCAD);
                iMAdaptationDetailCP = new IMAdaptationDetailCP (session);


                IMAdaptationDetailEN enHijo = iMAdaptationDetailRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: IMAdaptationDetail o--> AdaptationDetailRequired */
                dto.ValueAdaptionDetail = AdaptationDetailRequiredAssembler.Convert ((AdaptationDetailRequiredEN)enHijo.AdaptationDetailRequired, session);


                //
                // Service
        }

        return dto;
}
}
}
