
using System;
// Definición clase RecipeActionEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RecipeActionEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo recipe
 */
private MoSIoTGenNHibernate.EN.MosIoT.RecipeEN recipe;



/**
 *	Atributo operation
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN operation;



/**
 *	Atributo name
 */
private string name;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.RecipeEN Recipe {
        get { return recipe; } set { recipe = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN Operation {
        get { return operation; } set { operation = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}





public RecipeActionEN()
{
}



public RecipeActionEN(int id, MoSIoTGenNHibernate.EN.MosIoT.RecipeEN recipe, MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN operation, string name
                      )
{
        this.init (Id, recipe, operation, name);
}


public RecipeActionEN(RecipeActionEN recipeAction)
{
        this.init (Id, recipeAction.Recipe, recipeAction.Operation, recipeAction.Name);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.RecipeEN recipe, MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN operation, string name)
{
        this.Id = id;


        this.Recipe = recipe;

        this.Operation = operation;

        this.Name = name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RecipeActionEN t = obj as RecipeActionEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
