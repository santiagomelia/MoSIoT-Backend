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
public static class UserAnonimousAssembler
{
public static UserAnonimousDTOA Convert (UserEN en, NHibernate.ISession session = null)
{
        UserAnonimousDTOA dto = null;
        UserAnonimousRESTCAD userAnonimousRESTCAD = null;
        UserCEN userCEN = null;
        UserCP userCP = null;

        if (en != null) {
                dto = new UserAnonimousDTOA ();
                userAnonimousRESTCAD = new UserAnonimousRESTCAD (session);
                userCEN = new UserCEN (userAnonimousRESTCAD);
                userCP = new UserCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
