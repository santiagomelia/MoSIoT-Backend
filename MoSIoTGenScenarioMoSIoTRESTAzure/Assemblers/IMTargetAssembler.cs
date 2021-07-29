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
public static class IMTargetAssembler
{
public static IMTargetDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMTargetDTOA dto = null;
        IMTargetRESTCAD iMTargetRESTCAD = null;
        IMTargetCEN iMTargetCEN = null;
        IMTargetCP iMTargetCP = null;

        if (en != null) {
                dto = new IMTargetDTOA ();
                iMTargetRESTCAD = new IMTargetRESTCAD (session);
                iMTargetCEN = new IMTargetCEN (iMTargetRESTCAD);
                iMTargetCP = new IMTargetCP (session);


                IMTargetEN enHijo = iMTargetRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.Value = en.Value;


                //
                // TravesalLink

                /* Rol: IMTarget o--> Target */
                dto.ValueTarget = TargetAssembler.Convert ((TargetEN)enHijo.Target, session);


                //
                // Service
        }

        return dto;
}
}
}
