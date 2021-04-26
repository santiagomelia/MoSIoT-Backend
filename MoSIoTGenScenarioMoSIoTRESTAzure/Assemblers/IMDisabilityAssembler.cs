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
public static class IMDisabilityAssembler
{
public static IMDisabilityDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMDisabilityDTOA dto = null;
        IMDisabilityRESTCAD iMDisabilityRESTCAD = null;
        IMDisabilityCEN iMDisabilityCEN = null;
        IMDisabilityCP iMDisabilityCP = null;

        if (en != null) {
                dto = new IMDisabilityDTOA ();
                iMDisabilityRESTCAD = new IMDisabilityRESTCAD (session);
                iMDisabilityCEN = new IMDisabilityCEN (iMDisabilityRESTCAD);
                iMDisabilityCP = new IMDisabilityCP (session);


                IMDisabilityEN enHijo = iMDisabilityRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: IMDisability o--> Disability */
                dto.ValueDisability = DisabilityAssembler.Convert ((DisabilityEN)enHijo.Disability, session);


                //
                // Service
        }

        return dto;
}
}
}
