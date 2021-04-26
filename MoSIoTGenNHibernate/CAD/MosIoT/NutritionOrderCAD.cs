
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
 * Clase NutritionOrder:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class NutritionOrderCAD : BasicCAD, INutritionOrderCAD
{
public NutritionOrderCAD() : base ()
{
}

public NutritionOrderCAD(ISession sessionAux) : base (sessionAux)
{
}



public NutritionOrderEN ReadOIDDefault (int id
                                        )
{
        NutritionOrderEN nutritionOrderEN = null;

        try
        {
                SessionInitializeTransaction ();
                nutritionOrderEN = (NutritionOrderEN)session.Get (typeof(NutritionOrderEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return nutritionOrderEN;
}

public System.Collections.Generic.IList<NutritionOrderEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<NutritionOrderEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(NutritionOrderEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<NutritionOrderEN>();
                        else
                                result = session.CreateCriteria (typeof(NutritionOrderEN)).List<NutritionOrderEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NutritionOrderCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (NutritionOrderEN nutritionOrder)
{
        try
        {
                SessionInitializeTransaction ();
                NutritionOrderEN nutritionOrderEN = (NutritionOrderEN)session.Load (typeof(NutritionOrderEN), nutritionOrder.Id);

                nutritionOrderEN.Description = nutritionOrder.Description;


                nutritionOrderEN.DietCode = nutritionOrder.DietCode;



                nutritionOrderEN.Name = nutritionOrder.Name;

                session.Update (nutritionOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (NutritionOrderEN nutritionOrder)
{
        try
        {
                SessionInitializeTransaction ();
                if (nutritionOrder.CareActivity != null) {
                        // Argumento OID y no colección.
                        nutritionOrder.CareActivity = (MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN), nutritionOrder.CareActivity.Id);

                        nutritionOrder.CareActivity.NutritionOrder
                                = nutritionOrder;
                }

                session.Save (nutritionOrder);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return nutritionOrder.Id;
}

public void Modify (NutritionOrderEN nutritionOrder)
{
        try
        {
                SessionInitializeTransaction ();
                NutritionOrderEN nutritionOrderEN = (NutritionOrderEN)session.Load (typeof(NutritionOrderEN), nutritionOrder.Id);

                nutritionOrderEN.Description = nutritionOrder.Description;


                nutritionOrderEN.DietCode = nutritionOrder.DietCode;


                nutritionOrderEN.Name = nutritionOrder.Name;

                session.Update (nutritionOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NutritionOrderCAD.", ex);
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
                NutritionOrderEN nutritionOrderEN = (NutritionOrderEN)session.Load (typeof(NutritionOrderEN), id);
                session.Delete (nutritionOrderEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: NutritionOrderEN
public NutritionOrderEN ReadOID (int id
                                 )
{
        NutritionOrderEN nutritionOrderEN = null;

        try
        {
                SessionInitializeTransaction ();
                nutritionOrderEN = (NutritionOrderEN)session.Get (typeof(NutritionOrderEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return nutritionOrderEN;
}

public System.Collections.Generic.IList<NutritionOrderEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<NutritionOrderEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(NutritionOrderEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<NutritionOrderEN>();
                else
                        result = session.CreateCriteria (typeof(NutritionOrderEN)).List<NutritionOrderEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in NutritionOrderCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
