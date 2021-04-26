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
