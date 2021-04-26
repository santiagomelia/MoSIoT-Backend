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
public static class MeasureAssembler
{
public static MeasureDTOA Convert (MeasureEN en, NHibernate.ISession session = null)
{
        MeasureDTOA dto = null;
        MeasureRESTCAD measureRESTCAD = null;
        MeasureCEN measureCEN = null;
        MeasureCP measureCP = null;

        if (en != null) {
                dto = new MeasureDTOA ();
                measureRESTCAD = new MeasureRESTCAD (session);
                measureCEN = new MeasureCEN (measureRESTCAD);
                measureCP = new MeasureCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.LOINCcode = en.LOINCcode;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
