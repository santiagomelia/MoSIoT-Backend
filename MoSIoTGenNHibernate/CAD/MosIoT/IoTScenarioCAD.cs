
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
 * Clase IoTScenario:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IoTScenarioCAD : BasicCAD, IIoTScenarioCAD
{
public IoTScenarioCAD() : base ()
{
}

public IoTScenarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public IoTScenarioEN ReadOIDDefault (int id
                                     )
{
        IoTScenarioEN ioTScenarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                ioTScenarioEN = (IoTScenarioEN)session.Get (typeof(IoTScenarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ioTScenarioEN;
}

public System.Collections.Generic.IList<IoTScenarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IoTScenarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IoTScenarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IoTScenarioEN>();
                        else
                                result = session.CreateCriteria (typeof(IoTScenarioEN)).List<IoTScenarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IoTScenarioEN ioTScenario)
{
        try
        {
                SessionInitializeTransaction ();
                IoTScenarioEN ioTScenarioEN = (IoTScenarioEN)session.Load (typeof(IoTScenarioEN), ioTScenario.Id);

                ioTScenarioEN.Name = ioTScenario.Name;





                ioTScenarioEN.Description = ioTScenario.Description;

                session.Update (ioTScenarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IoTScenarioEN ioTScenario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (ioTScenario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ioTScenario.Id;
}

public void Modify (IoTScenarioEN ioTScenario)
{
        try
        {
                SessionInitializeTransaction ();
                IoTScenarioEN ioTScenarioEN = (IoTScenarioEN)session.Load (typeof(IoTScenarioEN), ioTScenario.Id);

                ioTScenarioEN.Name = ioTScenario.Name;


                ioTScenarioEN.Description = ioTScenario.Description;

                session.Update (ioTScenarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioCAD.", ex);
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
                IoTScenarioEN ioTScenarioEN = (IoTScenarioEN)session.Load (typeof(IoTScenarioEN), id);
                session.Delete (ioTScenarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IoTScenarioEN
public IoTScenarioEN ReadOID (int id
                              )
{
        IoTScenarioEN ioTScenarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                ioTScenarioEN = (IoTScenarioEN)session.Get (typeof(IoTScenarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return ioTScenarioEN;
}

public System.Collections.Generic.IList<IoTScenarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IoTScenarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IoTScenarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IoTScenarioEN>();
                else
                        result = session.CreateCriteria (typeof(IoTScenarioEN)).List<IoTScenarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
