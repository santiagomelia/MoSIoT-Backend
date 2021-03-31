using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class AdaptationTypeRequiredDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum adaptionRequest;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum AdaptionRequest
{
        get { return adaptionRequest; }
        set { adaptionRequest = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}
}
}
