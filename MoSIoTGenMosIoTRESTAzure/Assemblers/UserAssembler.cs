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
public static class UserAssembler
{
public static UserDTOA Convert (UserEN en, NHibernate.ISession session = null)
{
        UserDTOA dto = null;
        UserRESTCAD userRESTCAD = null;
        UserCEN userCEN = null;
        UserCP userCP = null;

        if (en != null) {
                dto = new UserDTOA ();
                userRESTCAD = new UserRESTCAD (session);
                userCEN = new UserCEN (userRESTCAD);
                userCP = new UserCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Surnames = en.Surnames;


                dto.IsActive = en.IsActive;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
