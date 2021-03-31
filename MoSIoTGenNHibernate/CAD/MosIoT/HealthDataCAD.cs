
using System;
using System.Text;
using MoSIoTGenNHibernate.CEN.MosIoT;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.Exceptions;


/*
 * Clase HealthData:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class HealthDataCAD : BasicCAD, IHealthDataCAD
{
public HealthDataCAD() : base ()
{
}

public HealthDataCAD(ISession sessionAux) : base (sessionAux)
{
}



public HealthDataEN ReadOIDDefault (int id
                                    )
{
        HealthDataEN healthDataEN = null;

        try
        {
                SessionInitializeTransaction ();
                healthDataEN = (HealthDataEN)session.Get (typeof(HealthDataEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in HealthDataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return healthDataEN;
}

public System.Collections.Generic.IList<HealthDataEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<HealthDataEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(HealthDataEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<HealthDataEN>();
                        else
                                result = session.CreateCriteria (typeof(HealthDataEN)).List<HealthDataEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in HealthDataCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (HealthDataEN healthData)
{
        try
        {
                SessionInitializeTransaction ();
                HealthDataEN healthDataEN = (HealthDataEN)session.Load (typeof(HealthDataEN), healthData.Id);

                healthDataEN.Description = healthData.Description;


                healthDataEN.Language = healthData.Language;


                healthDataEN.System = healthData.System;


                healthDataEN.Code = healthData.Code;


                healthDataEN.Display = healthData.Display;

                session.Update (healthDataEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in HealthDataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (HealthDataEN healthData)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (healthData);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in HealthDataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return healthData.Id;
}

public void Modify (HealthDataEN healthData)
{
        try
        {
                SessionInitializeTransaction ();
                HealthDataEN healthDataEN = (HealthDataEN)session.Load (typeof(HealthDataEN), healthData.Id);

                healthDataEN.Description = healthData.Description;


                healthDataEN.Language = healthData.Language;


                healthDataEN.System = healthData.System;


                healthDataEN.Code = healthData.Code;


                healthDataEN.Display = healthData.Display;

                session.Update (healthDataEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in HealthDataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                HealthDataEN healthDataEN = (HealthDataEN)session.Load (typeof(HealthDataEN), id);
                session.Delete (healthDataEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in HealthDataCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
