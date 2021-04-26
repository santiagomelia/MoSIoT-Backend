
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
public class TargetRESTCAD : TargetCAD
{
public TargetRESTCAD()
        : base ()
{
}

public TargetRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public MeasureEN Measure (int id)
{
        MeasureEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Measure FROM TargetEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<MeasureEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TargetRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
