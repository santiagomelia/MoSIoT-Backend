
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
 * Clase Target:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class TargetCAD : BasicCAD, ITargetCAD
{
public TargetCAD() : base ()
{
}

public TargetCAD(ISession sessionAux) : base (sessionAux)
{
}



public TargetEN ReadOIDDefault (int id
                                )
{
        TargetEN targetEN = null;

        try
        {
                SessionInitializeTransaction ();
                targetEN = (TargetEN)session.Get (typeof(TargetEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return targetEN;
}

public System.Collections.Generic.IList<TargetEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TargetEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TargetEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<TargetEN>();
                        else
                                result = session.CreateCriteria (typeof(TargetEN)).List<TargetEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TargetEN target)
{
        try
        {
                SessionInitializeTransaction ();
                TargetEN targetEN = (TargetEN)session.Load (typeof(TargetEN), target.Id);


                targetEN.DesiredValue = target.DesiredValue;



                targetEN.Description = target.Description;


                targetEN.DueDate = target.DueDate;

                session.Update (targetEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (TargetEN target)
{
        try
        {
                SessionInitializeTransaction ();
                if (target.Goal != null) {
                        // Argumento OID y no colección.
                        target.Goal = (MoSIoTGenNHibernate.EN.MosIoT.GoalEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.GoalEN), target.Goal.Id);

                        target.Goal.Targets
                        .Add (target);
                }

                session.Save (target);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return target.Id;
}

public void Modify (TargetEN target)
{
        try
        {
                SessionInitializeTransaction ();
                TargetEN targetEN = (TargetEN)session.Load (typeof(TargetEN), target.Id);

                targetEN.DesiredValue = target.DesiredValue;


                targetEN.Description = target.Description;


                targetEN.DueDate = target.DueDate;

                session.Update (targetEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetCAD.", ex);
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
                TargetEN targetEN = (TargetEN)session.Load (typeof(TargetEN), id);
                session.Delete (targetEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: TargetEN
public TargetEN ReadOID (int id
                         )
{
        TargetEN targetEN = null;

        try
        {
                SessionInitializeTransaction ();
                targetEN = (TargetEN)session.Get (typeof(TargetEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return targetEN;
}

public System.Collections.Generic.IList<TargetEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TargetEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TargetEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TargetEN>();
                else
                        result = session.CreateCriteria (typeof(TargetEN)).List<TargetEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AddMeasure (int p_Target_OID, int p_measure_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.TargetEN targetEN = null;
        try
        {
                SessionInitializeTransaction ();
                targetEN = (TargetEN)session.Load (typeof(TargetEN), p_Target_OID);
                targetEN.Measure = (MoSIoTGenNHibernate.EN.MosIoT.MeasureEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.MeasureEN), p_measure_OID);

                targetEN.Measure.Target.Add (targetEN);



                session.Update (targetEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
