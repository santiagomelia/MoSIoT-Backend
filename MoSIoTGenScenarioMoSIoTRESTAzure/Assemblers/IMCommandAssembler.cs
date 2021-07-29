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
public static class IMCommandAssembler
{
public static IMCommandDTOA Convert (EntityOperationEN en, NHibernate.ISession session = null)
{
        IMCommandDTOA dto = null;
        IMCommandRESTCAD iMCommandRESTCAD = null;
        IMCommandCEN iMCommandCEN = null;
        IMCommandCP iMCommandCP = null;

        if (en != null) {
                dto = new IMCommandDTOA ();
                iMCommandRESTCAD = new IMCommandRESTCAD (session);
                iMCommandCEN = new IMCommandCEN (iMCommandRESTCAD);
                iMCommandCP = new IMCommandCP (session);


                IMCommandEN enHijo = iMCommandRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.Type = en.Type;


                dto.ServiceType = en.ServiceType;


                //
                // TravesalLink

                /* Rol: IMCommand o--> Command */
                dto.ValueCommand = CommandAssembler.Convert ((CommandEN)enHijo.Command, session);


                //
                // Service
        }

        return dto;
}
}
}
