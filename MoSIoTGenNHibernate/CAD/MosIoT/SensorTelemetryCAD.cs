
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
 * Clase SensorTelemetry:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class SensorTelemetryCAD : BasicCAD, ISensorTelemetryCAD
{
public SensorTelemetryCAD() : base ()
{
}

public SensorTelemetryCAD(ISession sessionAux) : base (sessionAux)
{
}



public SensorTelemetryEN ReadOIDDefault (int id
                                         )
{
        SensorTelemetryEN sensorTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                sensorTelemetryEN = (SensorTelemetryEN)session.Get (typeof(SensorTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SensorTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sensorTelemetryEN;
}

public System.Collections.Generic.IList<SensorTelemetryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SensorTelemetryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SensorTelemetryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SensorTelemetryEN>();
                        else
                                result = session.CreateCriteria (typeof(SensorTelemetryEN)).List<SensorTelemetryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SensorTelemetryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SensorTelemetryEN sensorTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                SensorTelemetryEN sensorTelemetryEN = (SensorTelemetryEN)session.Load (typeof(SensorTelemetryEN), sensorTelemetry.Id);

                sensorTelemetryEN.SensorType = sensorTelemetry.SensorType;

                session.Update (sensorTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SensorTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (SensorTelemetryEN sensorTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                if (sensorTelemetry.Telemetry != null) {
                        // Argumento OID y no colección.
                        sensorTelemetry.Telemetry = (MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN), sensorTelemetry.Telemetry.Id);

                        sensorTelemetry.Telemetry.TypeTelemetry
                                = sensorTelemetry;
                }

                session.Save (sensorTelemetry);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SensorTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sensorTelemetry.Id;
}

public void Modify (SensorTelemetryEN sensorTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                SensorTelemetryEN sensorTelemetryEN = (SensorTelemetryEN)session.Load (typeof(SensorTelemetryEN), sensorTelemetry.Id);

                sensorTelemetryEN.Name = sensorTelemetry.Name;


                sensorTelemetryEN.SensorType = sensorTelemetry.SensorType;

                session.Update (sensorTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SensorTelemetryCAD.", ex);
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
                SensorTelemetryEN sensorTelemetryEN = (SensorTelemetryEN)session.Load (typeof(SensorTelemetryEN), id);
                session.Delete (sensorTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SensorTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SensorTelemetryEN
public SensorTelemetryEN ReadOID (int id
                                  )
{
        SensorTelemetryEN sensorTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                sensorTelemetryEN = (SensorTelemetryEN)session.Get (typeof(SensorTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SensorTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return sensorTelemetryEN;
}

public System.Collections.Generic.IList<SensorTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SensorTelemetryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SensorTelemetryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SensorTelemetryEN>();
                else
                        result = session.CreateCriteria (typeof(SensorTelemetryEN)).List<SensorTelemetryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SensorTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
