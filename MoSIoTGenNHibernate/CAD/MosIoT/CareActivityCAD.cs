
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
 * Clase CareActivity:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class CareActivityCAD : BasicCAD, ICareActivityCAD
{
public CareActivityCAD() : base ()
{
}

public CareActivityCAD(ISession sessionAux) : base (sessionAux)
{
}



public CareActivityEN ReadOIDDefault (int id
                                      )
{
        CareActivityEN careActivityEN = null;

        try
        {
                SessionInitializeTransaction ();
                careActivityEN = (CareActivityEN)session.Get (typeof(CareActivityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return careActivityEN;
}

public System.Collections.Generic.IList<CareActivityEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CareActivityEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CareActivityEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CareActivityEN>();
                        else
                                result = session.CreateCriteria (typeof(CareActivityEN)).List<CareActivityEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CareActivityEN careActivity)
{
        try
        {
                SessionInitializeTransaction ();
                CareActivityEN careActivityEN = (CareActivityEN)session.Load (typeof(CareActivityEN), careActivity.Id);


                careActivityEN.Periodicity = careActivity.Periodicity;


                careActivityEN.Description = careActivity.Description;


                careActivityEN.Duration = careActivity.Duration;



                careActivityEN.Location = careActivity.Location;


                careActivityEN.OutcomeCode = careActivity.OutcomeCode;



                careActivityEN.TypeActivity = careActivity.TypeActivity;



                careActivityEN.ActivityCode = careActivity.ActivityCode;


                careActivityEN.Name = careActivity.Name;


                session.Update (careActivityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CareActivityEN careActivity)
{
        try
        {
                SessionInitializeTransaction ();
                if (careActivity.CarePlan != null) {
                        // Argumento OID y no colección.
                        careActivity.CarePlan = (MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN), careActivity.CarePlan.Id);

                        careActivity.CarePlan.CareActivity
                        .Add (careActivity);
                }

                session.Save (careActivity);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return careActivity.Id;
}

public void Modify (CareActivityEN careActivity)
{
        try
        {
                SessionInitializeTransaction ();
                CareActivityEN careActivityEN = (CareActivityEN)session.Load (typeof(CareActivityEN), careActivity.Id);

                careActivityEN.Periodicity = careActivity.Periodicity;


                careActivityEN.Description = careActivity.Description;


                careActivityEN.Duration = careActivity.Duration;


                careActivityEN.Location = careActivity.Location;


                careActivityEN.OutcomeCode = careActivity.OutcomeCode;


                careActivityEN.TypeActivity = careActivity.TypeActivity;


                careActivityEN.ActivityCode = careActivity.ActivityCode;


                careActivityEN.Name = careActivity.Name;

                session.Update (careActivityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityCAD.", ex);
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
                CareActivityEN careActivityEN = (CareActivityEN)session.Load (typeof(CareActivityEN), id);
                session.Delete (careActivityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: CareActivityEN
public CareActivityEN ReadOID (int id
                               )
{
        CareActivityEN careActivityEN = null;

        try
        {
                SessionInitializeTransaction ();
                careActivityEN = (CareActivityEN)session.Get (typeof(CareActivityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return careActivityEN;
}

public System.Collections.Generic.IList<CareActivityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CareActivityEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CareActivityEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CareActivityEN>();
                else
                        result = session.CreateCriteria (typeof(CareActivityEN)).List<CareActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
