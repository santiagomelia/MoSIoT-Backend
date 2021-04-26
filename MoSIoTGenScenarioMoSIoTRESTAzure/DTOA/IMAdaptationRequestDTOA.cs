using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class IMAdaptationRequestDTOA
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


/* Rol: IMAdaptationRequest o--> AdaptationRequest */
private AdaptationRequestDTOA valueAdaption;
public AdaptationRequestDTOA ValueAdaption
{
        get { return valueAdaption; }
        set { valueAdaption = value; }
}
}
}
