using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class AccessModeDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum typeAccessMode;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum TypeAccessMode
{
        get { return typeAccessMode; }
        set { typeAccessMode = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}

private string name;
public string Name
{
        get { return name; }
        set { name = value; }
}


/* Rol: AccessMode o--> AdaptationRequest */
private IList<AdaptationRequestDTOA> adaptationRequest;
public IList<AdaptationRequestDTOA> AdaptationRequest
{
        get { return adaptationRequest; }
        set { adaptationRequest = value; }
}

/* Rol: AccessMode o--> AdaptationTypeRequired */
private IList<AdaptationTypeRequiredDTOA> adaptationType;
public IList<AdaptationTypeRequiredDTOA> AdaptationType
{
        get { return adaptationType; }
        set { adaptationType = value; }
}

/* Rol: AccessMode o--> AdaptationDetailRequired */
private IList<AdaptationDetailRequiredDTOA> adaptationDetail;
public IList<AdaptationDetailRequiredDTOA> AdaptationDetail
{
        get { return adaptationDetail; }
        set { adaptationDetail = value; }
}
}
}
