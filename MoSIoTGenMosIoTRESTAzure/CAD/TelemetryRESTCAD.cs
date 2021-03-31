
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
public class TelemetryRESTCAD : TelemetryCAD
{
public TelemetryRESTCAD()
        : base ()
{
}

public TelemetryRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public SensorTelemetryEN Sensor (int id)
{
        SensorTelemetryEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.TypeTelemetry FROM TelemetryEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<SensorTelemetryEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public StateTelemetryEN State (int id)
{
        StateTelemetryEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.TypeTelemetry FROM TelemetryEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<StateTelemetryEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public LocationTelemetryEN Location (int id)
{
        LocationTelemetryEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.TypeTelemetry FROM TelemetryEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<LocationTelemetryEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public EventTelemetryEN Event_ (int id)
{
        EventTelemetryEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.TypeTelemetry FROM TelemetryEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<EventTelemetryEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TelemetryRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
