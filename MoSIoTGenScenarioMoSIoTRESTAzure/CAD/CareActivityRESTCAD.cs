
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
public class CareActivityRESTCAD : CareActivityCAD
{
public CareActivityRESTCAD()
        : base ()
{
}

public CareActivityRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public IList<ComunicationEN> Comunications (int id)
{
        IList<ComunicationEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM ComunicationEN self inner join self.CareActivity as target with target.Id=:p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<ComunicationEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public AppointmentEN Appointments (int id)
{
        AppointmentEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Appointment FROM CareActivityEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<AppointmentEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public MedicationEN Medications (int id)
{
        MedicationEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Medication FROM CareActivityEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<MedicationEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}

public NutritionOrderEN NutritionOrders (int id)
{
        NutritionOrderEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.NutritionOrder FROM CareActivityEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<NutritionOrderEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CareActivityRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
