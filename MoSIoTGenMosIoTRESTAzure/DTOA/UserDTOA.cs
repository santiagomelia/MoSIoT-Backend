using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class UserDTOA
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

private string surnames;
public string Surnames
{
        get { return surnames; }
        set { surnames = value; }
}

private bool isActive;
public bool IsActive
{
        get { return isActive; }
        set { isActive = value; }
}
}
}
