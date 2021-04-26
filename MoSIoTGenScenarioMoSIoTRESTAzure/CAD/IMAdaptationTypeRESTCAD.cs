
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
public class IMAdaptationTypeRESTCAD : IMAdaptationTypeCAD
{
public IMAdaptationTypeRESTCAD()
        : base ()
{
}

public IMAdaptationTypeRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public AdaptationTypeRequiredEN ValueAdaptionType (int id)
{
        AdaptationTypeRequiredEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.AdaptationTypeRequired FROM IMAdaptationTypeEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<AdaptationTypeRequiredEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationTypeRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
