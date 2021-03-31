
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
 * Clase PatientProfile:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class PatientProfileCAD : BasicCAD, IPatientProfileCAD
{
public PatientProfileCAD() : base ()
{
}

public PatientProfileCAD(ISession sessionAux) : base (sessionAux)
{
}



public PatientProfileEN ReadOIDDefault (int id
                                        )
{
        PatientProfileEN patientProfileEN = null;

        try
        {
                SessionInitializeTransaction ();
                patientProfileEN = (PatientProfileEN)session.Get (typeof(PatientProfileEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientProfileEN;
}

public System.Collections.Generic.IList<PatientProfileEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PatientProfileEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PatientProfileEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PatientProfileEN>();
                        else
                                result = session.CreateCriteria (typeof(PatientProfileEN)).List<PatientProfileEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PatientProfileEN patientProfile)
{
        try
        {
                SessionInitializeTransaction ();
                PatientProfileEN patientProfileEN = (PatientProfileEN)session.Load (typeof(PatientProfileEN), patientProfile.Id);


                patientProfileEN.PreferredLanguage = patientProfile.PreferredLanguage;


                patientProfileEN.Region = patientProfile.Region;


                patientProfileEN.HazardAvoidance = patientProfile.HazardAvoidance;





                patientProfileEN.Name = patientProfile.Name;


                patientProfileEN.Description = patientProfile.Description;

                session.Update (patientProfileEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PatientProfileEN patientProfile)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (patientProfile);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientProfile.Id;
}

public void Modify (PatientProfileEN patientProfile)
{
        try
        {
                SessionInitializeTransaction ();
                PatientProfileEN patientProfileEN = (PatientProfileEN)session.Load (typeof(PatientProfileEN), patientProfile.Id);

                patientProfileEN.PreferredLanguage = patientProfile.PreferredLanguage;


                patientProfileEN.Region = patientProfile.Region;


                patientProfileEN.HazardAvoidance = patientProfile.HazardAvoidance;


                patientProfileEN.Name = patientProfile.Name;


                patientProfileEN.Description = patientProfile.Description;

                session.Update (patientProfileEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
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
                PatientProfileEN patientProfileEN = (PatientProfileEN)session.Load (typeof(PatientProfileEN), id);
                session.Delete (patientProfileEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PatientProfileEN
public PatientProfileEN ReadOID (int id
                                 )
{
        PatientProfileEN patientProfileEN = null;

        try
        {
                SessionInitializeTransaction ();
                patientProfileEN = (PatientProfileEN)session.Get (typeof(PatientProfileEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientProfileEN;
}

public System.Collections.Generic.IList<PatientProfileEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PatientProfileEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PatientProfileEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PatientProfileEN>();
                else
                        result = session.CreateCriteria (typeof(PatientProfileEN)).List<PatientProfileEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

//Sin e: ReadOID2
//Con e: PatientProfileEN
public PatientProfileEN ReadOID2 (int id
                                  )
{
        PatientProfileEN patientProfileEN = null;

        try
        {
                SessionInitializeTransaction ();
                patientProfileEN = (PatientProfileEN)session.Get (typeof(PatientProfileEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return patientProfileEN;
}

public System.Collections.Generic.IList<PatientProfileEN> ReadAll2 (int first, int size)
{
        System.Collections.Generic.IList<PatientProfileEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PatientProfileEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PatientProfileEN>();
                else
                        result = session.CreateCriteria (typeof(PatientProfileEN)).List<PatientProfileEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
