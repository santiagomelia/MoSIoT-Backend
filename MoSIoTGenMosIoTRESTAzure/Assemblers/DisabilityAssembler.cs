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
public static class DisabilityAssembler
{
public static DisabilityDTOA Convert (DisabilityEN en, NHibernate.ISession session = null)
{
        DisabilityDTOA dto = null;
        DisabilityRESTCAD disabilityRESTCAD = null;
        DisabilityCEN disabilityCEN = null;
        DisabilityCP disabilityCP = null;

        if (en != null) {
                dto = new DisabilityDTOA ();
                disabilityRESTCAD = new DisabilityRESTCAD (session);
                disabilityCEN = new DisabilityCEN (disabilityRESTCAD);
                disabilityCP = new DisabilityCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Type = en.Type;


                dto.Severity = en.Severity;


                dto.Description = en.Description;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
