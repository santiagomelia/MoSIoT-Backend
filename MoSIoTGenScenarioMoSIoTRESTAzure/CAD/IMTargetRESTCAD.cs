
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
public class IMTargetRESTCAD : IMTargetCAD
{
public IMTargetRESTCAD()
        : base ()
{
}

public IMTargetRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public TargetEN ValueTarget (int id)
{
        TargetEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Target FROM IMTargetEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<TargetEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTargetRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
