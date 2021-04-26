
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
public class IMAppointmentRESTCAD : IMAppointmentCAD
{
public IMAppointmentRESTCAD()
        : base ()
{
}

public IMAppointmentRESTCAD(ISession sessionAux)
        : base (sessionAux)
{
}



public AppointmentEN ValueAppointment (int id)
{
        AppointmentEN result = null;

        try
        {
                SessionInitializeTransaction ();


                String sql = @"select self.Appointment FROM IMAppointmentEN self " +
                             "where self.Id = :p_Id";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.UniqueResult<AppointmentEN>();

                SessionCommit ();
        }

        catch (Exception ex)
        {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException) throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAppointmentRESTCAD.", ex);
        }

        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
