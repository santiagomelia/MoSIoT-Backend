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
public static class GoalAssembler
{
public static GoalDTOA Convert (GoalEN en, NHibernate.ISession session = null)
{
        GoalDTOA dto = null;
        GoalRESTCAD goalRESTCAD = null;
        GoalCEN goalCEN = null;
        GoalCP goalCP = null;

        if (en != null) {
                dto = new GoalDTOA ();
                goalRESTCAD = new GoalRESTCAD (session);
                goalCEN = new GoalCEN (goalRESTCAD);
                goalCP = new GoalCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Description = en.Description;


                dto.Priority = en.Priority;


                dto.Status = en.Status;


                dto.Category = en.Category;


                dto.OutcomeCode = en.OutcomeCode;


                //
                // TravesalLink

                /* Rol: Goal o--> Target */
                dto.Targets = null;
                List<TargetEN> Targets = goalRESTCAD.Targets (en.Id).ToList ();
                if (Targets != null) {
                        dto.Targets = new List<TargetDTOA>();
                        foreach (TargetEN entry in Targets)
                                dto.Targets.Add (TargetAssembler.Convert (entry, session));
                }


                //
                // Service
        }

        return dto;
}
}
}
