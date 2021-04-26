using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class ConditionDTOA
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

private MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum disease;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum Disease
{
        get { return disease; }
        set { disease = value; }
}
}
}
