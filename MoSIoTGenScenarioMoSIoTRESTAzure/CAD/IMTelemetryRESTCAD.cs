
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
public class IMTelemetryRESTCAD : IMTelemetryCAD
{
public IMTelemetryRESTCAD()
        : base ()
{
}

public IMTelemetryRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public TelemetryEN Telemetry (int id)
{
        TelemetryEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Telemetry FROM IMTelemetryEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<TelemetryEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTelemetryRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
