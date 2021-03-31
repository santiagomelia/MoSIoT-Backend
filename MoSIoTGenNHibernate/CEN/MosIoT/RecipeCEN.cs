

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
 *      Definition of the class RecipeCEN
 *
 */
public partial class RecipeCEN
{
private IRecipeCAD _IRecipeCAD;

public RecipeCEN()
{
        this._IRecipeCAD = new RecipeCAD ();
}

public RecipeCEN(IRecipeCAD _IRecipeCAD)
{
        this._IRecipeCAD = _IRecipeCAD;
}

public IRecipeCAD get_IRecipeCAD ()
{
        return this._IRecipeCAD;
}

public int New_ (string p_name, bool p_isEnabled, int p_ioTScenario, double p_intervalTime, string p_description)
{
        RecipeEN recipeEN = null;
        int oid;

        //Initialized RecipeEN
        recipeEN = new RecipeEN ();
        recipeEN.Name = p_name;

        recipeEN.IsEnabled = p_isEnabled;


        if (p_ioTScenario != -1) {
                // El argumento p_ioTScenario -> Property ioTScenario es oid = false
                // Lista de oids id
                recipeEN.IoTScenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                recipeEN.IoTScenario.Id = p_ioTScenario;
        }

        recipeEN.IntervalTime = p_intervalTime;

        recipeEN.Description = p_description;

        //Call to RecipeCAD

        oid = _IRecipeCAD.New_ (recipeEN);
        return oid;
}

public void Modify (int p_Recipe_OID, string p_name, bool p_isEnabled, double p_intervalTime, string p_description)
{
        RecipeEN recipeEN = null;

        //Initialized RecipeEN
        recipeEN = new RecipeEN ();
        recipeEN.Id = p_Recipe_OID;
        recipeEN.Name = p_name;
        recipeEN.IsEnabled = p_isEnabled;
        recipeEN.IntervalTime = p_intervalTime;
        recipeEN.Description = p_description;
        //Call to RecipeCAD

        _IRecipeCAD.Modify (recipeEN);
}

public void Destroy (int id
                     )
{
        _IRecipeCAD.Destroy (id);
}

public RecipeEN ReadOID (int id
                         )
{
        RecipeEN recipeEN = null;

        recipeEN = _IRecipeCAD.ReadOID (id);
        return recipeEN;
}

public System.Collections.Generic.IList<RecipeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RecipeEN> list = null;

        list = _IRecipeCAD.ReadAll (first, size);
        return list;
}
}
}
