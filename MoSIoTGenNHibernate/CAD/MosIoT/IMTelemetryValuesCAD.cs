
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
 * Clase IMTelemetryValues:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMTelemetryValuesCAD : BasicCAD, IIMTelemetryValuesCAD
{
public IMTelemetryValuesCAD() : base ()
{
}

public IMTelemetryValuesCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMTelemetryValuesEN ReadOIDDefault (int id
                                           )
{
        IMTelemetryValuesEN iMTelemetryValuesEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMTelemetryValuesEN = (IMTelemetryValuesEN)session.Get (typeof(IMTelemetryValuesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryValuesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMTelemetryValuesEN;
}

public System.Collections.Generic.IList<IMTelemetryValuesEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMTelemetryValuesEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMTelemetryValuesEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMTelemetryValuesEN>();
                        else
                                result = session.CreateCriteria (typeof(IMTelemetryValuesEN)).List<IMTelemetryValuesEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryValuesCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMTelemetryValuesEN iMTelemetryValues)
{
        try
        {
                SessionInitializeTransaction ();
                IMTelemetryValuesEN iMTelemetryValuesEN = (IMTelemetryValuesEN)session.Load (typeof(IMTelemetryValuesEN), iMTelemetryValues.Id);

                iMTelemetryValuesEN.TimeStamp = iMTelemetryValues.TimeStamp;


                iMTelemetryValuesEN.Valu = iMTelemetryValues.Valu;


                session.Update (iMTelemetryValuesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryValuesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMTelemetryValuesEN iMTelemetryValues)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMTelemetryValues.IMTelemetry != null) {
                        // Argumento OID y no colección.
                        iMTelemetryValues.IMTelemetry = (MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN), iMTelemetryValues.IMTelemetry.Id);

                        iMTelemetryValues.IMTelemetry.IMTelemetryValues
                        .Add (iMTelemetryValues);
                }

                session.Save (iMTelemetryValues);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryValuesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMTelemetryValues.Id;
}

public void Modify (IMTelemetryValuesEN iMTelemetryValues)
{
        try
        {
                SessionInitializeTransaction ();
                IMTelemetryValuesEN iMTelemetryValuesEN = (IMTelemetryValuesEN)session.Load (typeof(IMTelemetryValuesEN), iMTelemetryValues.Id);

                iMTelemetryValuesEN.TimeStamp = iMTelemetryValues.TimeStamp;


                iMTelemetryValuesEN.Valu = iMTelemetryValues.Valu;

                session.Update (iMTelemetryValuesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryValuesCAD.", ex);
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
                IMTelemetryValuesEN iMTelemetryValuesEN = (IMTelemetryValuesEN)session.Load (typeof(IMTelemetryValuesEN), id);
                session.Delete (iMTelemetryValuesEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryValuesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMTelemetryValuesEN
public IMTelemetryValuesEN ReadOID (int id
                                    )
{
        IMTelemetryValuesEN iMTelemetryValuesEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMTelemetryValuesEN = (IMTelemetryValuesEN)session.Get (typeof(IMTelemetryValuesEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryValuesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMTelemetryValuesEN;
}

public System.Collections.Generic.IList<IMTelemetryValuesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMTelemetryValuesEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMTelemetryValuesEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMTelemetryValuesEN>();
                else
                        result = session.CreateCriteria (typeof(IMTelemetryValuesEN)).List<IMTelemetryValuesEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryValuesCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
