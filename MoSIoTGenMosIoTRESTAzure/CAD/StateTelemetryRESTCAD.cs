
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
public class StateTelemetryRESTCAD : StateTelemetryCAD
{
public StateTelemetryRESTCAD()
        : base ()
{
}

public StateTelemetryRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public IList<StateDeviceEN> States (int id)
{
        IList<StateDeviceEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM StateDeviceEN self inner join self.StateTelemetry as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<StateDeviceEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in StateTelemetryRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
