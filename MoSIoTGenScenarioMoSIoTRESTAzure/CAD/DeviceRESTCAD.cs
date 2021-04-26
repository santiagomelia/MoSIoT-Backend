
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
}
}
