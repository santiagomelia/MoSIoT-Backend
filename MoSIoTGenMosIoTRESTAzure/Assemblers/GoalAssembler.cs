using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using MoSIoTGenMosIoTRESTAzure.DTOA;
using MoSIoTGenMosIoTRESTAzure.CAD;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.Assemblers
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

                dto.Priority = en.Priority;


                dto.Status = en.Status;


                dto.Description = en.Description;


                dto.Category = en.Category;


                dto.OutcomeCode = en.OutcomeCode;


                dto.Name = en.Name;


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
