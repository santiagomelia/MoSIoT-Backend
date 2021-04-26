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
public static class Condition_CarePlanAssembler
{
public static Condition_CarePlanDTOA Convert (ConditionEN en, NHibernate.ISession session = null)
{
        Condition_CarePlanDTOA dto = null;
        Condition_CarePlanRESTCAD condition_CarePlanRESTCAD = null;
        ConditionCEN conditionCEN = null;
        ConditionCP conditionCP = null;

        if (en != null) {
                dto = new Condition_CarePlanDTOA ();
                condition_CarePlanRESTCAD = new Condition_CarePlanRESTCAD (session);
                conditionCEN = new ConditionCEN (condition_CarePlanRESTCAD);
                conditionCP = new ConditionCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Description = en.Description;


                dto.ClinicalStatus = en.ClinicalStatus;


                dto.Disease = en.Disease;


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
