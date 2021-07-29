
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
public class IMNutritionOrderRESTCAD : IMNutritionOrderCAD
{
public IMNutritionOrderRESTCAD()
        : base ()
{
}

public IMNutritionOrderRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public NutritionOrderEN ValueNutrition (int id)
{
        NutritionOrderEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.NutritionOrder FROM IMNutritionOrderEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<NutritionOrderEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMNutritionOrderRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
