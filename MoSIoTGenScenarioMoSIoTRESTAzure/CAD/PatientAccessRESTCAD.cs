
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
public class PatientAccessRESTCAD : PatientAccessCAD
{
public PatientAccessRESTCAD()
        : base ()
{
}

public PatientAccessRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public AccessModeEN AccessMode (int id)
{
        AccessModeEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.AccessMode FROM PatientAccessEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<AccessModeEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PatientAccessRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
