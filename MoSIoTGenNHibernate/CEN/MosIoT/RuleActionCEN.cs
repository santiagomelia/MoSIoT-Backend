

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
 *      Definition of the class RuleActionCEN
 *
 */
public partial class RuleActionCEN
{
private IRuleActionCAD _IRuleActionCAD;

public RuleActionCEN()
{
        this._IRuleActionCAD = new RuleActionCAD ();
}

public RuleActionCEN(IRuleActionCAD _IRuleActionCAD)
{
        this._IRuleActionCAD = _IRuleActionCAD;
}

public IRuleActionCAD get_IRuleActionCAD ()
{
        return this._IRuleActionCAD;
}

public int New_ (int p_rule, int p_operation)
{
        RuleActionEN ruleActionEN = null;
        int oid;

        //Initialized RuleActionEN
        ruleActionEN = new RuleActionEN ();

        if (p_rule != -1) {
                // El argumento p_rule -> Property rule es oid = false
                // Lista de oids id
                ruleActionEN.Rule = new MoSIoTGenNHibernate.EN.MosIoT.RuleEN ();
                ruleActionEN.Rule.Id = p_rule;
        }


        if (p_operation != -1) {
                // El argumento p_operation -> Property operation es oid = false
                // Lista de oids id
                ruleActionEN.Operation = new MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN ();
                ruleActionEN.Operation.Id = p_operation;
        }

        //Call to RuleActionCAD

        oid = _IRuleActionCAD.New_ (ruleActionEN);
        return oid;
}

public void Modify (int p_RuleAction_OID)
{
        RuleActionEN ruleActionEN = null;

        //Initialized RuleActionEN
        ruleActionEN = new RuleActionEN ();
        ruleActionEN.Id = p_RuleAction_OID;
        //Call to RuleActionCAD

        _IRuleActionCAD.Modify (ruleActionEN);
}

public void Destroy (int id
                     )
{
        _IRuleActionCAD.Destroy (id);
}

public RuleActionEN ReadOID (int id
                             )
{
        RuleActionEN ruleActionEN = null;

        ruleActionEN = _IRuleActionCAD.ReadOID (id);
        return ruleActionEN;
}

public System.Collections.Generic.IList<RuleActionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RuleActionEN> list = null;

        list = _IRuleActionCAD.ReadAll (first, size);
        return list;
}
}
}
