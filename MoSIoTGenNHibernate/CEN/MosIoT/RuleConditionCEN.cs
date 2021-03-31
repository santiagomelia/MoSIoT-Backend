

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
 *      Definition of the class RuleConditionCEN
 *
 */
public partial class RuleConditionCEN
{
private IRuleConditionCAD _IRuleConditionCAD;

public RuleConditionCEN()
{
        this._IRuleConditionCAD = new RuleConditionCAD ();
}

public RuleConditionCEN(IRuleConditionCAD _IRuleConditionCAD)
{
        this._IRuleConditionCAD = _IRuleConditionCAD;
}

public IRuleConditionCAD get_IRuleConditionCAD ()
{
        return this._IRuleConditionCAD;
}

public int New_ (int p_rule, MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum p_operator, string p_value)
{
        RuleConditionEN ruleConditionEN = null;
        int oid;

        //Initialized RuleConditionEN
        ruleConditionEN = new RuleConditionEN ();

        if (p_rule != -1) {
                // El argumento p_rule -> Property rule es oid = false
                // Lista de oids id
                ruleConditionEN.Rule = new MoSIoTGenNHibernate.EN.MosIoT.RuleEN ();
                ruleConditionEN.Rule.Id = p_rule;
        }

        ruleConditionEN.Operator_ = p_operator;

        ruleConditionEN.Value = p_value;

        //Call to RuleConditionCAD

        oid = _IRuleConditionCAD.New_ (ruleConditionEN);
        return oid;
}

public void Modify (int p_RuleCondition_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum p_operator, string p_value)
{
        RuleConditionEN ruleConditionEN = null;

        //Initialized RuleConditionEN
        ruleConditionEN = new RuleConditionEN ();
        ruleConditionEN.Id = p_RuleCondition_OID;
        ruleConditionEN.Operator_ = p_operator;
        ruleConditionEN.Value = p_value;
        //Call to RuleConditionCAD

        _IRuleConditionCAD.Modify (ruleConditionEN);
}

public void Destroy (int id
                     )
{
        _IRuleConditionCAD.Destroy (id);
}

public RuleConditionEN ReadOID (int id
                                )
{
        RuleConditionEN ruleConditionEN = null;

        ruleConditionEN = _IRuleConditionCAD.ReadOID (id);
        return ruleConditionEN;
}

public System.Collections.Generic.IList<RuleConditionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RuleConditionEN> list = null;

        list = _IRuleConditionCAD.ReadAll (first, size);
        return list;
}
}
}
