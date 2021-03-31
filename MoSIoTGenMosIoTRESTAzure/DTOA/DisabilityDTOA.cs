using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class DisabilityDTOA
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

private MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DisabilityTypeEnum Type
{
        get { return type; }
        set { type = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum severity;
public MoSIoTGenNHibernate.Enumerated.MosIoT.SeverityEnum Severity
{
        get { return severity; }
        set { severity = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}
}
}
