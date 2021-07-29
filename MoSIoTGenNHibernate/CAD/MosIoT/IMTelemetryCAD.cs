
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
 * Clase IMTelemetry:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMTelemetryCAD : BasicCAD, IIMTelemetryCAD
{
public IMTelemetryCAD() : base ()
{
}

public IMTelemetryCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMTelemetryEN ReadOIDDefault (int id
                                     )
{
        IMTelemetryEN iMTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMTelemetryEN = (IMTelemetryEN)session.Get (typeof(IMTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMTelemetryEN;
}

public System.Collections.Generic.IList<IMTelemetryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMTelemetryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMTelemetryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMTelemetryEN>();
                        else
                                result = session.CreateCriteria (typeof(IMTelemetryEN)).List<IMTelemetryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMTelemetryEN iMTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                IMTelemetryEN iMTelemetryEN = (IMTelemetryEN)session.Load (typeof(IMTelemetryEN), iMTelemetry.Id);

                session.Update (iMTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMTelemetryEN iMTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMTelemetry.Scenario != null) {
                        // Argumento OID y no colección.
                        iMTelemetry.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), iMTelemetry.Scenario.Id);

                        iMTelemetry.Scenario.Entity
                        .Add (iMTelemetry);
                }

                session.Save (iMTelemetry);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMTelemetry.Id;
}

public void Modify (IMTelemetryEN iMTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                IMTelemetryEN iMTelemetryEN = (IMTelemetryEN)session.Load (typeof(IMTelemetryEN), iMTelemetry.Id);

                iMTelemetryEN.Name = iMTelemetry.Name;


                iMTelemetryEN.Description = iMTelemetry.Description;

                session.Update (iMTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryCAD.", ex);
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
                IMTelemetryEN iMTelemetryEN = (IMTelemetryEN)session.Load (typeof(IMTelemetryEN), id);
                session.Delete (iMTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMTelemetryEN
public IMTelemetryEN ReadOID (int id
                              )
{
        IMTelemetryEN iMTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMTelemetryEN = (IMTelemetryEN)session.Get (typeof(IMTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMTelemetryEN;
}

public System.Collections.Generic.IList<IMTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMTelemetryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMTelemetryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMTelemetryEN>();
                else
                        result = session.CreateCriteria (typeof(IMTelemetryEN)).List<IMTelemetryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AssignTelemetry (int p_IMTelemetry_OID, int p_telemetry_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN iMTelemetryEN = null;
        try
        {
                SessionInitializeTransaction ();
                iMTelemetryEN = (IMTelemetryEN)session.Load (typeof(IMTelemetryEN), p_IMTelemetry_OID);
                iMTelemetryEN.Telemetry = (MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN), p_telemetry_OID);



                session.Update (iMTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
