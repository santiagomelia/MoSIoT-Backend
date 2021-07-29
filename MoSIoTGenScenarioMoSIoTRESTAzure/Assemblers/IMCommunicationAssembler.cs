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
public static class IMCommunicationAssembler
{
public static IMCommunicationDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMCommunicationDTOA dto = null;
        IMCommunicationRESTCAD iMCommunicationRESTCAD = null;
        IMCommunicationCEN iMCommunicationCEN = null;
        IMCommunicationCP iMCommunicationCP = null;

        if (en != null) {
                dto = new IMCommunicationDTOA ();
                iMCommunicationRESTCAD = new IMCommunicationRESTCAD (session);
                iMCommunicationCEN = new IMCommunicationCEN (iMCommunicationRESTCAD);
                iMCommunicationCP = new IMCommunicationCP (session);


                IMCommunicationEN enHijo = iMCommunicationRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                //
                // TravesalLink

                /* Rol: IMCommunication o--> Comunication */
                dto.ValueCommunication = ComunicationAssembler.Convert ((ComunicationEN)enHijo.Comunication, session);


                //
                // Service
        }

        return dto;
}
}
}
