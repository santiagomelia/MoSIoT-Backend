using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class PropertyDTOA
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

private bool isWritable;
public bool IsWritable
{
        get { return isWritable; }
        set { isWritable = value; }
}

private bool isCloudable;
public bool IsCloudable
{
        get { return isCloudable; }
        set { isCloudable = value; }
}
}
}
