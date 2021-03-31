
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using MoSIoTGenNHibernate.Exceptions;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;



namespace MoSIoTGenNHibernate.CP.MosIoT
{
public partial class MedicationCP : BasicCP
{
public MedicationCP() : base ()
{
}

public MedicationCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
