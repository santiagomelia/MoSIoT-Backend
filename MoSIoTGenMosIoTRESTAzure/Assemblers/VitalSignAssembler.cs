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
public static class VitalSignAssembler
{
public static VitalSignDTOA Convert (VitalSignEN en, NHibernate.ISession session = null)
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





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


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
