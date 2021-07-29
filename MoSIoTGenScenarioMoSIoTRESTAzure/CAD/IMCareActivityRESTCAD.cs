
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
public class IMCareActivityRESTCAD : IMCareActivityCAD
{
public IMCareActivityRESTCAD()
        : base ()
{
}

public IMCareActivityRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public CareActivityEN ValueCareActivity (int id)
{
        CareActivityEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.CareActivity FROM IMCareActivityEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<CareActivityEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMMedicationEN> MedicationCareActivity (int id)
{
        IList<IMMedicationEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMMedicationEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMMedicationEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMAppointmentEN> AppointmentCareActitivy (int id)
{
        IList<IMAppointmentEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMAppointmentEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMAppointmentEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMCommunicationEN> CommunicationCareActivity (int id)
{
        IList<IMCommunicationEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMCommunicationEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMCommunicationEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public IList<IMNutritionOrderEN> NutritionOrderCareActivity (int id)
{
        IList<IMNutritionOrderEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMNutritionOrderEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMNutritionOrderEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCareActivityRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
