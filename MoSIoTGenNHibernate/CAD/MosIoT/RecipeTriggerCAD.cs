
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
 * Clase RecipeTrigger:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class RecipeTriggerCAD : BasicCAD, IRecipeTriggerCAD
{
public RecipeTriggerCAD() : base ()
{
}

public RecipeTriggerCAD(ISession sessionAux) : base (sessionAux)
{
}



public RecipeTriggerEN ReadOIDDefault (int id
                                       )
{
        RecipeTriggerEN recipeTriggerEN = null;

        try
        {
                SessionInitializeTransaction ();
                recipeTriggerEN = (RecipeTriggerEN)session.Get (typeof(RecipeTriggerEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeTriggerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recipeTriggerEN;
}

public System.Collections.Generic.IList<RecipeTriggerEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RecipeTriggerEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RecipeTriggerEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RecipeTriggerEN>();
                        else
                                result = session.CreateCriteria (typeof(RecipeTriggerEN)).List<RecipeTriggerEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeTriggerCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RecipeTriggerEN recipeTrigger)
{
        try
        {
                SessionInitializeTransaction ();
                RecipeTriggerEN recipeTriggerEN = (RecipeTriggerEN)session.Load (typeof(RecipeTriggerEN), recipeTrigger.Id);


                recipeTriggerEN.Operator_ = recipeTrigger.Operator_;


                recipeTriggerEN.Value = recipeTrigger.Value;



                session.Update (recipeTriggerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeTriggerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RecipeTriggerEN recipeTrigger)
{
        try
        {
                SessionInitializeTransaction ();
                if (recipeTrigger.Recipe != null) {
                        // Argumento OID y no colección.
                        recipeTrigger.Recipe = (MoSIoTGenNHibernate.EN.MosIoT.RecipeEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.RecipeEN), recipeTrigger.Recipe.Id);

                        recipeTrigger.Recipe.Triggers
                                = recipeTrigger;
                }

                session.Save (recipeTrigger);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeTriggerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recipeTrigger.Id;
}

public void Modify (RecipeTriggerEN recipeTrigger)
{
        try
        {
                SessionInitializeTransaction ();
                RecipeTriggerEN recipeTriggerEN = (RecipeTriggerEN)session.Load (typeof(RecipeTriggerEN), recipeTrigger.Id);

                recipeTriggerEN.Operator_ = recipeTrigger.Operator_;


                recipeTriggerEN.Value = recipeTrigger.Value;

                session.Update (recipeTriggerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeTriggerCAD.", ex);
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
                RecipeTriggerEN recipeTriggerEN = (RecipeTriggerEN)session.Load (typeof(RecipeTriggerEN), id);
                session.Delete (recipeTriggerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeTriggerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RecipeTriggerEN
public RecipeTriggerEN ReadOID (int id
                                )
{
        RecipeTriggerEN recipeTriggerEN = null;

        try
        {
                SessionInitializeTransaction ();
                recipeTriggerEN = (RecipeTriggerEN)session.Get (typeof(RecipeTriggerEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeTriggerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recipeTriggerEN;
}

public System.Collections.Generic.IList<RecipeTriggerEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RecipeTriggerEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RecipeTriggerEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RecipeTriggerEN>();
                else
                        result = session.CreateCriteria (typeof(RecipeTriggerEN)).List<RecipeTriggerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeTriggerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
