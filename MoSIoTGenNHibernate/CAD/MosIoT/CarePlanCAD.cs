
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
 * Clase CarePlan:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class CarePlanCAD : BasicCAD, ICarePlanCAD
{
public CarePlanCAD() : base ()
{
}

public CarePlanCAD(ISession sessionAux) : base (sessionAux)
{
}



public CarePlanEN ReadOIDDefault (int id
                                  )
{
        CarePlanEN carePlanEN = null;

        try
        {
                SessionInitializeTransaction ();
                carePlanEN = (CarePlanEN)session.Get (typeof(CarePlanEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanEN;
}

public System.Collections.Generic.IList<CarePlanEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CarePlanEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CarePlanEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CarePlanEN>();
                        else
                                result = session.CreateCriteria (typeof(CarePlanEN)).List<CarePlanEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CarePlanEN carePlan)
{
        try
        {
                SessionInitializeTransaction ();
                CarePlanEN carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), carePlan.Id);

                session.Update (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CarePlanEN carePlan)
{
        try
        {
                SessionInitializeTransaction ();
                if (carePlan.Scenario != null) {
                        // Argumento OID y no colección.
                        carePlan.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), carePlan.Scenario.Id);

                        carePlan.Scenario.Entity
                        .Add (carePlan);
                }
                if (carePlan.Template != null) {
                        // Argumento OID y no colección.
                        carePlan.Template = (MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN), carePlan.Template.Id);
                }

                session.Save (carePlan);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlan.Id;
}

public void Modify (CarePlanEN carePlan)
{
        try
        {
                SessionInitializeTransaction ();
                CarePlanEN carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), carePlan.Id);

                carePlanEN.Name = carePlan.Name;


                carePlanEN.Description = carePlan.Description;

                session.Update (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
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
                CarePlanEN carePlanEN = (CarePlanEN)session.Load (typeof(CarePlanEN), id);
                session.Delete (carePlanEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: CarePlanEN
public CarePlanEN ReadOID (int id
                           )
{
        CarePlanEN carePlanEN = null;

        try
        {
                SessionInitializeTransaction ();
                carePlanEN = (CarePlanEN)session.Get (typeof(CarePlanEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanEN;
}

public System.Collections.Generic.IList<CarePlanEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarePlanEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CarePlanEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CarePlanEN>();
                else
                        result = session.CreateCriteria (typeof(CarePlanEN)).List<CarePlanEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
