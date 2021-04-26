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
public static class PropertyAssembler
{
public static PropertyDTOA Convert (PropertyEN en, NHibernate.ISession session = null)
{
        PropertyDTOA dto = null;
        PropertyRESTCAD propertyRESTCAD = null;
        PropertyCEN propertyCEN = null;
        PropertyCP propertyCP = null;

        if (en != null) {
                dto = new PropertyDTOA ();
                propertyRESTCAD = new PropertyRESTCAD (session);
                propertyCEN = new PropertyCEN (propertyRESTCAD);
                propertyCP = new PropertyCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.IsWritable = en.IsWritable;


                dto.IsCloudable = en.IsCloudable;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
