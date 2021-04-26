
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
 * Clase IMNutritionOrder:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMNutritionOrderCAD : BasicCAD, IIMNutritionOrderCAD
{
public IMNutritionOrderCAD() : base ()
{
}

public IMNutritionOrderCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMNutritionOrderEN ReadOIDDefault (int id
                                          )
{
        IMNutritionOrderEN iMNutritionOrderEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMNutritionOrderEN = (IMNutritionOrderEN)session.Get (typeof(IMNutritionOrderEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMNutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMNutritionOrderEN;
}

public System.Collections.Generic.IList<IMNutritionOrderEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMNutritionOrderEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMNutritionOrderEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMNutritionOrderEN>();
                        else
                                result = session.CreateCriteria (typeof(IMNutritionOrderEN)).List<IMNutritionOrderEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMNutritionOrderCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMNutritionOrderEN iMNutritionOrder)
{
        try
        {
                SessionInitializeTransaction ();
                IMNutritionOrderEN iMNutritionOrderEN = (IMNutritionOrderEN)session.Load (typeof(IMNutritionOrderEN), iMNutritionOrder.Id);

                session.Update (iMNutritionOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMNutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMNutritionOrderEN iMNutritionOrder)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMNutritionOrder.Entity != null) {
                        // Argumento OID y no colección.
                        iMNutritionOrder.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMNutritionOrder.Entity.Id);

                        iMNutritionOrder.Entity.Attributes
                        .Add (iMNutritionOrder);
                }
                if (iMNutritionOrder.NutritionOrder != null) {
                        // Argumento OID y no colección.
                        iMNutritionOrder.NutritionOrder = (MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN), iMNutritionOrder.NutritionOrder.Id);
                }

                session.Save (iMNutritionOrder);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMNutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMNutritionOrder.Id;
}

public void Modify (IMNutritionOrderEN iMNutritionOrder)
{
        try
        {
                SessionInitializeTransaction ();
                IMNutritionOrderEN iMNutritionOrderEN = (IMNutritionOrderEN)session.Load (typeof(IMNutritionOrderEN), iMNutritionOrder.Id);

                iMNutritionOrderEN.Name = iMNutritionOrder.Name;


                iMNutritionOrderEN.Type = iMNutritionOrder.Type;


                iMNutritionOrderEN.IsOID = iMNutritionOrder.IsOID;


                iMNutritionOrderEN.IsWritable = iMNutritionOrder.IsWritable;


                iMNutritionOrderEN.Description = iMNutritionOrder.Description;


                iMNutritionOrderEN.Value = iMNutritionOrder.Value;

                session.Update (iMNutritionOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMNutritionOrderCAD.", ex);
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
                IMNutritionOrderEN iMNutritionOrderEN = (IMNutritionOrderEN)session.Load (typeof(IMNutritionOrderEN), id);
                session.Delete (iMNutritionOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMNutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMNutritionOrderEN
public IMNutritionOrderEN ReadOID (int id
                                   )
{
        IMNutritionOrderEN iMNutritionOrderEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMNutritionOrderEN = (IMNutritionOrderEN)session.Get (typeof(IMNutritionOrderEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMNutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMNutritionOrderEN;
}

public System.Collections.Generic.IList<IMNutritionOrderEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMNutritionOrderEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMNutritionOrderEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMNutritionOrderEN>();
                else
                        result = session.CreateCriteria (typeof(IMNutritionOrderEN)).List<IMNutritionOrderEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMNutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
