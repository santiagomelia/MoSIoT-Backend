
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
public class IoTScenarioRESTCAD : IoTScenarioCAD
{
public IoTScenarioRESTCAD()
        : base ()
{
}

public IoTScenarioRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public IList<PatientEN> PatientScenario (int id)
{
        IList<PatientEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id where self.class = PatientEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<PatientEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<EntityEN> Entities (int id)
{
        IList<EntityEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<EntityEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<PatientAccessEN> PatientAccessScenario (int id)
{
        IList<PatientAccessEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id where self.class = PatientAccessEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<PatientAccessEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<DeviceEN> DevicesScenario (int id)
{
        IList<DeviceEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id where self.class = DeviceEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<DeviceEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<CarePlanEN> CarePlanScenario (int id)
{
        IList<CarePlanEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id where self.class = CarePlanEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<CarePlanEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<VitalSignEN> VitalSignsScenario (int id)
{
        IList<VitalSignEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id where self.class = VitalSignEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<VitalSignEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMTelemetryEN> IMTelemetriesScenario (int id)
{
        IList<IMTelemetryEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id where self.class = IMTelemetryEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMTelemetryEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<PractitionerEN> Practitioners (int id)
{
        IList<PractitionerEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id where self.class = PractitionerEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<PractitionerEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<RelatedPersonEN> RelatedPeople (int id)
{
        IList<RelatedPersonEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id where self.class = RelatedPersonEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<RelatedPersonEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMCareActivityEN> CareActivitiesScenario (int id)
{
        IList<IMCareActivityEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityEN self inner join self.Scenario as target with target.Id=:p_Id where self.class = IMCareActivityEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMCareActivityEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IoTScenarioRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
