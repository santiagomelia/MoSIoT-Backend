
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



public IList<CareActivityEN> CareActivities (int id)
{
        IList<CareActivityEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM CareActivityEN self inner join self.CarePlan as target with target.Id=:p_Id";
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

public IList<GoalEN> Goals (int id)
{
        IList<GoalEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM GoalEN self inner join self.CarePlan as target with target.Id=:p_Id";
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

public PatientProfileEN Patient (int id)
{
        PatientProfileEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.PatientProfile FROM CarePlanTemplateEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<PatientProfileEN>();

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
