
using System;
using System.Text;
using MoSIoTGenNHibernate.CEN.MosIoT;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Exceptions;


/*
 * Clase RuleCondition:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class RuleConditionCAD : BasicCAD, IRuleConditionCAD
{
public RuleConditionCAD() : base ()
{
}

public RuleConditionCAD(ISession sessionAux) : base (sessionAux)
{
}



public RuleConditionEN ReadOIDDefault (int id
                                       )
{
        RuleConditionEN ruleConditionEN = null;

        try
        {
                SessionInitializeTransaction ();
                ruleConditionEN = (RuleConditionEN)session.Get (typeof(RuleConditionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ruleConditionEN;
}

public System.Collections.Generic.IList<RuleConditionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RuleConditionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RuleConditionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RuleConditionEN>();
                        else
                                result = session.CreateCriteria (typeof(RuleConditionEN)).List<RuleConditionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleConditionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RuleConditionEN ruleCondition)
{
        try
        {
                SessionInitializeTransaction ();
                RuleConditionEN ruleConditionEN = (RuleConditionEN)session.Load (typeof(RuleConditionEN), ruleCondition.Id);


                ruleConditionEN.Operator_ = ruleCondition.Operator_;


                ruleConditionEN.Value = ruleCondition.Value;


                session.Update (ruleConditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RuleConditionEN ruleCondition)
{
        try
        {
                SessionInitializeTransaction ();
                if (ruleCondition.Rule != null) {
                        // Argumento OID y no colección.
                        ruleCondition.Rule = (MoSIoTGenNHibernate.EN.MosIoT.RuleEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.RuleEN), ruleCondition.Rule.Id);

                        ruleCondition.Rule.Condition
                        .Add (ruleCondition);
                }

                session.Save (ruleCondition);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ruleCondition.Id;
}

public void Modify (RuleConditionEN ruleCondition)
{
        try
        {
                SessionInitializeTransaction ();
                RuleConditionEN ruleConditionEN = (RuleConditionEN)session.Load (typeof(RuleConditionEN), ruleCondition.Id);

                ruleConditionEN.Operator_ = ruleCondition.Operator_;


                ruleConditionEN.Value = ruleCondition.Value;

                session.Update (ruleConditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                RuleConditionEN ruleConditionEN = (RuleConditionEN)session.Load (typeof(RuleConditionEN), id);
                session.Delete (ruleConditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RuleConditionEN
public RuleConditionEN ReadOID (int id
                                )
{
        RuleConditionEN ruleConditionEN = null;

        try
        {
                SessionInitializeTransaction ();
                ruleConditionEN = (RuleConditionEN)session.Get (typeof(RuleConditionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ruleConditionEN;
}

public System.Collections.Generic.IList<RuleConditionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RuleConditionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RuleConditionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RuleConditionEN>();
                else
                        result = session.CreateCriteria (typeof(RuleConditionEN)).List<RuleConditionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
