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
public static class EntityAssembler
{
public static EntityDTOA Convert (EntityEN en, NHibernate.ISession session = null)
{
        EntityDTOA dto = null;
        EntityRESTCAD entityRESTCAD = null;
        EntityCEN entityCEN = null;
        EntityCP entityCP = null;

        if (en != null) {
                dto = new EntityDTOA ();
                entityRESTCAD = new EntityRESTCAD (session);
                entityCEN = new EntityCEN (entityRESTCAD);
                entityCP = new EntityCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                //
                // TravesalLink

                /* Rol: Entity o--> Association */
                dto.OriginAssociations = null;
                List<AssociationEN> OriginAssociations = entityRESTCAD.OriginAssociations (en.Id).ToList ();
                if (OriginAssociations != null) {
                        dto.OriginAssociations = new List<AssociationDTOA>();
                        foreach (AssociationEN entry in OriginAssociations)
                                dto.OriginAssociations.Add (AssociationAssembler.Convert (entry, session));
                }

                /* Rol: Entity o--> Association */
                dto.TargetAssociations = null;
                List<AssociationEN> TargetAssociations = entityRESTCAD.TargetAssociations (en.Id).ToList ();
                if (TargetAssociations != null) {
                        dto.TargetAssociations = new List<AssociationDTOA>();
                        foreach (AssociationEN entry in TargetAssociations)
                                dto.TargetAssociations.Add (AssociationAssembler.Convert (entry, session));
                }

                /* Rol: Entity o--> EntityAttributes */
                dto.Attributes = null;
                List<EntityAttributesEN> Attributes = entityRESTCAD.Attributes (en.Id).ToList ();
                if (Attributes != null) {
                        dto.Attributes = new List<EntityAttributesDTOA>();
                        foreach (EntityAttributesEN entry in Attributes)
                                dto.Attributes.Add (EntityAttributesAssembler.Convert (entry, session));
                }

                /* Rol: Entity o--> EntityOperation */
                dto.Operations = null;
                List<EntityOperationEN> Operations = entityRESTCAD.Operations (en.Id).ToList ();
                if (Operations != null) {
                        dto.Operations = new List<EntityOperationDTOA>();
                        foreach (EntityOperationEN entry in Operations)
                                dto.Operations.Add (EntityOperationAssembler.Convert (entry, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
