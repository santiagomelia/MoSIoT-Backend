
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
public class IMAdaptationRequestRESTCAD : IMAdaptationRequestCAD
{
public IMAdaptationRequestRESTCAD()
        : base ()
{
}

public IMAdaptationRequestRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public AdaptationRequestEN ValueAdaption (int id)
{
        AdaptationRequestEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.AdaptationRequest FROM IMAdaptationRequestEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<AdaptationRequestEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationRequestRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
