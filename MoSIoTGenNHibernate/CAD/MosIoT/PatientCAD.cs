
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
 * Clase Patient:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class PatientCAD : BasicCAD, IPatientCAD
{
public PatientCAD() : base ()
{
}

public PatientCAD(ISession sessionAux) : base (sessionAux)
{
}



public PatientEN ReadOIDDefault (int id
                                 )
{
        PatientEN patientEN = null;

        try
        {
                SessionInitializeTransaction ();
                patientEN = (PatientEN)session.Get (typeof(PatientEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientEN;
}

public System.Collections.Generic.IList<PatientEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PatientEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PatientEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PatientEN>();
                        else
                                result = session.CreateCriteria (typeof(PatientEN)).List<PatientEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PatientEN patient)
{
        try
        {
                SessionInitializeTransaction ();
                PatientEN patientEN = (PatientEN)session.Load (typeof(PatientEN), patient.Id);


                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PatientEN patient)
{
        try
        {
                SessionInitializeTransaction ();
                if (patient.Scenario != null) {
                        // Argumento OID y no colección.
                        patient.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), patient.Scenario.Id);

                        patient.Scenario.Entity
                        .Add (patient);
                }
                if (patient.PatientProfile != null) {
                        // Argumento OID y no colección.
                        patient.PatientProfile = (MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN), patient.PatientProfile.Id);
                }
                if (patient.UserPatient != null) {
                        // Argumento OID y no colección.
                        patient.UserPatient = (MoSIoTGenNHibernate.EN.MosIoT.UserEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.UserEN), patient.UserPatient.Id);

                        patient.UserPatient.Patient
                        .Add (patient);
                }

                session.Save (patient);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patient.Id;
}

public void Modify (PatientEN patient)
{
        try
        {
                SessionInitializeTransaction ();
                PatientEN patientEN = (PatientEN)session.Load (typeof(PatientEN), patient.Id);

                patientEN.Name = patient.Name;


                patientEN.Description = patient.Description;

                session.Update (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
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
                PatientEN patientEN = (PatientEN)session.Load (typeof(PatientEN), id);
                session.Delete (patientEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PatientEN
public PatientEN ReadOID (int id
                          )
{
        PatientEN patientEN = null;

        try
        {
                SessionInitializeTransaction ();
                patientEN = (PatientEN)session.Get (typeof(PatientEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientEN;
}

public System.Collections.Generic.IList<PatientEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PatientEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PatientEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PatientEN>();
                else
                        result = session.CreateCriteria (typeof(PatientEN)).List<PatientEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
