using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class PatientAccessDTOA
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


/* Rol: PatientAccess o--> AccessMode */
private AccessModeDTOA accessMode;
public AccessModeDTOA AccessMode
{
        get { return accessMode; }
        set { accessMode = value; }
}
}
}
