using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class ConditionDTOA
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

private MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum clinicalStatus;
public MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum ClinicalStatus
{
        get { return clinicalStatus; }
        set { clinicalStatus = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum disease;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum Disease
{
        get { return disease; }
        set { disease = value; }
}

private string name;
public string Name
{
        get { return name; }
        set { name = value; }
}
}
}
