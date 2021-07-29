
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
 * Clase IMGoal:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMGoalCAD : BasicCAD, IIMGoalCAD
{
public IMGoalCAD() : base ()
{
}

public IMGoalCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMGoalEN ReadOIDDefault (int id
                                )
{
        IMGoalEN iMGoalEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMGoalEN = (IMGoalEN)session.Get (typeof(IMGoalEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMGoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMGoalEN;
}

public System.Collections.Generic.IList<IMGoalEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMGoalEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMGoalEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMGoalEN>();
                        else
                                result = session.CreateCriteria (typeof(IMGoalEN)).List<IMGoalEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMGoalCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMGoalEN iMGoal)
{
        try
        {
                SessionInitializeTransaction ();
                IMGoalEN iMGoalEN = (IMGoalEN)session.Load (typeof(IMGoalEN), iMGoal.Id);

                session.Update (iMGoalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMGoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMGoalEN iMGoal)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMGoal.Entity != null) {
                        // Argumento OID y no colección.
                        iMGoal.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMGoal.Entity.Id);

                        iMGoal.Entity.Attributes
                        .Add (iMGoal);
                }

                session.Save (iMGoal);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMGoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMGoal.Id;
}

public void Modify (IMGoalEN iMGoal)
{
        try
        {
                SessionInitializeTransaction ();
                IMGoalEN iMGoalEN = (IMGoalEN)session.Load (typeof(IMGoalEN), iMGoal.Id);

                iMGoalEN.Name = iMGoal.Name;


                iMGoalEN.Description = iMGoal.Description;

                session.Update (iMGoalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMGoalCAD.", ex);
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
                IMGoalEN iMGoalEN = (IMGoalEN)session.Load (typeof(IMGoalEN), id);
                session.Delete (iMGoalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMGoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMGoalEN
public IMGoalEN ReadOID (int id
                         )
{
        IMGoalEN iMGoalEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMGoalEN = (IMGoalEN)session.Get (typeof(IMGoalEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMGoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMGoalEN;
}

public System.Collections.Generic.IList<IMGoalEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMGoalEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMGoalEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMGoalEN>();
                else
                        result = session.CreateCriteria (typeof(IMGoalEN)).List<IMGoalEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMGoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AssignGoal (int p_IMGoal_OID, int p_goal_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.IMGoalEN iMGoalEN = null;
        try
        {
                SessionInitializeTransaction ();
                iMGoalEN = (IMGoalEN)session.Load (typeof(IMGoalEN), p_IMGoal_OID);
                iMGoalEN.Goal = (MoSIoTGenNHibernate.EN.MosIoT.GoalEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.GoalEN), p_goal_OID);



                session.Update (iMGoalEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMGoalCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
