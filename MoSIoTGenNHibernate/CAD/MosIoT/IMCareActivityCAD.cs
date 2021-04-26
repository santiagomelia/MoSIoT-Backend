
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
 * Clase IMCareActivity:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMCareActivityCAD : BasicCAD, IIMCareActivityCAD
{
public IMCareActivityCAD() : base ()
{
}

public IMCareActivityCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMCareActivityEN ReadOIDDefault (int id
                                        )
{
        IMCareActivityEN iMCareActivityEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMCareActivityEN = (IMCareActivityEN)session.Get (typeof(IMCareActivityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCareActivityEN;
}

public System.Collections.Generic.IList<IMCareActivityEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMCareActivityEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMCareActivityEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMCareActivityEN>();
                        else
                                result = session.CreateCriteria (typeof(IMCareActivityEN)).List<IMCareActivityEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMCareActivityEN iMCareActivity)
{
        try
        {
                SessionInitializeTransaction ();
                IMCareActivityEN iMCareActivityEN = (IMCareActivityEN)session.Load (typeof(IMCareActivityEN), iMCareActivity.Id);

                session.Update (iMCareActivityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMCareActivityEN iMCareActivity)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMCareActivity.Scenario != null) {
                        // Argumento OID y no colección.
                        iMCareActivity.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), iMCareActivity.Scenario.Id);

                        iMCareActivity.Scenario.Entity
                        .Add (iMCareActivity);
                }
                if (iMCareActivity.CareActivity != null) {
                        // Argumento OID y no colección.
                        iMCareActivity.CareActivity = (MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN), iMCareActivity.CareActivity.Id);
                }

                session.Save (iMCareActivity);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCareActivity.Id;
}

public void Modify (IMCareActivityEN iMCareActivity)
{
        try
        {
                SessionInitializeTransaction ();
                IMCareActivityEN iMCareActivityEN = (IMCareActivityEN)session.Load (typeof(IMCareActivityEN), iMCareActivity.Id);

                iMCareActivityEN.Name = iMCareActivity.Name;


                iMCareActivityEN.Description = iMCareActivity.Description;

                session.Update (iMCareActivityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityCAD.", ex);
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
                IMCareActivityEN iMCareActivityEN = (IMCareActivityEN)session.Load (typeof(IMCareActivityEN), id);
                session.Delete (iMCareActivityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMCareActivityEN
public IMCareActivityEN ReadOID (int id
                                 )
{
        IMCareActivityEN iMCareActivityEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMCareActivityEN = (IMCareActivityEN)session.Get (typeof(IMCareActivityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCareActivityEN;
}

public System.Collections.Generic.IList<IMCareActivityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMCareActivityEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMCareActivityEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMCareActivityEN>();
                else
                        result = session.CreateCriteria (typeof(IMCareActivityEN)).List<IMCareActivityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
