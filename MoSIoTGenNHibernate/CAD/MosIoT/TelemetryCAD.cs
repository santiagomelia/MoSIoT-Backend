
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
 * Clase Telemetry:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class TelemetryCAD : BasicCAD, ITelemetryCAD
{
public TelemetryCAD() : base ()
{
}

public TelemetryCAD(ISession sessionAux) : base (sessionAux)
{
}



public TelemetryEN ReadOIDDefault (int id
                                   )
{
        TelemetryEN telemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                telemetryEN = (TelemetryEN)session.Get (typeof(TelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return telemetryEN;
}

public System.Collections.Generic.IList<TelemetryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TelemetryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TelemetryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<TelemetryEN>();
                        else
                                result = session.CreateCriteria (typeof(TelemetryEN)).List<TelemetryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TelemetryEN telemetry)
{
        try
        {
                SessionInitializeTransaction ();
                TelemetryEN telemetryEN = (TelemetryEN)session.Load (typeof(TelemetryEN), telemetry.Id);


                telemetryEN.Frecuency = telemetry.Frecuency;



                telemetryEN.Schema = telemetry.Schema;


                telemetryEN.Unit = telemetry.Unit;


                telemetryEN.Name = telemetry.Name;


                telemetryEN.Type = telemetry.Type;




                session.Update (telemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (TelemetryEN telemetry)
{
        try
        {
                SessionInitializeTransaction ();
                if (telemetry.DeviceTemplate != null) {
                        // Argumento OID y no colección.
                        telemetry.DeviceTemplate = (MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN), telemetry.DeviceTemplate.Id);

                        telemetry.DeviceTemplate.Telemetry
                        .Add (telemetry);
                }

                session.Save (telemetry);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return telemetry.Id;
}

public void Modify (TelemetryEN telemetry)
{
        try
        {
                SessionInitializeTransaction ();
                TelemetryEN telemetryEN = (TelemetryEN)session.Load (typeof(TelemetryEN), telemetry.Id);

                telemetryEN.Frecuency = telemetry.Frecuency;


                telemetryEN.Schema = telemetry.Schema;


                telemetryEN.Unit = telemetry.Unit;


                telemetryEN.Name = telemetry.Name;


                telemetryEN.Type = telemetry.Type;

                session.Update (telemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryCAD.", ex);
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
                TelemetryEN telemetryEN = (TelemetryEN)session.Load (typeof(TelemetryEN), id);
                session.Delete (telemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: TelemetryEN
public TelemetryEN ReadOID (int id
                            )
{
        TelemetryEN telemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                telemetryEN = (TelemetryEN)session.Get (typeof(TelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return telemetryEN;
}

public System.Collections.Generic.IList<TelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TelemetryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TelemetryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TelemetryEN>();
                else
                        result = session.CreateCriteria (typeof(TelemetryEN)).List<TelemetryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AsignarSpecific (int p_Telemetry_OID, int p_typeTelemetry_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetryEN = null;
        try
        {
                SessionInitializeTransaction ();
                telemetryEN = (TelemetryEN)session.Load (typeof(TelemetryEN), p_Telemetry_OID);
                telemetryEN.TypeTelemetry = (MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN), p_typeTelemetry_OID);

                telemetryEN.TypeTelemetry.Telemetry = telemetryEN;




                session.Update (telemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
