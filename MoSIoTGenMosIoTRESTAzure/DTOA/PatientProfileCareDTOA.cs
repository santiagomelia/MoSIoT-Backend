using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class PatientProfileCareDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum preferredLanguage;
public MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum PreferredLanguage
{
        get { return preferredLanguage; }
        set { preferredLanguage = value; }
}

private string region;
public string Region
{
        get { return region; }
        set { region = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum hazardAvoidance;
public MoSIoTGenNHibernate.Enumerated.MosIoT.HazardValueEnum HazardAvoidance
{
        get { return hazardAvoidance; }
        set { hazardAvoidance = value; }
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
}
}
