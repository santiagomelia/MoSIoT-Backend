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

                dto.BirthDate = en.BirthDate;


                dto.Surnames = en.Surnames;


                dto.Address = en.Address;


                dto.Phone = en.Phone;


                dto.Photo = en.Photo;


                dto.IsActive = en.IsActive;


                dto.Type = en.Type;


                dto.IsDiseased = en.IsDiseased;


                dto.Email = en.Email;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
