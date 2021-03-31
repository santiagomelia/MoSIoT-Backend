
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
 * Clase RuleAction:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class RuleActionCAD : BasicCAD, IRuleActionCAD
{
public RuleActionCAD() : base ()
{
}

public RuleActionCAD(ISession sessionAux) : base (sessionAux)
{
}



public RuleActionEN ReadOIDDefault (int id
                                    )
{
        RuleActionEN ruleActionEN = null;

        try
        {
                SessionInitializeTransaction ();
                ruleActionEN = (RuleActionEN)session.Get (typeof(RuleActionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ruleActionEN;
}

public System.Collections.Generic.IList<RuleActionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RuleActionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RuleActionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RuleActionEN>();
                        else
                                result = session.CreateCriteria (typeof(RuleActionEN)).List<RuleActionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleActionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RuleActionEN ruleAction)
{
        try
        {
                SessionInitializeTransaction ();
                RuleActionEN ruleActionEN = (RuleActionEN)session.Load (typeof(RuleActionEN), ruleAction.Id);


                session.Update (ruleActionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RuleActionEN ruleAction)
{
        try
        {
                SessionInitializeTransaction ();
                if (ruleAction.Rule != null) {
                        // Argumento OID y no colección.
                        ruleAction.Rule = (MoSIoTGenNHibernate.EN.MosIoT.RuleEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.RuleEN), ruleAction.Rule.Id);

                        ruleAction.Rule.RuleAction
                        .Add (ruleAction);
                }
                if (ruleAction.Operation != null) {
                        // Argumento OID y no colección.
                        ruleAction.Operation = (MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN), ruleAction.Operation.Id);

                        ruleAction.Operation.RuleAction
                        .Add (ruleAction);
                }

                session.Save (ruleAction);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ruleAction.Id;
}

public void Modify (RuleActionEN ruleAction)
{
        try
        {
                SessionInitializeTransaction ();
                RuleActionEN ruleActionEN = (RuleActionEN)session.Load (typeof(RuleActionEN), ruleAction.Id);
                session.Update (ruleActionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleActionCAD.", ex);
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
                RuleActionEN ruleActionEN = (RuleActionEN)session.Load (typeof(RuleActionEN), id);
                session.Delete (ruleActionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RuleActionEN
public RuleActionEN ReadOID (int id
                             )
{
        RuleActionEN ruleActionEN = null;

        try
        {
                SessionInitializeTransaction ();
                ruleActionEN = (RuleActionEN)session.Get (typeof(RuleActionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ruleActionEN;
}

public System.Collections.Generic.IList<RuleActionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RuleActionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RuleActionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RuleActionEN>();
                else
                        result = session.CreateCriteria (typeof(RuleActionEN)).List<RuleActionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RuleActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
