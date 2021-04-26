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
public static class CarePlanAssembler
{
public static CarePlanDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        CarePlanDTOA dto = null;
        CarePlanRESTCAD carePlanRESTCAD = null;
        CarePlanCEN carePlanCEN = null;
        CarePlanCP carePlanCP = null;

        if (en != null) {
                dto = new CarePlanDTOA ();
                carePlanRESTCAD = new CarePlanRESTCAD (session);
                carePlanCEN = new CarePlanCEN (carePlanRESTCAD);
                carePlanCP = new CarePlanCP (session);


                CarePlanEN enHijo = carePlanRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: CarePlan o--> CarePlanTemplate */
                dto.CarePlanTemplate = CarePlanTemplateAssembler.Convert ((CarePlanTemplateEN)enHijo.Template, session);


                //
                // Service
        }

        return dto;
}
}
}
