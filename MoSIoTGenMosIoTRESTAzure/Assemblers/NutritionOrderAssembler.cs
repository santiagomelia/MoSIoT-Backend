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
public static class NutritionOrderAssembler
{
public static NutritionOrderDTOA Convert (NutritionOrderEN en, NHibernate.ISession session = null)
{
        NutritionOrderDTOA dto = null;
        NutritionOrderRESTCAD nutritionOrderRESTCAD = null;
        NutritionOrderCEN nutritionOrderCEN = null;
        NutritionOrderCP nutritionOrderCP = null;

        if (en != null) {
                dto = new NutritionOrderDTOA ();
                nutritionOrderRESTCAD = new NutritionOrderRESTCAD (session);
                nutritionOrderCEN = new NutritionOrderCEN (nutritionOrderRESTCAD);
                nutritionOrderCP = new NutritionOrderCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Description = en.Description;


                dto.DietCode = en.DietCode;


                dto.Name = en.Name;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
