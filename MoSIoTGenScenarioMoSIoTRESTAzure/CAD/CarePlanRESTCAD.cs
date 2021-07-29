
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
public class CarePlanRESTCAD : CarePlanCAD
{
public CarePlanRESTCAD()
        : base ()
{
}

public CarePlanRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public CarePlanTemplateEN CarePlanTemplate (int id)
{
        CarePlanTemplateEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Template FROM CarePlanEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<CarePlanTemplateEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMGoalEN> GoalsCarePlan (int id)
{
        IList<IMGoalEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMGoalEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMGoalEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMTargetEN> TargetsCarePlan (int id)
{
        IList<IMTargetEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMTargetEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMTargetEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
