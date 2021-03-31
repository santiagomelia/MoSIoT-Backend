
using System;
// Definición clase AssociationEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class AssociationEN
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
 *	Atributo rolOrigin
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN rolOrigin;



/**
 *	Atributo rolTarget
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN rolTarget;



/**
 *	Atributo type
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum type;



/**
 *	Atributo cardinalityOrigin
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityOrigin;



/**
 *	Atributo cardinalityTarget
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityTarget;



/**
 *	Atributo entityOrigin
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityEN entityOrigin;



/**
 *	Atributo entityTarget
 */
private MoSIoTGenNHibernate.EN.MosIoT.EntityEN entityTarget;



/**
 *	Atributo ioTScenario
 */
private MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ioTScenario;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN RolOrigin {
        get { return rolOrigin; } set { rolOrigin = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN RolTarget {
        get { return rolTarget; } set { rolTarget = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum CardinalityOrigin {
        get { return cardinalityOrigin; } set { cardinalityOrigin = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum CardinalityTarget {
        get { return cardinalityTarget; } set { cardinalityTarget = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityEN EntityOrigin {
        get { return entityOrigin; } set { entityOrigin = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.EntityEN EntityTarget {
        get { return entityTarget; } set { entityTarget = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN IoTScenario {
        get { return ioTScenario; } set { ioTScenario = value;  }
}





public AssociationEN()
{
}



public AssociationEN(int id, string name, MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN rolOrigin, MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN rolTarget, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityOrigin, MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityTarget, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entityOrigin, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entityTarget, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ioTScenario
                     )
{
        this.init (Id, name, rolOrigin, rolTarget, type, cardinalityOrigin, cardinalityTarget, entityOrigin, entityTarget, ioTScenario);
}


public AssociationEN(AssociationEN association)
{
        this.init (Id, association.Name, association.RolOrigin, association.RolTarget, association.Type, association.CardinalityOrigin, association.CardinalityTarget, association.EntityOrigin, association.EntityTarget, association.IoTScenario);
}

private void init (int id
                   , string name, MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN rolOrigin, MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN rolTarget, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum type, MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityOrigin, MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityTarget, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entityOrigin, MoSIoTGenNHibernate.EN.MosIoT.EntityEN entityTarget, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ioTScenario)
{
        this.Id = id;


        this.Name = name;

        this.RolOrigin = rolOrigin;

        this.RolTarget = rolTarget;

        this.Type = type;

        this.CardinalityOrigin = cardinalityOrigin;

        this.CardinalityTarget = cardinalityTarget;

        this.EntityOrigin = entityOrigin;

        this.EntityTarget = entityTarget;

        this.IoTScenario = ioTScenario;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AssociationEN t = obj as AssociationEN;
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
