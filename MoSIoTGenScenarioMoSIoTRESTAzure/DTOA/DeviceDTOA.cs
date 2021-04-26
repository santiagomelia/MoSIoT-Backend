using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class DeviceDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private bool deviceSwitch;
public bool DeviceSwitch
{
        get { return deviceSwitch; }
        set { deviceSwitch = value; }
}

private string tag;
public string Tag
{
        get { return tag; }
        set { tag = value; }
}

private bool isSimulated;
public bool IsSimulated
{
        get { return isSimulated; }
        set { isSimulated = value; }
}

private string serialNumber;
public string SerialNumber
{
        get { return serialNumber; }
        set { serialNumber = value; }
}

private string firmVersion;
public string FirmVersion
{
        get { return firmVersion; }
        set { firmVersion = value; }
}

private string trademark;
public string Trademark
{
        get { return trademark; }
        set { trademark = value; }
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


/* Rol: Device o--> DeviceTemplate */
private DeviceTemplateDTOA deviceTemplate;
public DeviceTemplateDTOA DeviceTemplate
{
        get { return deviceTemplate; }
        set { deviceTemplate = value; }
}
}
}
