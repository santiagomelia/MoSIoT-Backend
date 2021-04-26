using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class IMDisabilityDTOA
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


/* Rol: IMDisability o--> Disability */
private DisabilityDTOA valueDisability;
public DisabilityDTOA ValueDisability
{
        get { return valueDisability; }
        set { valueDisability = value; }
}
}
}
