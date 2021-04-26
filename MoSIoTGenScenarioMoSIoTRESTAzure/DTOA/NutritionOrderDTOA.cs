using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class NutritionOrderDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}

private string dietCode;
public string DietCode
{
        get { return dietCode; }
        set { dietCode = value; }
}

private string name;
public string Name
{
        get { return name; }
        set { name = value; }
}
}
}
