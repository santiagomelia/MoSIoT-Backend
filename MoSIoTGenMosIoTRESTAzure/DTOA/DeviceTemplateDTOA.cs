using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class DeviceTemplateDTOA
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

private MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum Type
{
        get { return type; }
        set { type = value; }
}

private bool isEdge;
public bool IsEdge
{
        get { return isEdge; }
        set { isEdge = value; }
}


/* Rol: DeviceTemplate o--> Property */
private IList<PropertyDTOA> properties;
public IList<PropertyDTOA> Properties
{
        get { return properties; }
        set { properties = value; }
}

/* Rol: DeviceTemplate o--> Command */
private IList<CommandDTOA> commands;
public IList<CommandDTOA> Commands
{
        get { return commands; }
        set { commands = value; }
}

/* Rol: DeviceTemplate o--> Telemetry */
private IList<TelemetryDTOA> telemetries;
public IList<TelemetryDTOA> Telemetries
{
        get { return telemetries; }
        set { telemetries = value; }
}
}
}
