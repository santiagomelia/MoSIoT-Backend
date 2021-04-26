using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class PractitionerDTOA
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


/* Rol: Practitioner o--> User */
private UserDTOA practitionerData;
public UserDTOA PractitionerData
{
        get { return practitionerData; }
        set { practitionerData = value; }
}
}
}
