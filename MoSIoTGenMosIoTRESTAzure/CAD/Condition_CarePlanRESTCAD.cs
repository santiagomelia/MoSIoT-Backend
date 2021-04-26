
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

namespace MoSIoTGenMosIoTRESTAzure.CAD
{
public class Condition_CarePlanRESTCAD : ConditionCAD
{
public Condition_CarePlanRESTCAD()
        : base ()
{
}

public Condition_CarePlanRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
