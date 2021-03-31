
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
