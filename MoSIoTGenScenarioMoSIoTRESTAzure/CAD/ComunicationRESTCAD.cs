
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
public class ComunicationRESTCAD : ComunicationCAD
{
public ComunicationRESTCAD()
        : base ()
{
}

public ComunicationRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
