
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
 * Clase StateTelemetry:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class StateTelemetryCAD : BasicCAD, IStateTelemetryCAD
{
public StateTelemetryCAD() : base ()
{
}

public StateTelemetryCAD(ISession sessionAux) : base (sessionAux)
{
}



public StateTelemetryEN ReadOIDDefault (int id
                                        )
{
        StateTelemetryEN stateTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                stateTelemetryEN = (StateTelemetryEN)session.Get (typeof(StateTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return stateTelemetryEN;
}

public System.Collections.Generic.IList<StateTelemetryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<StateTelemetryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(StateTelemetryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<StateTelemetryEN>();
                        else
                                result = session.CreateCriteria (typeof(StateTelemetryEN)).List<StateTelemetryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateTelemetryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (StateTelemetryEN stateTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                StateTelemetryEN stateTelemetryEN = (StateTelemetryEN)session.Load (typeof(StateTelemetryEN), stateTelemetry.Id);

                session.Update (stateTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (StateTelemetryEN stateTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                if (stateTelemetry.Telemetry != null) {
                        // Argumento OID y no colección.
                        stateTelemetry.Telemetry = (MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN), stateTelemetry.Telemetry.Id);

                        stateTelemetry.Telemetry.TypeTelemetry
                                = stateTelemetry;
                }

                session.Save (stateTelemetry);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return stateTelemetry.Id;
}

public void Modify (StateTelemetryEN stateTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                StateTelemetryEN stateTelemetryEN = (StateTelemetryEN)session.Load (typeof(StateTelemetryEN), stateTelemetry.Id);

                stateTelemetryEN.Name = stateTelemetry.Name;

                session.Update (stateTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateTelemetryCAD.", ex);
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
                StateTelemetryEN stateTelemetryEN = (StateTelemetryEN)session.Load (typeof(StateTelemetryEN), id);
                session.Delete (stateTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: StateTelemetryEN
public StateTelemetryEN ReadOID (int id
                                 )
{
        StateTelemetryEN stateTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                stateTelemetryEN = (StateTelemetryEN)session.Get (typeof(StateTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return stateTelemetryEN;
}

public System.Collections.Generic.IList<StateTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<StateTelemetryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(StateTelemetryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<StateTelemetryEN>();
                else
                        result = session.CreateCriteria (typeof(StateTelemetryEN)).List<StateTelemetryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
