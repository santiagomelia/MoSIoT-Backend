
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

public IList<IMAdaptationRequestEN> PaAdaptionRequest (int id)
{
        IList<IMAdaptationRequestEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMAdaptationRequestEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMAdaptationRequestEN>();

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

public IList<IMAdaptationTypeEN> PaAdaptionType (int id)
{
        IList<IMAdaptationTypeEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMAdaptationTypeEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMAdaptationTypeEN>();

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

public IList<IMAdaptationDetailEN> PaAdaptionDetails (int id)
{
        IList<IMAdaptationDetailEN> result = null;

        try
        {
                SessionInitializeTransaction ();

                String sql = @"select self FROM EntityAttributesEN self inner join self.Entity as target with target.Id=:p_Id where self.class = IMAdaptationDetailEN";
                IQuery query = session.CreateQuery (sql).SetParameter ("p_Id", id);




                result = query.List<IMAdaptationDetailEN>();

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
