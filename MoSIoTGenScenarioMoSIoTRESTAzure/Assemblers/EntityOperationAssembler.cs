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
public static class EntityOperationAssembler
{
public static EntityOperationDTOA Convert (EntityOperationEN en, NHibernate.ISession session = null)
{
        EntityOperationDTOA dto = null;
        EntityOperationRESTCAD entityOperationRESTCAD = null;
        EntityOperationCEN entityOperationCEN = null;
        EntityOperationCP entityOperationCP = null;

        if (en != null) {
                dto = new EntityOperationDTOA ();
                entityOperationRESTCAD = new EntityOperationRESTCAD (session);
                entityOperationCEN = new EntityOperationCEN (entityOperationRESTCAD);
                entityOperationCP = new EntityOperationCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Type = en.Type;


                dto.ServiceType = en.ServiceType;


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
