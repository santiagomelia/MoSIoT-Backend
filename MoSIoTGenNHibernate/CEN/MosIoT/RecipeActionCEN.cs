

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;

using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


namespace MoSIoTGenNHibernate.CEN.MosIoT
{
/*
 *      Definition of the class RecipeActionCEN
 *
 */
public partial class RecipeActionCEN
{
private IRecipeActionCAD _IRecipeActionCAD;

public RecipeActionCEN()
{
        this._IRecipeActionCAD = new RecipeActionCAD ();
}

public RecipeActionCEN(IRecipeActionCAD _IRecipeActionCAD)
{
        this._IRecipeActionCAD = _IRecipeActionCAD;
}

public IRecipeActionCAD get_IRecipeActionCAD ()
{
        return this._IRecipeActionCAD;
}

public int New_ (int p_recipe, int p_operation, string p_name, string p_description)
{
        RecipeActionEN recipeActionEN = null;
        int oid;

        //Initialized RecipeActionEN
        recipeActionEN = new RecipeActionEN ();

        if (p_recipe != -1) {
                // El argumento p_recipe -> Property recipe es oid = false
                // Lista de oids id
                recipeActionEN.Recipe = new MoSIoTGenNHibernate.EN.MosIoT.RecipeEN ();
                recipeActionEN.Recipe.Id = p_recipe;
        }


        if (p_operation != -1) {
                // El argumento p_operation -> Property operation es oid = false
                // Lista de oids id
                recipeActionEN.Operation = new MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN ();
                recipeActionEN.Operation.Id = p_operation;
        }

        recipeActionEN.Name = p_name;

        recipeActionEN.Description = p_description;

        //Call to RecipeActionCAD

        oid = _IRecipeActionCAD.New_ (recipeActionEN);
        return oid;
}

public void Modify (int p_RecipeAction_OID, string p_name, string p_description)
{
        RecipeActionEN recipeActionEN = null;

        //Initialized RecipeActionEN
        recipeActionEN = new RecipeActionEN ();
        recipeActionEN.Id = p_RecipeAction_OID;
        recipeActionEN.Name = p_name;
        recipeActionEN.Description = p_description;
        //Call to RecipeActionCAD

        _IRecipeActionCAD.Modify (recipeActionEN);
}

public void Destroy (int id
                     )
{
        _IRecipeActionCAD.Destroy (id);
}

public RecipeActionEN ReadOID (int id
                               )
{
        RecipeActionEN recipeActionEN = null;

        recipeActionEN = _IRecipeActionCAD.ReadOID (id);
        return recipeActionEN;
}

public System.Collections.Generic.IList<RecipeActionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RecipeActionEN> list = null;

        list = _IRecipeActionCAD.ReadAll (first, size);
        return list;
}
}
}
