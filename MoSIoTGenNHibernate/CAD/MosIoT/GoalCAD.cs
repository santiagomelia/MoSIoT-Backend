
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
 * Clase Goal:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class GoalCAD : BasicCAD, IGoalCAD
{
public GoalCAD() : base ()
{
}

public GoalCAD(ISession sessionAux) : base (sessionAux)
{
}



public GoalEN ReadOIDDefault (int id
                              )
{
        GoalEN goalEN = null;

        try
        {
                SessionInitializeTransaction ();
                goalEN = (GoalEN)session.Get (typeof(GoalEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return goalEN;
}

public System.Collections.Generic.IList<GoalEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<GoalEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(GoalEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<GoalEN>();
                        else
                                result = session.CreateCriteria (typeof(GoalEN)).List<GoalEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (GoalEN goal)
{
        try
        {
                SessionInitializeTransaction ();
                GoalEN goalEN = (GoalEN)session.Load (typeof(GoalEN), goal.Id);


                goalEN.Priority = goal.Priority;



                goalEN.Status = goal.Status;



                goalEN.Description = goal.Description;


                goalEN.Category = goal.Category;


                goalEN.OutcomeCode = goal.OutcomeCode;


                goalEN.Name = goal.Name;

                session.Update (goalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (GoalEN goal)
{
        try
        {
                SessionInitializeTransaction ();
                if (goal.CarePlan != null) {
                        // Argumento OID y no colección.
                        goal.CarePlan = (MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN), goal.CarePlan.Id);

                        goal.CarePlan.Goals
                        .Add (goal);
                }
                if (goal.Condition != null) {
                        // Argumento OID y no colección.
                        goal.Condition = (MoSIoTGenNHibernate.EN.MosIoT.ConditionEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.ConditionEN), goal.Condition.Id);

                        goal.Condition.Goal
                        .Add (goal);
                }

                session.Save (goal);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return goal.Id;
}

public void Modify (GoalEN goal)
{
        try
        {
                SessionInitializeTransaction ();
                GoalEN goalEN = (GoalEN)session.Load (typeof(GoalEN), goal.Id);

                goalEN.Priority = goal.Priority;


                goalEN.Status = goal.Status;


                goalEN.Description = goal.Description;


                goalEN.Category = goal.Category;


                goalEN.OutcomeCode = goal.OutcomeCode;


                goalEN.Name = goal.Name;

                session.Update (goalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
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
                GoalEN goalEN = (GoalEN)session.Load (typeof(GoalEN), id);
                session.Delete (goalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: GoalEN
public GoalEN ReadOID (int id
                       )
{
        GoalEN goalEN = null;

        try
        {
                SessionInitializeTransaction ();
                goalEN = (GoalEN)session.Get (typeof(GoalEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return goalEN;
}

public System.Collections.Generic.IList<GoalEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<GoalEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(GoalEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<GoalEN>();
                else
                        result = session.CreateCriteria (typeof(GoalEN)).List<GoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in GoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
