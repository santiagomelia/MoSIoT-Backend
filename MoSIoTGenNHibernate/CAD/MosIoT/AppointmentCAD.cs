
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
 * Clase Appointment:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class AppointmentCAD : BasicCAD, IAppointmentCAD
{
public AppointmentCAD() : base ()
{
}

public AppointmentCAD(ISession sessionAux) : base (sessionAux)
{
}



public AppointmentEN ReadOIDDefault (int id
                                     )
{
        AppointmentEN appointmentEN = null;

        try
        {
                SessionInitializeTransaction ();
                appointmentEN = (AppointmentEN)session.Get (typeof(AppointmentEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return appointmentEN;
}

public System.Collections.Generic.IList<AppointmentEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AppointmentEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AppointmentEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AppointmentEN>();
                        else
                                result = session.CreateCriteria (typeof(AppointmentEN)).List<AppointmentEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AppointmentCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AppointmentEN appointment)
{
        try
        {
                SessionInitializeTransaction ();
                AppointmentEN appointmentEN = (AppointmentEN)session.Load (typeof(AppointmentEN), appointment.Id);

                appointmentEN.IsVirtual = appointment.IsVirtual;


                appointmentEN.Description = appointment.Description;


                appointmentEN.Direction = appointment.Direction;


                appointmentEN.ReasonCode = appointment.ReasonCode;


                session.Update (appointmentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AppointmentEN appointment)
{
        try
        {
                SessionInitializeTransaction ();
                if (appointment.CareActivity != null) {
                        // Argumento OID y no colección.
                        appointment.CareActivity = (MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN), appointment.CareActivity.Id);

                        appointment.CareActivity.Appointment
                                = appointment;
                }

                session.Save (appointment);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return appointment.Id;
}

public void Modify (AppointmentEN appointment)
{
        try
        {
                SessionInitializeTransaction ();
                AppointmentEN appointmentEN = (AppointmentEN)session.Load (typeof(AppointmentEN), appointment.Id);

                appointmentEN.IsVirtual = appointment.IsVirtual;


                appointmentEN.Description = appointment.Description;


                appointmentEN.Direction = appointment.Direction;


                appointmentEN.ReasonCode = appointment.ReasonCode;

                session.Update (appointmentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AppointmentCAD.", ex);
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
                AppointmentEN appointmentEN = (AppointmentEN)session.Load (typeof(AppointmentEN), id);
                session.Delete (appointmentEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AppointmentEN
public AppointmentEN ReadOID (int id
                              )
{
        AppointmentEN appointmentEN = null;

        try
        {
                SessionInitializeTransaction ();
                appointmentEN = (AppointmentEN)session.Get (typeof(AppointmentEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return appointmentEN;
}

public System.Collections.Generic.IList<AppointmentEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AppointmentEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AppointmentEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AppointmentEN>();
                else
                        result = session.CreateCriteria (typeof(AppointmentEN)).List<AppointmentEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AppointmentCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
