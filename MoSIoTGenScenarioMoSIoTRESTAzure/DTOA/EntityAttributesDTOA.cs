using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class EntityAttributesDTOA
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

private MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Type
{
        get { return type; }
        set { type = value; }
}

private bool isOID;
public bool IsOID
{
        get { return isOID; }
        set { isOID = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum associationType;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum AssociationType
{
        get { return associationType; }
        set { associationType = value; }
}

private bool isWritable;
public bool IsWritable
{
        get { return isWritable; }
        set { isWritable = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}
}
}
