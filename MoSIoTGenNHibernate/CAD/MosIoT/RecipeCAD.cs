
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
 * Clase Recipe:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class RecipeCAD : BasicCAD, IRecipeCAD
{
public RecipeCAD() : base ()
{
}

public RecipeCAD(ISession sessionAux) : base (sessionAux)
{
}



public RecipeEN ReadOIDDefault (int id
                                )
{
        RecipeEN recipeEN = null;

        try
        {
                SessionInitializeTransaction ();
                recipeEN = (RecipeEN)session.Get (typeof(RecipeEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recipeEN;
}

public System.Collections.Generic.IList<RecipeEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RecipeEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RecipeEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RecipeEN>();
                        else
                                result = session.CreateCriteria (typeof(RecipeEN)).List<RecipeEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RecipeEN recipe)
{
        try
        {
                SessionInitializeTransaction ();
                RecipeEN recipeEN = (RecipeEN)session.Load (typeof(RecipeEN), recipe.Id);

                recipeEN.Name = recipe.Name;


                recipeEN.IsEnabled = recipe.IsEnabled;





                recipeEN.IntervalTime = recipe.IntervalTime;


                recipeEN.Description = recipe.Description;

                session.Update (recipeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RecipeEN recipe)
{
        try
        {
                SessionInitializeTransaction ();
                if (recipe.IoTScenario != null) {
                        // Argumento OID y no colección.
                        recipe.IoTScenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), recipe.IoTScenario.Id);

                        recipe.IoTScenario.Recipes
                        .Add (recipe);
                }

                session.Save (recipe);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recipe.Id;
}

public void Modify (RecipeEN recipe)
{
        try
        {
                SessionInitializeTransaction ();
                RecipeEN recipeEN = (RecipeEN)session.Load (typeof(RecipeEN), recipe.Id);

                recipeEN.Name = recipe.Name;


                recipeEN.IsEnabled = recipe.IsEnabled;


                recipeEN.IntervalTime = recipe.IntervalTime;


                recipeEN.Description = recipe.Description;

                session.Update (recipeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeCAD.", ex);
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
                RecipeEN recipeEN = (RecipeEN)session.Load (typeof(RecipeEN), id);
                session.Delete (recipeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RecipeEN
public RecipeEN ReadOID (int id
                         )
{
        RecipeEN recipeEN = null;

        try
        {
                SessionInitializeTransaction ();
                recipeEN = (RecipeEN)session.Get (typeof(RecipeEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return recipeEN;
}

public System.Collections.Generic.IList<RecipeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RecipeEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RecipeEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RecipeEN>();
                else
                        result = session.CreateCriteria (typeof(RecipeEN)).List<RecipeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RecipeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
