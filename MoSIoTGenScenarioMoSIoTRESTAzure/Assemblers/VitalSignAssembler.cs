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
public static class VitalSignAssembler
{
public static VitalSignDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        VitalSignDTOA dto = null;
        VitalSignRESTCAD vitalSignRESTCAD = null;
        VitalSignCEN vitalSignCEN = null;
        VitalSignCP vitalSignCP = null;

        if (en != null) {
                dto = new VitalSignDTOA ();
                vitalSignRESTCAD = new VitalSignRESTCAD (session);
                vitalSignCEN = new VitalSignCEN (vitalSignRESTCAD);
                vitalSignCP = new VitalSignCP (session);


                VitalSignEN enHijo = vitalSignRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: VitalSign o--> Measure */
                dto.MeasureVitalSign = MeasureAssembler.Convert ((MeasureEN)enHijo.Measure, session);


                //
                // Service
        }

        return dto;
}
}
}
