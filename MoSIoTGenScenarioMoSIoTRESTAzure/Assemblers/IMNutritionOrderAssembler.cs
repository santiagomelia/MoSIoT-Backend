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
public static class IMNutritionOrderAssembler
{
public static IMNutritionOrderDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMNutritionOrderDTOA dto = null;
        IMNutritionOrderRESTCAD iMNutritionOrderRESTCAD = null;
        IMNutritionOrderCEN iMNutritionOrderCEN = null;
        IMNutritionOrderCP iMNutritionOrderCP = null;

        if (en != null) {
                dto = new IMNutritionOrderDTOA ();
                iMNutritionOrderRESTCAD = new IMNutritionOrderRESTCAD (session);
                iMNutritionOrderCEN = new IMNutritionOrderCEN (iMNutritionOrderRESTCAD);
                iMNutritionOrderCP = new IMNutritionOrderCP (session);


                IMNutritionOrderEN enHijo = iMNutritionOrderRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.Value = en.Value;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
