using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class AdaptationDetailRequiredDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum adaptationRequest;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum AdaptationRequest
{
        get { return adaptationRequest; }
        set { adaptationRequest = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}
}
}
