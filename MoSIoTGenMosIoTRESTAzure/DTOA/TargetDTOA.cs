using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class TargetDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private string desiredValue;
public string DesiredValue
{
        get { return desiredValue; }
        set { desiredValue = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}

private Nullable<DateTime> dueDate;
public Nullable<DateTime> DueDate
{
        get { return dueDate; }
        set { dueDate = value; }
}
}
}
