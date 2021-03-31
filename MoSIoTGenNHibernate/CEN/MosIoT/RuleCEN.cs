

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
 *      Definition of the class RuleCEN
 *
 */
public partial class RuleCEN
{
private IRuleCAD _IRuleCAD;

public RuleCEN()
{
        this._IRuleCAD = new RuleCAD ();
}

public RuleCEN(IRuleCAD _IRuleCAD)
{
        this._IRuleCAD = _IRuleCAD;
}

public IRuleCAD get_IRuleCAD ()
{
        return this._IRuleCAD;
}

public int New_ (string p_name, bool p_isEnabled, int p_ioTScenario, double p_intervalTime, string p_description)
{
        RuleEN ruleEN = null;
        int oid;

        //Initialized RuleEN
        ruleEN = new RuleEN ();
        ruleEN.Name = p_name;

        ruleEN.IsEnabled = p_isEnabled;


        if (p_ioTScenario != -1) {
                // El argumento p_ioTScenario -> Property ioTScenario es oid = false
                // Lista de oids id
                ruleEN.IoTScenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                ruleEN.IoTScenario.Id = p_ioTScenario;
        }

        ruleEN.IntervalTime = p_intervalTime;

        ruleEN.Description = p_description;

        //Call to RuleCAD

        oid = _IRuleCAD.New_ (ruleEN);
        return oid;
}

public void Modify (int p_Rule_OID, string p_name, bool p_isEnabled, double p_intervalTime, string p_description)
{
        RuleEN ruleEN = null;

        //Initialized RuleEN
        ruleEN = new RuleEN ();
        ruleEN.Id = p_Rule_OID;
        ruleEN.Name = p_name;
        ruleEN.IsEnabled = p_isEnabled;
        ruleEN.IntervalTime = p_intervalTime;
        ruleEN.Description = p_description;
        //Call to RuleCAD

        _IRuleCAD.Modify (ruleEN);
}

public void Destroy (int id
                     )
{
        _IRuleCAD.Destroy (id);
}

public RuleEN ReadOID (int id
                       )
{
        RuleEN ruleEN = null;

        ruleEN = _IRuleCAD.ReadOID (id);
        return ruleEN;
}

public System.Collections.Generic.IList<RuleEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RuleEN> list = null;

        list = _IRuleCAD.ReadAll (first, size);
        return list;
}
}
}
