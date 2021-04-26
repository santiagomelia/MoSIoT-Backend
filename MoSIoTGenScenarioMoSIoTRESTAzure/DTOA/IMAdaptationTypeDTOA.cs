using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class IMAdaptationTypeDTOA
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


/* Rol: IMAdaptationType o--> AdaptationTypeRequired */
private AdaptationTypeRequiredDTOA valueAdaptionType;
public AdaptationTypeRequiredDTOA ValueAdaptionType
{
        get { return valueAdaptionType; }
        set { valueAdaptionType = value; }
}
}
}
