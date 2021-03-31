
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
 * Clase SpecificTelemetry:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class SpecificTelemetryCAD : BasicCAD, ISpecificTelemetryCAD
{
public SpecificTelemetryCAD() : base ()
{
}

public SpecificTelemetryCAD(ISession sessionAux) : base (sessionAux)
{
}



public SpecificTelemetryEN ReadOIDDefault (int id
                                           )
{
        SpecificTelemetryEN specificTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                specificTelemetryEN = (SpecificTelemetryEN)session.Get (typeof(SpecificTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SpecificTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return specificTelemetryEN;
}

public System.Collections.Generic.IList<SpecificTelemetryEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<SpecificTelemetryEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(SpecificTelemetryEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<SpecificTelemetryEN>();
                        else
                                result = session.CreateCriteria (typeof(SpecificTelemetryEN)).List<SpecificTelemetryEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SpecificTelemetryCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (SpecificTelemetryEN specificTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                SpecificTelemetryEN specificTelemetryEN = (SpecificTelemetryEN)session.Load (typeof(SpecificTelemetryEN), specificTelemetry.Id);


                specificTelemetryEN.Name = specificTelemetry.Name;

                session.Update (specificTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SpecificTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (SpecificTelemetryEN specificTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                if (specificTelemetry.Telemetry != null) {
                        // Argumento OID y no colección.
                        specificTelemetry.Telemetry = (MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN), specificTelemetry.Telemetry.Id);

                        specificTelemetry.Telemetry.TypeTelemetry
                                = specificTelemetry;
                }

                session.Save (specificTelemetry);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SpecificTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return specificTelemetry.Id;
}

public void Modify (SpecificTelemetryEN specificTelemetry)
{
        try
        {
                SessionInitializeTransaction ();
                SpecificTelemetryEN specificTelemetryEN = (SpecificTelemetryEN)session.Load (typeof(SpecificTelemetryEN), specificTelemetry.Id);

                specificTelemetryEN.Name = specificTelemetry.Name;

                session.Update (specificTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SpecificTelemetryCAD.", ex);
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
                SpecificTelemetryEN specificTelemetryEN = (SpecificTelemetryEN)session.Load (typeof(SpecificTelemetryEN), id);
                session.Delete (specificTelemetryEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SpecificTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: SpecificTelemetryEN
public SpecificTelemetryEN ReadOID (int id
                                    )
{
        SpecificTelemetryEN specificTelemetryEN = null;

        try
        {
                SessionInitializeTransaction ();
                specificTelemetryEN = (SpecificTelemetryEN)session.Get (typeof(SpecificTelemetryEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SpecificTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return specificTelemetryEN;
}

public System.Collections.Generic.IList<SpecificTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SpecificTelemetryEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(SpecificTelemetryEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<SpecificTelemetryEN>();
                else
                        result = session.CreateCriteria (typeof(SpecificTelemetryEN)).List<SpecificTelemetryEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in SpecificTelemetryCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
