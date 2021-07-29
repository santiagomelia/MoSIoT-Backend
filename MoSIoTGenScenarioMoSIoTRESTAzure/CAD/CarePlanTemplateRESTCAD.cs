
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
public class CarePlanTemplateRESTCAD : CarePlanTemplateCAD
{
public CarePlanTemplateRESTCAD()
        : base ()
{
}

public CarePlanTemplateRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public IList<GoalEN> Goals (int id)
{
        IList<GoalEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM GoalEN self inner join self.CarePlanTemplate as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<GoalEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<CareActivityEN> CareActivities (int id)
{
        IList<CareActivityEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM CareActivityEN self inner join self.CarePlanTemplate as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<CareActivityEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<CareActivityEN> CarePlanActivities (int id)
{
        IList<CareActivityEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM CareActivityEN self inner join self.CarePlanTemplate as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<CareActivityEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
