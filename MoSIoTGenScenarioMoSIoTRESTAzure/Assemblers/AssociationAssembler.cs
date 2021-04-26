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
public static class AssociationAssembler
{
public static AssociationDTOA Convert (AssociationEN en, NHibernate.ISession session = null)
{
        AssociationDTOA dto = null;
        AssociationRESTCAD associationRESTCAD = null;
        AssociationCEN associationCEN = null;
        AssociationCP associationCP = null;

        if (en != null) {
                dto = new AssociationDTOA ();
                associationRESTCAD = new AssociationRESTCAD (session);
                associationCEN = new AssociationCEN (associationRESTCAD);
                associationCP = new AssociationCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.Type = en.Type;


                dto.CardinalityOrigin = en.CardinalityOrigin;


                dto.CardinalityTarget = en.CardinalityTarget;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
