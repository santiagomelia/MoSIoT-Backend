
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
public class MeasureRESTCAD : MeasureCAD
{
public MeasureRESTCAD()
        : base ()
{
}

public MeasureRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public IList<TelemetryEN> MeasureTelemetries (int id)
{
        IList<TelemetryEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM TelemetryEN self inner join self.VitalSign as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<TelemetryEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MeasureRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
