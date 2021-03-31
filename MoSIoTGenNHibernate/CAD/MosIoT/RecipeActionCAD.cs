
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
 * Clase RecipeAction:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class RecipeActionCAD : BasicCAD, IRecipeActionCAD
{
public RecipeActionCAD() : base ()
{
}

public RecipeActionCAD(ISession sessionAux) : base (sessionAux)
{
}



public RecipeActionEN ReadOIDDefault (int id
                                      )
{
        RecipeActionEN recipeActionEN = null;

        try
        {
                SessionInitializeTransaction ();
                recipeActionEN = (RecipeActionEN)session.Get (typeof(RecipeActionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recipeActionEN;
}

public System.Collections.Generic.IList<RecipeActionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RecipeActionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RecipeActionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RecipeActionEN>();
                        else
                                result = session.CreateCriteria (typeof(RecipeActionEN)).List<RecipeActionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeActionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RecipeActionEN recipeAction)
{
        try
        {
                SessionInitializeTransaction ();
                RecipeActionEN recipeActionEN = (RecipeActionEN)session.Load (typeof(RecipeActionEN), recipeAction.Id);



                recipeActionEN.Name = recipeAction.Name;

                session.Update (recipeActionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RecipeActionEN recipeAction)
{
        try
        {
                SessionInitializeTransaction ();
                if (recipeAction.Recipe != null) {
                        // Argumento OID y no colección.
                        recipeAction.Recipe = (MoSIoTGenNHibernate.EN.MosIoT.RecipeEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.RecipeEN), recipeAction.Recipe.Id);

                        recipeAction.Recipe.RecipeAction
                        .Add (recipeAction);
                }
                if (recipeAction.Operation != null) {
                        // Argumento OID y no colección.
                        recipeAction.Operation = (MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN), recipeAction.Operation.Id);

                        recipeAction.Operation.RuleAction
                        .Add (recipeAction);
                }

                session.Save (recipeAction);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recipeAction.Id;
}

public void Modify (RecipeActionEN recipeAction)
{
        try
        {
                SessionInitializeTransaction ();
                RecipeActionEN recipeActionEN = (RecipeActionEN)session.Load (typeof(RecipeActionEN), recipeAction.Id);

                recipeActionEN.Name = recipeAction.Name;

                session.Update (recipeActionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeActionCAD.", ex);
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
                RecipeActionEN recipeActionEN = (RecipeActionEN)session.Load (typeof(RecipeActionEN), id);
                session.Delete (recipeActionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RecipeActionEN
public RecipeActionEN ReadOID (int id
                               )
{
        RecipeActionEN recipeActionEN = null;

        try
        {
                SessionInitializeTransaction ();
                recipeActionEN = (RecipeActionEN)session.Get (typeof(RecipeActionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recipeActionEN;
}

public System.Collections.Generic.IList<RecipeActionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RecipeActionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RecipeActionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RecipeActionEN>();
                else
                        result = session.CreateCriteria (typeof(RecipeActionEN)).List<RecipeActionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeActionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
