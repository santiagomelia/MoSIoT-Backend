
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
 * Clase PatientAccess:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class PatientAccessCAD : BasicCAD, IPatientAccessCAD
{
public PatientAccessCAD() : base ()
{
}

public PatientAccessCAD(ISession sessionAux) : base (sessionAux)
{
}



public PatientAccessEN ReadOIDDefault (int id
                                       )
{
        PatientAccessEN patientAccessEN = null;

        try
        {
                SessionInitializeTransaction ();
                patientAccessEN = (PatientAccessEN)session.Get (typeof(PatientAccessEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientAccessCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientAccessEN;
}

public System.Collections.Generic.IList<PatientAccessEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PatientAccessEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PatientAccessEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PatientAccessEN>();
                        else
                                result = session.CreateCriteria (typeof(PatientAccessEN)).List<PatientAccessEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientAccessCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PatientAccessEN patientAccess)
{
        try
        {
                SessionInitializeTransaction ();
                PatientAccessEN patientAccessEN = (PatientAccessEN)session.Load (typeof(PatientAccessEN), patientAccess.Id);

                session.Update (patientAccessEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientAccessCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PatientAccessEN patientAccess)
{
        try
        {
                SessionInitializeTransaction ();
                if (patientAccess.Scenario != null) {
                        // Argumento OID y no colección.
                        patientAccess.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), patientAccess.Scenario.Id);

                        patientAccess.Scenario.Entity
                        .Add (patientAccess);
                }
                if (patientAccess.AccessMode != null) {
                        // Argumento OID y no colección.
                        patientAccess.AccessMode = (MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN), patientAccess.AccessMode.Id);
                }

                session.Save (patientAccess);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientAccessCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientAccess.Id;
}

public void Modify (PatientAccessEN patientAccess)
{
        try
        {
                SessionInitializeTransaction ();
                PatientAccessEN patientAccessEN = (PatientAccessEN)session.Load (typeof(PatientAccessEN), patientAccess.Id);

                patientAccessEN.Name = patientAccess.Name;


                patientAccessEN.Description = patientAccess.Description;

                session.Update (patientAccessEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientAccessCAD.", ex);
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
                PatientAccessEN patientAccessEN = (PatientAccessEN)session.Load (typeof(PatientAccessEN), id);
                session.Delete (patientAccessEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientAccessCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
