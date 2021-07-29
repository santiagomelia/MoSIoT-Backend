
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
public class PatientProfileRESTCAD : PatientProfileCAD
{
public PatientProfileRESTCAD()
        : base ()
{
}

public PatientProfileRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public IList<ConditionEN> Diseases (int id)
{
        IList<ConditionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ConditionEN self inner join self.PatientProfile as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<ConditionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<DisabilityEN> Disabilities (int id)
{
        IList<DisabilityEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM DisabilityEN self inner join self.Patient as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<DisabilityEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<AccessModeEN> ProfileAccessMode (int id)
{
        IList<AccessModeEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM AccessModeEN self inner join self.Patient as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<AccessModeEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<ConditionEN> ProfileConditions (int id)
{
        IList<ConditionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ConditionEN self inner join self.PatientProfile as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<ConditionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<DisabilityEN> ProfileDisabilities (int id)
{
        IList<DisabilityEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM DisabilityEN self inner join self.Patient as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<DisabilityEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<CarePlanTemplateEN> PatientProfileCarePlanTemplate (int id)
{
        IList<CarePlanTemplateEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM CarePlanTemplateEN self inner join self.PatientProfile as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<CarePlanTemplateEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientProfileRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
