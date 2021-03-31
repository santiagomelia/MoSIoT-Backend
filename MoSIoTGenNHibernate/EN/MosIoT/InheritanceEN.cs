
using System;
// Definición clase InheritanceEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class InheritanceEN
{
/**
 *	Atributo father
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityEN> father;



/**
 *	Atributo son
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityEN son;



/**
 *	Atributo id
 */
private int id;






public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityEN> Father {
        get { return father; } set { father = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityEN Son {
        get { return son; } set { son = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public InheritanceEN()
{
        father = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityEN>();
}



public InheritanceEN(int id, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityEN> father, MoSIoTGenNHibernate.EN.MosIoT.EntityEN son
                     )
{
        this.init (Id, father, son);
}


public InheritanceEN(InheritanceEN inheritance)
{
        this.init (Id, inheritance.Father, inheritance.Son);
}

private void init (int id
                   , System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityEN> father, MoSIoTGenNHibernate.EN.MosIoT.EntityEN son)
{
        this.Id = id;


        this.Father = father;

        this.Son = son;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        InheritanceEN t = obj as InheritanceEN;
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
