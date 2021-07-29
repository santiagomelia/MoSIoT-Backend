
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
public class DeviceRESTCAD : DeviceCAD
{
public DeviceRESTCAD()
        : base ()
{
}

public DeviceRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public DeviceTemplateEN DeviceTemplate (int id)
{
        DeviceTemplateEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.DeviceTemplate FROM DeviceEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<DeviceTemplateEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMCommandEN> DeviceCommands (int id)
{
        IList<IMCommandEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityOperationEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMCommandEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMCommandEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMPropertyEN> DeviceProperties (int id)
{
        IList<IMPropertyEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMPropertyEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMPropertyEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
