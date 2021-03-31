
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
 * Clase EventTelemetry:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class EventTelemetryCAD : BasicCAD, IEventTelemetryCAD
{
public EventTelemetryCAD() : base ()
{
}

public EventTelemetryCAD(ISession sessionAux) : base (sessionAux)
{
}



public EventTelemetryEN ReadOIDDefault (int id
                                        )
{
        EventTelemetryEN eventTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventTelemetryEN = (EventTelemetryEN)session.Get (typeof(EventTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EventTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventTelemetryEN;
}

public System.Collections.Generic.IList<EventTelemetryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EventTelemetryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EventTelemetryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EventTelemetryEN>();
                        else
                                result = session.CreateCriteria (typeof(EventTelemetryEN)).List<EventTelemetryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EventTelemetryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EventTelemetryEN eventTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                EventTelemetryEN eventTelemetryEN = (EventTelemetryEN)session.Load (typeof(EventTelemetryEN), eventTelemetry.Id);

                eventTelemetryEN.Severity = eventTelemetry.Severity;



                session.Update (eventTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EventTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EventTelemetryEN eventTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                if (eventTelemetry.Telemetry != null) {
                        // Argumento OID y no colección.
                        eventTelemetry.Telemetry = (MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN), eventTelemetry.Telemetry.Id);

                        eventTelemetry.Telemetry.TypeTelemetry
                                = eventTelemetry;
                }

                session.Save (eventTelemetry);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EventTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventTelemetry.Id;
}

public void Modify (EventTelemetryEN eventTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                EventTelemetryEN eventTelemetryEN = (EventTelemetryEN)session.Load (typeof(EventTelemetryEN), eventTelemetry.Id);

                eventTelemetryEN.Name = eventTelemetry.Name;


                eventTelemetryEN.Severity = eventTelemetry.Severity;

                session.Update (eventTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EventTelemetryCAD.", ex);
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
                EventTelemetryEN eventTelemetryEN = (EventTelemetryEN)session.Load (typeof(EventTelemetryEN), id);
                session.Delete (eventTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EventTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: EventTelemetryEN
public EventTelemetryEN ReadOID (int id
                                 )
{
        EventTelemetryEN eventTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                eventTelemetryEN = (EventTelemetryEN)session.Get (typeof(EventTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EventTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return eventTelemetryEN;
}

public System.Collections.Generic.IList<EventTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<EventTelemetryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(EventTelemetryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<EventTelemetryEN>();
                else
                        result = session.CreateCriteria (typeof(EventTelemetryEN)).List<EventTelemetryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in EventTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
