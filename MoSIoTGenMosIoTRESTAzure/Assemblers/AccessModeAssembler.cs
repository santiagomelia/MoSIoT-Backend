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
public static class AccessModeAssembler
{
public static AccessModeDTOA Convert (AccessModeEN en, NHibernate.ISession session = null)
{
        AccessModeDTOA dto = null;
        AccessModeRESTCAD accessModeRESTCAD = null;
        AccessModeCEN accessModeCEN = null;
        AccessModeCP accessModeCP = null;

        if (en != null) {
                dto = new AccessModeDTOA ();
                accessModeRESTCAD = new AccessModeRESTCAD (session);
                accessModeCEN = new AccessModeCEN (accessModeRESTCAD);
                accessModeCP = new AccessModeCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.TypeAccessMode = en.TypeAccessMode;


                dto.Description = en.Description;


                dto.Name = en.Name;


                //
                // TravesalLink

                /* Rol: AccessMode o--> AdaptationTypeRequired */
                dto.AdaptationType = null;
                List<AdaptationTypeRequiredEN> AdaptationType = accessModeRESTCAD.AdaptationType (en.Id).ToList ();
                if (AdaptationType != null) {
                        dto.AdaptationType = new List<AdaptationTypeRequiredDTOA>();
                        foreach (AdaptationTypeRequiredEN entry in AdaptationType)
                                dto.AdaptationType.Add (AdaptationTypeRequiredAssembler.Convert (entry, session));
                }

                /* Rol: AccessMode o--> AdaptationDetailRequired */
                dto.AdaptationDetail = null;
                List<AdaptationDetailRequiredEN> AdaptationDetail = accessModeRESTCAD.AdaptationDetail (en.Id).ToList ();
                if (AdaptationDetail != null) {
                        dto.AdaptationDetail = new List<AdaptationDetailRequiredDTOA>();
                        foreach (AdaptationDetailRequiredEN entry in AdaptationDetail)
                                dto.AdaptationDetail.Add (AdaptationDetailRequiredAssembler.Convert (entry, session));
                }

                /* Rol: AccessMode o--> AdaptationRequest */
                dto.AdaptationRequest = null;
                List<AdaptationRequestEN> AdaptationRequest = accessModeRESTCAD.AdaptationRequest (en.Id).ToList ();
                if (AdaptationRequest != null) {
                        dto.AdaptationRequest = new List<AdaptationRequestDTOA>();
                        foreach (AdaptationRequestEN entry in AdaptationRequest)
                                dto.AdaptationRequest.Add (AdaptationRequestAssembler.Convert (entry, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
