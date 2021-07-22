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
public static class IMCareActivityAssembler
{
public static IMCareActivityDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        IMCareActivityDTOA dto = null;
        IMCareActivityRESTCAD iMCareActivityRESTCAD = null;
        IMCareActivityCEN iMCareActivityCEN = null;
        IMCareActivityCP iMCareActivityCP = null;

        if (en != null) {
                dto = new IMCareActivityDTOA ();
                iMCareActivityRESTCAD = new IMCareActivityRESTCAD (session);
                iMCareActivityCEN = new IMCareActivityCEN (iMCareActivityRESTCAD);
                iMCareActivityCP = new IMCareActivityCP (session);


                IMCareActivityEN enHijo = iMCareActivityRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: IMCareActivity o--> CareActivity */
                dto.ValueCareActivity = CareActivityAssembler.Convert ((CareActivityEN)enHijo.CareActivity, session);


                //
                // Service
        }

        return dto;
}
}
}
