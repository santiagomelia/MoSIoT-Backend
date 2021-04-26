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
public static class TargetAssembler
{
public static TargetDTOA Convert (TargetEN en, NHibernate.ISession session = null)
{
        TargetDTOA dto = null;
        TargetRESTCAD targetRESTCAD = null;
        TargetCEN targetCEN = null;
        TargetCP targetCP = null;

        if (en != null) {
                dto = new TargetDTOA ();
                targetRESTCAD = new TargetRESTCAD (session);
                targetCEN = new TargetCEN (targetRESTCAD);
                targetCP = new TargetCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.DesiredValue = en.DesiredValue;


                dto.Description = en.Description;


                dto.DueDate = en.DueDate;


                //
                // TravesalLink

                /* Rol: Target o--> Measure */
                dto.Measure = MeasureAssembler.Convert ((MeasureEN)en.Measure, session);


                //
                // Service
        }

        return dto;
}
}
}
