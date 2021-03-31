
using System;
// Definición clase NutritionOrderEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class NutritionOrderEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo dietCode All codes: http://snomed.info/sct
 */
private string dietCode;



/**
 *	Atributo careActivity
 */
private MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual string DietCode {
        get { return dietCode; } set { dietCode = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN CareActivity {
        get { return careActivity; } set { careActivity = value;  }
}





public NutritionOrderEN()
{
}



public NutritionOrderEN(int id, string description, string dietCode, MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity
                        )
{
        this.init (Id, description, dietCode, careActivity);
}


public NutritionOrderEN(NutritionOrderEN nutritionOrder)
{
        this.init (Id, nutritionOrder.Description, nutritionOrder.DietCode, nutritionOrder.CareActivity);
}

private void init (int id
                   , string description, string dietCode, MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity)
{
        this.Id = id;


        this.Description = description;

        this.DietCode = dietCode;

        this.CareActivity = careActivity;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        NutritionOrderEN t = obj as NutritionOrderEN;
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
