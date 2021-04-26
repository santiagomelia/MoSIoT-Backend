using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class EntityOperationDTOA
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

private MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum serviceType;
public MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum ServiceType
{
        get { return serviceType; }
        set { serviceType = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}
}
}
