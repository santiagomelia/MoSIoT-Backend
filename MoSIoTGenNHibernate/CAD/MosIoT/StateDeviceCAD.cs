
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
 * Clase StateDevice:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class StateDeviceCAD : BasicCAD, IStateDeviceCAD
{
public StateDeviceCAD() : base ()
{
}

public StateDeviceCAD(ISession sessionAux) : base (sessionAux)
{
}



public StateDeviceEN ReadOIDDefault (int id
                                     )
{
        StateDeviceEN stateDeviceEN = null;

        try
        {
                SessionInitializeTransaction ();
                stateDeviceEN = (StateDeviceEN)session.Get (typeof(StateDeviceEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateDeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return stateDeviceEN;
}

public System.Collections.Generic.IList<StateDeviceEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<StateDeviceEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(StateDeviceEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<StateDeviceEN>();
                        else
                                result = session.CreateCriteria (typeof(StateDeviceEN)).List<StateDeviceEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateDeviceCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (StateDeviceEN stateDevice)
{
        try
        {
                SessionInitializeTransaction ();
                StateDeviceEN stateDeviceEN = (StateDeviceEN)session.Load (typeof(StateDeviceEN), stateDevice.Id);

                stateDeviceEN.Name = stateDevice.Name;


                stateDeviceEN.Value = stateDevice.Value;


                session.Update (stateDeviceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateDeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (StateDeviceEN stateDevice)
{
        try
        {
                SessionInitializeTransaction ();
                if (stateDevice.StateTelemetry != null) {
                        // Argumento OID y no colección.
                        stateDevice.StateTelemetry = (MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN), stateDevice.StateTelemetry.Id);

                        stateDevice.StateTelemetry.RangeStates
                        .Add (stateDevice);
                }

                session.Save (stateDevice);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateDeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return stateDevice.Id;
}

public void Modify (StateDeviceEN stateDevice)
{
        try
        {
                SessionInitializeTransaction ();
                StateDeviceEN stateDeviceEN = (StateDeviceEN)session.Load (typeof(StateDeviceEN), stateDevice.Id);

                stateDeviceEN.Name = stateDevice.Name;


                stateDeviceEN.Value = stateDevice.Value;

                session.Update (stateDeviceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateDeviceCAD.", ex);
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
                StateDeviceEN stateDeviceEN = (StateDeviceEN)session.Load (typeof(StateDeviceEN), id);
                session.Delete (stateDeviceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateDeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: StateDeviceEN
public StateDeviceEN ReadOID (int id
                              )
{
        StateDeviceEN stateDeviceEN = null;

        try
        {
                SessionInitializeTransaction ();
                stateDeviceEN = (StateDeviceEN)session.Get (typeof(StateDeviceEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateDeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return stateDeviceEN;
}

public System.Collections.Generic.IList<StateDeviceEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<StateDeviceEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(StateDeviceEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<StateDeviceEN>();
                else
                        result = session.CreateCriteria (typeof(StateDeviceEN)).List<StateDeviceEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateDeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
