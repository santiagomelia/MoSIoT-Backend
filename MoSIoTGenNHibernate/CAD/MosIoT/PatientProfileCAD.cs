
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

public void AssignCarePlanTemplate (int p_PatientProfile_OID, System.Collections.Generic.IList<int> p_carePlanTemplate_OIDs)
{
        MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfileEN = null;
        try
        {
                SessionInitializeTransaction ();
                patientProfileEN = (PatientProfileEN)session.Load (typeof(PatientProfileEN), p_PatientProfile_OID);
                MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplateENAux = null;
                if (patientProfileEN.CarePlanTemplate == null) {
                        patientProfileEN.CarePlanTemplate = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN>();
                }

                foreach (int item in p_carePlanTemplate_OIDs) {
                        carePlanTemplateENAux = new MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN ();
                        carePlanTemplateENAux = (MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN), item);
                        carePlanTemplateENAux.PatientProfile = patientProfileEN;

                        patientProfileEN.CarePlanTemplate.Add (carePlanTemplateENAux);
                }


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
}
}
