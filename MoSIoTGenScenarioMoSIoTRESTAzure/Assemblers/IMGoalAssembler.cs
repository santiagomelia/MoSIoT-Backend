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
public static class IMGoalAssembler
{
public static IMGoalDTOA Convert (EntityAttributesEN en, NHibernate.ISession session = null)
{
        IMGoalDTOA dto = null;
        IMGoalRESTCAD iMGoalRESTCAD = null;
        IMGoalCEN iMGoalCEN = null;
        IMGoalCP iMGoalCP = null;

        if (en != null) {
                dto = new IMGoalDTOA ();
                iMGoalRESTCAD = new IMGoalRESTCAD (session);
                iMGoalCEN = new IMGoalCEN (iMGoalRESTCAD);
                iMGoalCP = new IMGoalCP (session);


                IMGoalEN enHijo = iMGoalRESTCAD.ReadOIDDefault (en.Id);




                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.Value = en.Value;


                //
                // TravesalLink

                /* Rol: IMGoal o--> Goal */
                dto.ValueGoal = GoalAssembler.Convert ((GoalEN)enHijo.Goal, session);


                //
                // Service
        }

        return dto;
}
}
}
