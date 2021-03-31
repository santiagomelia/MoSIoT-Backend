using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class AdaptationRequestDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum accessModeTarget;
public MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum AccessModeTarget
{
        get { return accessModeTarget; }
        set { accessModeTarget = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum languageOfAdaptation;
public MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum LanguageOfAdaptation
{
        get { return languageOfAdaptation; }
        set { languageOfAdaptation = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}
}
}
