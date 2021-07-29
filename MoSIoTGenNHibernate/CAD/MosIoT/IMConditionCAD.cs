
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
 * Clase IMCondition:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMConditionCAD : BasicCAD, IIMConditionCAD
{
public IMConditionCAD() : base ()
{
}

public IMConditionCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMConditionEN ReadOIDDefault (int id
                                     )
{
        IMConditionEN iMConditionEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMConditionEN = (IMConditionEN)session.Get (typeof(IMConditionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMConditionEN;
}

public System.Collections.Generic.IList<IMConditionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMConditionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMConditionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMConditionEN>();
                        else
                                result = session.CreateCriteria (typeof(IMConditionEN)).List<IMConditionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMConditionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMConditionEN iMCondition)
{
        try
        {
                SessionInitializeTransaction ();
                IMConditionEN iMConditionEN = (IMConditionEN)session.Load (typeof(IMConditionEN), iMCondition.Id);

                session.Update (iMConditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMConditionEN iMCondition)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMCondition.Entity != null) {
                        // Argumento OID y no colección.
                        iMCondition.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMCondition.Entity.Id);

                        iMCondition.Entity.Attributes
                        .Add (iMCondition);
                }

                session.Save (iMCondition);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCondition.Id;
}

public void Modify (IMConditionEN iMCondition)
{
        try
        {
                SessionInitializeTransaction ();
                IMConditionEN iMConditionEN = (IMConditionEN)session.Load (typeof(IMConditionEN), iMCondition.Id);

                iMConditionEN.Name = iMCondition.Name;


                iMConditionEN.Description = iMCondition.Description;

                session.Update (iMConditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMConditionCAD.", ex);
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
                IMConditionEN iMConditionEN = (IMConditionEN)session.Load (typeof(IMConditionEN), id);
                session.Delete (iMConditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMConditionEN
public IMConditionEN ReadOID (int id
                              )
{
        IMConditionEN iMConditionEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMConditionEN = (IMConditionEN)session.Get (typeof(IMConditionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMConditionEN;
}

public System.Collections.Generic.IList<IMConditionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMConditionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMConditionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMConditionEN>();
                else
                        result = session.CreateCriteria (typeof(IMConditionEN)).List<IMConditionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AssignCondition (int p_IMCondition_OID, int p_condition_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.IMConditionEN iMConditionEN = null;
        try
        {
                SessionInitializeTransaction ();
                iMConditionEN = (IMConditionEN)session.Load (typeof(IMConditionEN), p_IMCondition_OID);
                iMConditionEN.Condition = (MoSIoTGenNHibernate.EN.MosIoT.ConditionEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.ConditionEN), p_condition_OID);



                session.Update (iMConditionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMConditionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
