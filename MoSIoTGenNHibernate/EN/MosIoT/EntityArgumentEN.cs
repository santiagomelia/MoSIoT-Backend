
using System;
// Definición clase EntityArgumentEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class EntityArgumentEN
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
 *	Atributo type
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type;



/**
 *	Atributo entityOperation
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN entityOperation;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN EntityOperation {
        get { return entityOperation; } set { entityOperation = value;  }
}





public EntityArgumentEN()
{
}



public EntityArgumentEN(int id, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN entityOperation
                        )
{
        this.init (Id, name, type, entityOperation);
}


public EntityArgumentEN(EntityArgumentEN entityArgument)
{
        this.init (Id, entityArgument.Name, entityArgument.Type, entityArgument.EntityOperation);
}

private void init (int id
                   , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN entityOperation)
{
        this.Id = id;


        this.Name = name;

        this.Type = type;

        this.EntityOperation = entityOperation;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EntityArgumentEN t = obj as EntityArgumentEN;
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
