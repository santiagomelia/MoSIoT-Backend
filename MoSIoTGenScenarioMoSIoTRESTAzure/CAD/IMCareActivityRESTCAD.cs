
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
}
}
