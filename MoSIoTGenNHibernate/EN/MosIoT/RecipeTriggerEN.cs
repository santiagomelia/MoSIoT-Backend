
using System;
// Definición clase RecipeTriggerEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RecipeTriggerEN
{
/**
 *	Atributo recipe
 */
private MoSIoTGenNHibernate.EN.MosIoT.RecipeEN recipe;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo operator_
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum operator_;



/**
 *	Atributo value
 */
private string value;



/**
 *	Atributo entityAttributes
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> entityAttributes;



/**
 *	Atributo event_
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN event_;



/**
 *	Atributo description
 */
private string description;






public virtual MoSIoTGenNHibernate.EN.MosIoT.RecipeEN Recipe {
        get { return recipe; } set { recipe = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum Operator_ {
        get { return operator_; } set { operator_ = value;  }
}



public virtual string Value {
        get { return value; } set { value = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> EntityAttributes {
        get { return entityAttributes; } set { entityAttributes = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN Event_ {
        get { return event_; } set { event_ = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}





public RecipeTriggerEN()
{
        entityAttributes = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN>();
}



public RecipeTriggerEN(int id, MoSIoTGenNHibernate.EN.MosIoT.RecipeEN recipe, MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum operator_, string value, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> entityAttributes, MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN event_, string description
                       )
{
        this.init (Id, recipe, operator_, value, entityAttributes, event_, description);
}


public RecipeTriggerEN(RecipeTriggerEN recipeTrigger)
{
        this.init (Id, recipeTrigger.Recipe, recipeTrigger.Operator_, recipeTrigger.Value, recipeTrigger.EntityAttributes, recipeTrigger.Event_, recipeTrigger.Description);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.RecipeEN recipe, MoSIoTGenNHibernate.Enumerated.MosIoT.OperatorTypeEnum operator_, string value, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> entityAttributes, MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN event_, string description)
{
        this.Id = id;


        this.Recipe = recipe;

        this.Operator_ = operator_;

        this.Value = value;

        this.EntityAttributes = entityAttributes;

        this.Event_ = event_;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RecipeTriggerEN t = obj as RecipeTriggerEN;
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
