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
public static class EntityAttributesAssembler
{
public static EntityAttributesDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        EntityAttributesDTOA dto = null;
        EntityAttributesRESTCAD entityAttributesRESTCAD = null;
        EntityAttributesCEN entityAttributesCEN = null;
        EntityAttributesCP entityAttributesCP = null;

        if (en != null) {
                dto = new EntityAttributesDTOA ();
                entityAttributesRESTCAD = new EntityAttributesRESTCAD (session);
                entityAttributesCEN = new EntityAttributesCEN (entityAttributesRESTCAD);
                entityAttributesCP = new EntityAttributesCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Type = en.Type;


                dto.IsOID = en.IsOID;


                dto.AssociationType = en.AssociationType;


                dto.IsWritable = en.IsWritable;


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
