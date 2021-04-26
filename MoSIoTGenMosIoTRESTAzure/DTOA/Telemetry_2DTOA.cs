using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class Telemetry_2DTOA
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

private MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum Type
{
        get { return type; }
        set { type = value; }
}

private double frecuency;
public double Frecuency
{
        get { return frecuency; }
        set { frecuency = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum schema;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Schema
{
        get { return schema; }
        set { schema = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum unit;
public MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum Unit
{
        get { return unit; }
        set { unit = value; }
}
}
}
