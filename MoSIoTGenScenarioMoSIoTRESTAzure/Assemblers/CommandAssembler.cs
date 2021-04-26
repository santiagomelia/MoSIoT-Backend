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
public static class CommandAssembler
{
public static CommandDTOA Convert (CommandEN en, NHibernate.ISession session = null)
{
        CommandDTOA dto = null;
        CommandRESTCAD commandRESTCAD = null;
        CommandCEN commandCEN = null;
        CommandCP commandCP = null;

        if (en != null) {
                dto = new CommandDTOA ();
                commandRESTCAD = new CommandRESTCAD (session);
                commandCEN = new CommandCEN (commandRESTCAD);
                commandCP = new CommandCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.IsSynchronous = en.IsSynchronous;


                dto.Type = en.Type;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
