
using System;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;

using System.Collections.Generic;

using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.CAD
{
public class DisabilityRESTCAD : DisabilityCAD
{
public DisabilityRESTCAD()
        : base ()
{
}

public DisabilityRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
