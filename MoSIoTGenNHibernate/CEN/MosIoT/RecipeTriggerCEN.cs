

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
 *      Definition of the class RecipeTriggerCEN
 *
 */
public partial class RecipeTriggerCEN
{
private IRecipeTriggerCAD _IRecipeTriggerCAD;

public RecipeTriggerCEN()
{
        this._IRecipeTriggerCAD = new RecipeTriggerCAD ();
}

public RecipeTriggerCEN(IRecipeTriggerCAD _IRecipeTriggerCAD)
{
        this._IRecipeTriggerCAD = _IRecipeTriggerCAD;
}

public IRecipeTriggerCAD get_IRecipeTriggerCAD ()
{
        return this._IRecipeTriggerCAD;
}

public int New_ (int p_recipe, MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum p_operator, string p_value, string p_description)
{
        RecipeTriggerEN recipeTriggerEN = null;
        int oid;

        //Initialized RecipeTriggerEN
        recipeTriggerEN = new RecipeTriggerEN ();

        if (p_recipe != -1) {
                // El argumento p_recipe -> Property recipe es oid = false
                // Lista de oids id
                recipeTriggerEN.Recipe = new MoSIoTGenNHibernate.EN.MosIoT.RecipeEN ();
                recipeTriggerEN.Recipe.Id = p_recipe;
        }

        recipeTriggerEN.Operator_ = p_operator;

        recipeTriggerEN.Value = p_value;

        recipeTriggerEN.Description = p_description;

        //Call to RecipeTriggerCAD

        oid = _IRecipeTriggerCAD.New_ (recipeTriggerEN);
        return oid;
}

public void Modify (int p_RecipeTrigger_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum p_operator, string p_value, string p_description)
{
        RecipeTriggerEN recipeTriggerEN = null;

        //Initialized RecipeTriggerEN
        recipeTriggerEN = new RecipeTriggerEN ();
        recipeTriggerEN.Id = p_RecipeTrigger_OID;
        recipeTriggerEN.Operator_ = p_operator;
        recipeTriggerEN.Value = p_value;
        recipeTriggerEN.Description = p_description;
        //Call to RecipeTriggerCAD

        _IRecipeTriggerCAD.Modify (recipeTriggerEN);
}

public void Destroy (int id
                     )
{
        _IRecipeTriggerCAD.Destroy (id);
}

public RecipeTriggerEN ReadOID (int id
                                )
{
        RecipeTriggerEN recipeTriggerEN = null;

        recipeTriggerEN = _IRecipeTriggerCAD.ReadOID (id);
        return recipeTriggerEN;
}

public System.Collections.Generic.IList<RecipeTriggerEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RecipeTriggerEN> list = null;

        list = _IRecipeTriggerCAD.ReadAll (first, size);
        return list;
}
}
}
