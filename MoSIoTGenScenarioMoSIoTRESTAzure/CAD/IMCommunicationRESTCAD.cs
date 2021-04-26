
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
public class IMCommunicationRESTCAD : IMCommunicationCAD
{
public IMCommunicationRESTCAD()
        : base ()
{
}

public IMCommunicationRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public ComunicationEN ValueCommunication (int id)
{
        ComunicationEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Comunication FROM IMCommunicationEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<ComunicationEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
