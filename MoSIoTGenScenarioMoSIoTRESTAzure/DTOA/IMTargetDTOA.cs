using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class IMTargetDTOA
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

private string value;
public string Value
{
        get { return value; }
        set { value = value; }
}


/* Rol: IMTarget o--> Target */
private TargetDTOA valueTarget;
public TargetDTOA ValueTarget
{
        get { return valueTarget; }
        set { valueTarget = value; }
}
}
}
