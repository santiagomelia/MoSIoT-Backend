
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
 * Clase Condition:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class ConditionCAD : BasicCAD, IConditionCAD
{
public ConditionCAD() : base ()
{
}

public ConditionCAD(ISession sessionAux) : base (sessionAux)
{
}



public ConditionEN ReadOIDDefault (int id
                                   )
{
        ConditionEN conditionEN = null;

        try
        {
                SessionInitializeTransaction ();
                conditionEN = (ConditionEN)session.Get (typeof(ConditionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conditionEN;
}

public System.Collections.Generic.IList<ConditionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ConditionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ConditionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ConditionEN>();
                        else
                                result = session.CreateCriteria (typeof(ConditionEN)).List<ConditionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ConditionEN condition)
{
        try
        {
                SessionInitializeTransaction ();
                ConditionEN conditionEN = (ConditionEN)session.Load (typeof(ConditionEN), condition.Id);


                conditionEN.Description = condition.Description;



                conditionEN.ClinicalStatus = condition.ClinicalStatus;


                conditionEN.Disease = condition.Disease;



                conditionEN.Name = condition.Name;

                session.Update (conditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ConditionEN condition)
{
        try
        {
                SessionInitializeTransaction ();
                if (condition.PatientProfile != null) {
                        // Argumento OID y no colección.
                        condition.PatientProfile = (MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN), condition.PatientProfile.Id);

                        condition.PatientProfile.Diseases
                        .Add (condition);
                }

                session.Save (condition);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return condition.Id;
}

public void Modify (ConditionEN condition)
{
        try
        {
                SessionInitializeTransaction ();
                ConditionEN conditionEN = (ConditionEN)session.Load (typeof(ConditionEN), condition.Id);

                conditionEN.Description = condition.Description;


                conditionEN.ClinicalStatus = condition.ClinicalStatus;


                conditionEN.Disease = condition.Disease;


                conditionEN.Name = condition.Name;

                session.Update (conditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
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
                ConditionEN conditionEN = (ConditionEN)session.Load (typeof(ConditionEN), id);
                session.Delete (conditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: ConditionEN
public ConditionEN ReadOID (int id
                            )
{
        ConditionEN conditionEN = null;

        try
        {
                SessionInitializeTransaction ();
                conditionEN = (ConditionEN)session.Get (typeof(ConditionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return conditionEN;
}

public System.Collections.Generic.IList<ConditionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConditionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ConditionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<ConditionEN>();
                else
                        result = session.CreateCriteria (typeof(ConditionEN)).List<ConditionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
