
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
 * Clase Rule:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class RuleCAD : BasicCAD, IRuleCAD
{
public RuleCAD() : base ()
{
}

public RuleCAD(ISession sessionAux) : base (sessionAux)
{
}



public RuleEN ReadOIDDefault (int id
                              )
{
        RuleEN ruleEN = null;

        try
        {
                SessionInitializeTransaction ();
                ruleEN = (RuleEN)session.Get (typeof(RuleEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ruleEN;
}

public System.Collections.Generic.IList<RuleEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RuleEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RuleEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RuleEN>();
                        else
                                result = session.CreateCriteria (typeof(RuleEN)).List<RuleEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RuleEN rule)
{
        try
        {
                SessionInitializeTransaction ();
                RuleEN ruleEN = (RuleEN)session.Load (typeof(RuleEN), rule.Id);

                ruleEN.Name = rule.Name;


                ruleEN.IsEnabled = rule.IsEnabled;





                ruleEN.IntervalTime = rule.IntervalTime;


                ruleEN.Description = rule.Description;

                session.Update (ruleEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RuleEN rule)
{
        try
        {
                SessionInitializeTransaction ();
                if (rule.IoTScenario != null) {
                        // Argumento OID y no colección.
                        rule.IoTScenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), rule.IoTScenario.Id);

                        rule.IoTScenario.Rule
                        .Add (rule);
                }

                session.Save (rule);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rule.Id;
}

public void Modify (RuleEN rule)
{
        try
        {
                SessionInitializeTransaction ();
                RuleEN ruleEN = (RuleEN)session.Load (typeof(RuleEN), rule.Id);

                ruleEN.Name = rule.Name;


                ruleEN.IsEnabled = rule.IsEnabled;


                ruleEN.IntervalTime = rule.IntervalTime;


                ruleEN.Description = rule.Description;

                session.Update (ruleEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleCAD.", ex);
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
                RuleEN ruleEN = (RuleEN)session.Load (typeof(RuleEN), id);
                session.Delete (ruleEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RuleEN
public RuleEN ReadOID (int id
                       )
{
        RuleEN ruleEN = null;

        try
        {
                SessionInitializeTransaction ();
                ruleEN = (RuleEN)session.Get (typeof(RuleEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ruleEN;
}

public System.Collections.Generic.IList<RuleEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RuleEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RuleEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RuleEN>();
                else
                        result = session.CreateCriteria (typeof(RuleEN)).List<RuleEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
