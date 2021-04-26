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
public static class IMPropertyAssembler
{
public static IMPropertyDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMPropertyDTOA dto = null;
        IMPropertyRESTCAD iMPropertyRESTCAD = null;
        IMPropertyCEN iMPropertyCEN = null;
        IMPropertyCP iMPropertyCP = null;

        if (en != null) {
                dto = new IMPropertyDTOA ();
                iMPropertyRESTCAD = new IMPropertyRESTCAD (session);
                iMPropertyCEN = new IMPropertyCEN (iMPropertyRESTCAD);
                iMPropertyCP = new IMPropertyCP (session);


                IMPropertyEN enHijo = iMPropertyRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Type = en.Type;


                dto.Value = en.Value;


                //
                // TravesalLink

                /* Rol: IMProperty o--> Property */
                dto.ValueProperty = PropertyAssembler.Convert ((PropertyEN)enHijo.Property, session);


                //
                // Service
        }

        return dto;
}
}
}
