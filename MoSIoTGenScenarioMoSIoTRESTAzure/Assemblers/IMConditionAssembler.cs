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
public static class IMConditionAssembler
{
public static IMConditionDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMConditionDTOA dto = null;
        IMConditionRESTCAD iMConditionRESTCAD = null;
        IMConditionCEN iMConditionCEN = null;
        IMConditionCP iMConditionCP = null;

        if (en != null) {
                dto = new IMConditionDTOA ();
                iMConditionRESTCAD = new IMConditionRESTCAD (session);
                iMConditionCEN = new IMConditionCEN (iMConditionRESTCAD);
                iMConditionCP = new IMConditionCP (session);


                IMConditionEN enHijo = iMConditionRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: IMCondition o--> Condition */
                dto.ValueCondition = ConditionAssembler.Convert ((ConditionEN)enHijo.Condition, session);


                //
                // Service
        }

        return dto;
}
}
}
