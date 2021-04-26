
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
 * Clase IMAppointment:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMAppointmentCAD : BasicCAD, IIMAppointmentCAD
{
public IMAppointmentCAD() : base ()
{
}

public IMAppointmentCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMAppointmentEN ReadOIDDefault (int id
                                       )
{
        IMAppointmentEN iMAppointmentEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMAppointmentEN = (IMAppointmentEN)session.Get (typeof(IMAppointmentEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAppointmentEN;
}

public System.Collections.Generic.IList<IMAppointmentEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMAppointmentEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMAppointmentEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMAppointmentEN>();
                        else
                                result = session.CreateCriteria (typeof(IMAppointmentEN)).List<IMAppointmentEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAppointmentCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMAppointmentEN iMAppointment)
{
        try
        {
                SessionInitializeTransaction ();
                IMAppointmentEN iMAppointmentEN = (IMAppointmentEN)session.Load (typeof(IMAppointmentEN), iMAppointment.Id);

                iMAppointmentEN.Date = iMAppointment.Date;


                session.Update (iMAppointmentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMAppointmentEN iMAppointment)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMAppointment.Scenario != null) {
                        // Argumento OID y no colección.
                        iMAppointment.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), iMAppointment.Scenario.Id);

                        iMAppointment.Scenario.Entity
                        .Add (iMAppointment);
                }
                if (iMAppointment.Appointment != null) {
                        // Argumento OID y no colección.
                        iMAppointment.Appointment = (MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN), iMAppointment.Appointment.Id);
                }

                session.Save (iMAppointment);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAppointment.Id;
}

public void Modify (IMAppointmentEN iMAppointment)
{
        try
        {
                SessionInitializeTransaction ();
                IMAppointmentEN iMAppointmentEN = (IMAppointmentEN)session.Load (typeof(IMAppointmentEN), iMAppointment.Id);

                iMAppointmentEN.Name = iMAppointment.Name;


                iMAppointmentEN.Description = iMAppointment.Description;


                iMAppointmentEN.Date = iMAppointment.Date;

                session.Update (iMAppointmentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAppointmentCAD.", ex);
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
                IMAppointmentEN iMAppointmentEN = (IMAppointmentEN)session.Load (typeof(IMAppointmentEN), id);
                session.Delete (iMAppointmentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMAppointmentEN
public IMAppointmentEN ReadOID (int id
                                )
{
        IMAppointmentEN iMAppointmentEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMAppointmentEN = (IMAppointmentEN)session.Get (typeof(IMAppointmentEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAppointmentEN;
}

public System.Collections.Generic.IList<IMAppointmentEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMAppointmentEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMAppointmentEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMAppointmentEN>();
                else
                        result = session.CreateCriteria (typeof(IMAppointmentEN)).List<IMAppointmentEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
