using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class AssociationDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private string name;
public string Name
{
        get { return name; }
        set { name = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum Type
{
        get { return type; }
        set { type = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityOrigin;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum CardinalityOrigin
{
        get { return cardinalityOrigin; }
        set { cardinalityOrigin = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum cardinalityTarget;
public MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum CardinalityTarget
{
        get { return cardinalityTarget; }
        set { cardinalityTarget = value; }
}
}
}
