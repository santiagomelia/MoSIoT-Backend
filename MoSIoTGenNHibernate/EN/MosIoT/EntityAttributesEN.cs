
using System;
// Definición clase EntityAttributesEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class EntityAttributesEN
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
 *	Atributo isOID
 */
private bool isOID;



/**
 *	Atributo targetAssociation
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation;



/**
 *	Atributo originAsociation
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation;



/**
 *	Atributo associationType
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType;



/**
 *	Atributo isWritable
 */
private bool isWritable;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo entity
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity;



/**
 *	Atributo trigger
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger;



/**
 *	Atributo register
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register;



/**
 *	Atributo value
 */
private string value;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual bool IsOID {
        get { return isOID; } set { isOID = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> TargetAssociation {
        get { return targetAssociation; } set { targetAssociation = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> OriginAsociation {
        get { return originAsociation; } set { originAsociation = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum AssociationType {
        get { return associationType; } set { associationType = value;  }
}



public virtual bool IsWritable {
        get { return isWritable; } set { isWritable = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityEN Entity {
        get { return entity; } set { entity = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> Trigger {
        get { return trigger; } set { trigger = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> Register {
        get { return register; } set { register = value;  }
}



public virtual string Value {
        get { return value; } set { value = value;  }
}





public EntityAttributesEN()
{
        targetAssociation = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN>();
        originAsociation = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN>();
        trigger = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN>();
        register = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN>();
}



public EntityAttributesEN(int id, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value
                          )
{
        this.init (Id, name, type, isOID, targetAssociation, originAsociation, associationType, isWritable, description, entity, trigger, register, value);
}


public EntityAttributesEN(EntityAttributesEN entityAttributes)
{
        this.init (Id, entityAttributes.Name, entityAttributes.Type, entityAttributes.IsOID, entityAttributes.TargetAssociation, entityAttributes.OriginAsociation, entityAttributes.AssociationType, entityAttributes.IsWritable, entityAttributes.Description, entityAttributes.Entity, entityAttributes.Trigger, entityAttributes.Register, entityAttributes.Value);
}

private void init (int id
                   , string name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type, bool isOID, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAsociation, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType, bool isWritable, string description, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entity, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RecipeTriggerEN> trigger, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RegisterEN> register, string value)
{
        this.Id = id;


        this.Name = name;

        this.Type = type;

        this.IsOID = isOID;

        this.TargetAssociation = targetAssociation;

        this.OriginAsociation = originAsociation;

        this.AssociationType = associationType;

        this.IsWritable = isWritable;

        this.Description = description;

        this.Entity = entity;

        this.Trigger = trigger;

        this.Register = register;

        this.Value = value;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EntityAttributesEN t = obj as EntityAttributesEN;
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
