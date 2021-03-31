
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
public class StateDeviceRESTCAD : StateDeviceCAD
{
public StateDeviceRESTCAD()
        : base ()
{
}

public StateDeviceRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
