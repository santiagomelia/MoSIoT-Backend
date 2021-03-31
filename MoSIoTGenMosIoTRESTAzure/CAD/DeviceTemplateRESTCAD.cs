
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
public class DeviceTemplateRESTCAD : DeviceTemplateCAD
{
public DeviceTemplateRESTCAD()
        : base ()
{
}

public DeviceTemplateRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public IList<PropertyEN> Properties (int id)
{
        IList<PropertyEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM PropertyEN self inner join self.DeviceTemplate as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<PropertyEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<CommandEN> Commands (int id)
{
        IList<CommandEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM CommandEN self inner join self.DeviceTemplate as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<CommandEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<TelemetryEN> Telemetries (int id)
{
        IList<TelemetryEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM TelemetryEN self inner join self.DeviceTemplate as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<TelemetryEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
