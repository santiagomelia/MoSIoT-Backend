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
public static class ConditionAssembler
{
public static ConditionDTOA Convert (ConditionEN en, NHibernate.ISession session = null)
{
        ConditionDTOA dto = null;
        ConditionRESTCAD conditionRESTCAD = null;
        ConditionCEN conditionCEN = null;
        ConditionCP conditionCP = null;

        if (en != null) {
                dto = new ConditionDTOA ();
                conditionRESTCAD = new ConditionRESTCAD (session);
                conditionCEN = new ConditionCEN (conditionRESTCAD);
                conditionCP = new ConditionCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Disease = en.Disease;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
