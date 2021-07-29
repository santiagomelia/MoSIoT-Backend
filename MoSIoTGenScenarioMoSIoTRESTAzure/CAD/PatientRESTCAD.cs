
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
public class PatientRESTCAD : PatientCAD
{
public PatientRESTCAD()
        : base ()
{
}

public PatientRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public PatientProfileEN PatientProfile (int id)
{
        PatientProfileEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.PatientProfile FROM PatientEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<PatientProfileEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public UserEN UserData (int id)
{
        UserEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.UserPatient FROM PatientEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<UserEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMDisabilityEN> PatientDisabilities (int id)
{
        IList<IMDisabilityEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMDisabilityEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMDisabilityEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMConditionEN> PatientConditions (int id)
{
        IList<IMConditionEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMConditionEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMConditionEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
