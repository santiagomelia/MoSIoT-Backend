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
public static class IMAdaptationTypeAssembler
{
public static IMAdaptationTypeDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMAdaptationTypeDTOA dto = null;
        IMAdaptationTypeRESTCAD iMAdaptationTypeRESTCAD = null;
        IMAdaptationTypeCEN iMAdaptationTypeCEN = null;
        IMAdaptationTypeCP iMAdaptationTypeCP = null;

        if (en != null) {
                dto = new IMAdaptationTypeDTOA ();
                iMAdaptationTypeRESTCAD = new IMAdaptationTypeRESTCAD (session);
                iMAdaptationTypeCEN = new IMAdaptationTypeCEN (iMAdaptationTypeRESTCAD);
                iMAdaptationTypeCP = new IMAdaptationTypeCP (session);


                IMAdaptationTypeEN enHijo = iMAdaptationTypeRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: IMAdaptationType o--> AdaptationTypeRequired */
                dto.ValueAdaptionType = AdaptationTypeRequiredAssembler.Convert ((AdaptationTypeRequiredEN)enHijo.AdaptationTypeRequired, session);


                //
                // Service
        }

        return dto;
}
}
}
