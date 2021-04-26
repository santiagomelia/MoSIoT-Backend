
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
public class IMAdaptationDetailRESTCAD : IMAdaptationDetailCAD
{
public IMAdaptationDetailRESTCAD()
        : base ()
{
}

public IMAdaptationDetailRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public AdaptationDetailRequiredEN ValueAdaptionDetail (int id)
{
        AdaptationDetailRequiredEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.AdaptationDetailRequired FROM IMAdaptationDetailEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<AdaptationDetailRequiredEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
