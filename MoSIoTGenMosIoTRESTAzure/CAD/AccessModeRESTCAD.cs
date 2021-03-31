
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
public class AccessModeRESTCAD : AccessModeCAD
{
public AccessModeRESTCAD()
        : base ()
{
}

public AccessModeRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public IList<AdaptationTypeRequiredEN> AdaptationType (int id)
{
        IList<AdaptationTypeRequiredEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM AdaptationTypeRequiredEN self inner join self.AccessMode as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<AdaptationTypeRequiredEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<AdaptationDetailRequiredEN> AdaptationDetail (int id)
{
        IList<AdaptationDetailRequiredEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM AdaptationDetailRequiredEN self inner join self.AccessMode as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<AdaptationDetailRequiredEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<AdaptationRequestEN> AdaptationRequest (int id)
{
        IList<AdaptationRequestEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM AdaptationRequestEN self inner join self.AccessMode as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<AdaptationRequestEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<DeviceTemplateEN> DeviceTemplateByAccessMode (int id)
{
        IList<DeviceTemplateEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM DeviceTemplateEN self inner join self.AccessMode as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<DeviceTemplateEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AccessModeRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
