
using System;
// Definición clase IoTScenarioEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IoTScenarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo entity
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityEN> entity;



/**
 *	Atributo recipes
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeEN> recipes;



/**
 *	Atributo association
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> association;



/**
 *	Atributo description
 */
private string description;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityEN> Entity {
        get { return entity; } set { entity = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeEN> Recipes {
        get { return recipes; } set { recipes = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> Association {
        get { return association; } set { association = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}





public IoTScenarioEN()
{
        entity = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityEN>();
        recipes = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeEN>();
        association = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN>();
}



public IoTScenarioEN(int id, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityEN> entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeEN> recipes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> association, string description
                     )
{
        this.init (Id, name, entity, recipes, association, description);
}


public IoTScenarioEN(IoTScenarioEN ioTScenario)
{
        this.init (Id, ioTScenario.Name, ioTScenario.Entity, ioTScenario.Recipes, ioTScenario.Association, ioTScenario.Description);
}

private void init (int id
                   , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityEN> entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeEN> recipes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> association, string description)
{
        this.Id = id;


        this.Name = name;

        this.Entity = entity;

        this.Recipes = recipes;

        this.Association = association;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IoTScenarioEN t = obj as IoTScenarioEN;
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
