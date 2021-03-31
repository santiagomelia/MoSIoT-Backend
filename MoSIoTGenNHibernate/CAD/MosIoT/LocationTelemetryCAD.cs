
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
 * Clase LocationTelemetry:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class LocationTelemetryCAD : BasicCAD, ILocationTelemetryCAD
{
public LocationTelemetryCAD() : base ()
{
}

public LocationTelemetryCAD(ISession sessionAux) : base (sessionAux)
{
}



public LocationTelemetryEN ReadOIDDefault (int id
                                           )
{
        LocationTelemetryEN locationTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                locationTelemetryEN = (LocationTelemetryEN)session.Get (typeof(LocationTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in LocationTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return locationTelemetryEN;
}

public System.Collections.Generic.IList<LocationTelemetryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LocationTelemetryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LocationTelemetryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<LocationTelemetryEN>();
                        else
                                result = session.CreateCriteria (typeof(LocationTelemetryEN)).List<LocationTelemetryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in LocationTelemetryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LocationTelemetryEN locationTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                LocationTelemetryEN locationTelemetryEN = (LocationTelemetryEN)session.Load (typeof(LocationTelemetryEN), locationTelemetry.Id);

                locationTelemetryEN.Latitude = locationTelemetry.Latitude;


                locationTelemetryEN.Longitude = locationTelemetry.Longitude;


                locationTelemetryEN.Altitude = locationTelemetry.Altitude;

                session.Update (locationTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in LocationTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (LocationTelemetryEN locationTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                if (locationTelemetry.Telemetry != null) {
                        // Argumento OID y no colección.
                        locationTelemetry.Telemetry = (MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN), locationTelemetry.Telemetry.Id);

                        locationTelemetry.Telemetry.TypeTelemetry
                                = locationTelemetry;
                }

                session.Save (locationTelemetry);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in LocationTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return locationTelemetry.Id;
}

public void Modify (LocationTelemetryEN locationTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                LocationTelemetryEN locationTelemetryEN = (LocationTelemetryEN)session.Load (typeof(LocationTelemetryEN), locationTelemetry.Id);

                locationTelemetryEN.Name = locationTelemetry.Name;


                locationTelemetryEN.Latitude = locationTelemetry.Latitude;


                locationTelemetryEN.Longitude = locationTelemetry.Longitude;


                locationTelemetryEN.Altitude = locationTelemetry.Altitude;

                session.Update (locationTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in LocationTelemetryCAD.", ex);
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
                LocationTelemetryEN locationTelemetryEN = (LocationTelemetryEN)session.Load (typeof(LocationTelemetryEN), id);
                session.Delete (locationTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in LocationTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: LocationTelemetryEN
public LocationTelemetryEN ReadOID (int id
                                    )
{
        LocationTelemetryEN locationTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                locationTelemetryEN = (LocationTelemetryEN)session.Get (typeof(LocationTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in LocationTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return locationTelemetryEN;
}

public System.Collections.Generic.IList<LocationTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LocationTelemetryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(LocationTelemetryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<LocationTelemetryEN>();
                else
                        result = session.CreateCriteria (typeof(LocationTelemetryEN)).List<LocationTelemetryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in LocationTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
