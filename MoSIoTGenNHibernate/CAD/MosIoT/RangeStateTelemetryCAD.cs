
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
 * Clase RangeStateTelemetry:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class RangeStateTelemetryCAD : BasicCAD, IRangeStateTelemetryCAD
{
public RangeStateTelemetryCAD() : base ()
{
}

public RangeStateTelemetryCAD(ISession sessionAux) : base (sessionAux)
{
}



public RangeStateTelemetryEN ReadOIDDefault (int id
                                             )
{
        RangeStateTelemetryEN rangeStateTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                rangeStateTelemetryEN = (RangeStateTelemetryEN)session.Get (typeof(RangeStateTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RangeStateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rangeStateTelemetryEN;
}

public System.Collections.Generic.IList<RangeStateTelemetryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RangeStateTelemetryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RangeStateTelemetryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RangeStateTelemetryEN>();
                        else
                                result = session.CreateCriteria (typeof(RangeStateTelemetryEN)).List<RangeStateTelemetryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RangeStateTelemetryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RangeStateTelemetryEN rangeStateTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                RangeStateTelemetryEN rangeStateTelemetryEN = (RangeStateTelemetryEN)session.Load (typeof(RangeStateTelemetryEN), rangeStateTelemetry.Id);


                rangeStateTelemetryEN.Name = rangeStateTelemetry.Name;


                rangeStateTelemetryEN.Value = rangeStateTelemetry.Value;

                session.Update (rangeStateTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RangeStateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RangeStateTelemetryEN rangeStateTelemetry)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (rangeStateTelemetry);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RangeStateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rangeStateTelemetry.Id;
}

public void Modify (RangeStateTelemetryEN rangeStateTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                RangeStateTelemetryEN rangeStateTelemetryEN = (RangeStateTelemetryEN)session.Load (typeof(RangeStateTelemetryEN), rangeStateTelemetry.Id);

                rangeStateTelemetryEN.Name = rangeStateTelemetry.Name;


                rangeStateTelemetryEN.Value = rangeStateTelemetry.Value;

                session.Update (rangeStateTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RangeStateTelemetryCAD.", ex);
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
                RangeStateTelemetryEN rangeStateTelemetryEN = (RangeStateTelemetryEN)session.Load (typeof(RangeStateTelemetryEN), id);
                session.Delete (rangeStateTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RangeStateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RangeStateTelemetryEN
public RangeStateTelemetryEN ReadOID (int id
                                      )
{
        RangeStateTelemetryEN rangeStateTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                rangeStateTelemetryEN = (RangeStateTelemetryEN)session.Get (typeof(RangeStateTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RangeStateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return rangeStateTelemetryEN;
}

public System.Collections.Generic.IList<RangeStateTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RangeStateTelemetryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RangeStateTelemetryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RangeStateTelemetryEN>();
                else
                        result = session.CreateCriteria (typeof(RangeStateTelemetryEN)).List<RangeStateTelemetryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RangeStateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
