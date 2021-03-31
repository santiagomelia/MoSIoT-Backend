
using System;
// Definición clase EntityStateEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class EntityStateEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo virtualEntity
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityEN virtualEntity;



/**
 *	Atributo originOperations
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> originOperations;



/**
 *	Atributo targetOperations
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> targetOperations;



/**
 *	Atributo type
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.StateTypeEnum type;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo description
 */
private string description;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityEN VirtualEntity {
        get { return virtualEntity; } set { virtualEntity = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> OriginOperations {
        get { return originOperations; } set { originOperations = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> TargetOperations {
        get { return targetOperations; } set { targetOperations = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.StateTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}





public EntityStateEN()
{
        originOperations = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN>();
        targetOperations = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN>();
}



public EntityStateEN(int id, MoSIoTGenNHibernate.EN.MosIoT.EntityEN virtualEntity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> originOperations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> targetOperations, MoSIoTGenNHibernate.Enumerated.MosIoT.StateTypeEnum type, string name, string description
                     )
{
        this.init (Id, virtualEntity, originOperations, targetOperations, type, name, description);
}


public EntityStateEN(EntityStateEN entityState)
{
        this.init (Id, entityState.VirtualEntity, entityState.OriginOperations, entityState.TargetOperations, entityState.Type, entityState.Name, entityState.Description);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.EntityEN virtualEntity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> originOperations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> targetOperations, MoSIoTGenNHibernate.Enumerated.MosIoT.StateTypeEnum type, string name, string description)
{
        this.Id = id;


        this.VirtualEntity = virtualEntity;

        this.OriginOperations = originOperations;

        this.TargetOperations = targetOperations;

        this.Type = type;

        this.Name = name;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EntityStateEN t = obj as EntityStateEN;
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
