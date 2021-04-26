using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class CommandDTOA
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

private bool isSynchronous;
public bool IsSynchronous
{
        get { return isSynchronous; }
        set { isSynchronous = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum Type
{
        get { return type; }
        set { type = value; }
}
}
}
