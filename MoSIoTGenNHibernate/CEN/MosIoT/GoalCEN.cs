

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;

using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


namespace MoSIoTGenNHibernate.CEN.MosIoT
{
/*
 *      Definition of the class GoalCEN
 *
 */
public partial class GoalCEN
{
private IGoalCAD _IGoalCAD;

public GoalCEN()
{
        this._IGoalCAD = new GoalCAD ();
}

public GoalCEN(IGoalCAD _IGoalCAD)
{
        this._IGoalCAD = _IGoalCAD;
}

public IGoalCAD get_IGoalCAD ()
{
        return this._IGoalCAD;
}

public int New_ (int p_carePlanTemplate, MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum p_priority, MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum p_status, int p_condition, string p_description, MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum p_category, string p_outcomeCode, string p_name)
{
        GoalEN goalEN = null;
        int oid;

        //Initialized GoalEN
        goalEN = new GoalEN ();

        if (p_carePlanTemplate != -1) {
                // El argumento p_carePlanTemplate -> Property carePlanTemplate es oid = false
                // Lista de oids id
                goalEN.CarePlanTemplate = new MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN ();
                goalEN.CarePlanTemplate.Id = p_carePlanTemplate;
        }

        goalEN.Priority = p_priority;

        goalEN.Status = p_status;


        if (p_condition != -1) {
                // El argumento p_condition -> Property condition es oid = false
                // Lista de oids id
                goalEN.Condition = new MoSIoTGenNHibernate.EN.MosIoT.ConditionEN ();
                goalEN.Condition.Id = p_condition;
        }

        goalEN.Description = p_description;

        goalEN.Category = p_category;

        goalEN.OutcomeCode = p_outcomeCode;

        goalEN.Name = p_name;

        //Call to GoalCAD

        oid = _IGoalCAD.New_ (goalEN);
        return oid;
}

public void Modify (int p_Goal_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.PriorityTypeEnum p_priority, MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum p_status, string p_description, MoSIoTGenNHibernate.Enumerated.MosIoT.CategoryGoalEnum p_category, string p_outcomeCode, string p_name)
{
        GoalEN goalEN = null;

        //Initialized GoalEN
        goalEN = new GoalEN ();
        goalEN.Id = p_Goal_OID;
        goalEN.Priority = p_priority;
        goalEN.Status = p_status;
        goalEN.Description = p_description;
        goalEN.Category = p_category;
        goalEN.OutcomeCode = p_outcomeCode;
        goalEN.Name = p_name;
        //Call to GoalCAD

        _IGoalCAD.Modify (goalEN);
}

public void Destroy (int id
                     )
{
        _IGoalCAD.Destroy (id);
}

public GoalEN ReadOID (int id
                       )
{
        GoalEN goalEN = null;

        goalEN = _IGoalCAD.ReadOID (id);
        return goalEN;
}

public System.Collections.Generic.IList<GoalEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<GoalEN> list = null;

        list = _IGoalCAD.ReadAll (first, size);
        return list;
}
}
}
