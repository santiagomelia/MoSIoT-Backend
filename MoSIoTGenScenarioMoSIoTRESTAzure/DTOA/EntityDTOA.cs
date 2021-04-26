using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class EntityDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}



/* Rol: Entity o--> Association */
private IList<AssociationDTOA> originAssociations;
public IList<AssociationDTOA> OriginAssociations
{
        get { return originAssociations; }
        set { originAssociations = value; }
}

/* Rol: Entity o--> Association */
private IList<AssociationDTOA> targetAssociations;
public IList<AssociationDTOA> TargetAssociations
{
        get { return targetAssociations; }
        set { targetAssociations = value; }
}

/* Rol: Entity o--> EntityAttributes */
private IList<EntityAttributesDTOA> attributes;
public IList<EntityAttributesDTOA> Attributes
{
        get { return attributes; }
        set { attributes = value; }
}

/* Rol: Entity o--> EntityOperation */
private IList<EntityOperationDTOA> operations;
public IList<EntityOperationDTOA> Operations
{
        get { return operations; }
        set { operations = value; }
}
}
}
