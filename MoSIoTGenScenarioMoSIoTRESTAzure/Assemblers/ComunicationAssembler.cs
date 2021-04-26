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
public static class ComunicationAssembler
{
public static ComunicationDTOA Convert (ComunicationEN en, NHibernate.ISession session = null)
{
        ComunicationDTOA dto = null;
        ComunicationRESTCAD comunicationRESTCAD = null;
        ComunicationCEN comunicationCEN = null;
        ComunicationCP comunicationCP = null;

        if (en != null) {
                dto = new ComunicationDTOA ();
                comunicationRESTCAD = new ComunicationRESTCAD (session);
                comunicationCEN = new ComunicationCEN (comunicationRESTCAD);
                comunicationCP = new ComunicationCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Severity = en.Severity;


                dto.Message = en.Message;


                dto.SendDate = en.SendDate;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
