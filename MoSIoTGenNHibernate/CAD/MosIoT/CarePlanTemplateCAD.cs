
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
 * Clase CarePlanTemplate:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class CarePlanTemplateCAD : BasicCAD, ICarePlanTemplateCAD
{
public CarePlanTemplateCAD() : base ()
{
}

public CarePlanTemplateCAD(ISession sessionAux) : base (sessionAux)
{
}



public CarePlanTemplateEN ReadOIDDefault (int id
                                          )
{
        CarePlanTemplateEN carePlanTemplateEN = null;

        try
        {
                SessionInitializeTransaction ();
                carePlanTemplateEN = (CarePlanTemplateEN)session.Get (typeof(CarePlanTemplateEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanTemplateEN;
}

public System.Collections.Generic.IList<CarePlanTemplateEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CarePlanTemplateEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CarePlanTemplateEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CarePlanTemplateEN>();
                        else
                                result = session.CreateCriteria (typeof(CarePlanTemplateEN)).List<CarePlanTemplateEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CarePlanTemplateEN carePlanTemplate)
{
        try
        {
                SessionInitializeTransaction ();
                CarePlanTemplateEN carePlanTemplateEN = (CarePlanTemplateEN)session.Load (typeof(CarePlanTemplateEN), carePlanTemplate.Id);



                carePlanTemplateEN.Status = carePlanTemplate.Status;


                carePlanTemplateEN.Intent = carePlanTemplate.Intent;


                carePlanTemplateEN.Title = carePlanTemplate.Title;


                carePlanTemplateEN.Modified = carePlanTemplate.Modified;




                carePlanTemplateEN.DurationDays = carePlanTemplate.DurationDays;


                carePlanTemplateEN.Name = carePlanTemplate.Name;


                carePlanTemplateEN.Description = carePlanTemplate.Description;


                session.Update (carePlanTemplateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CarePlanTemplateEN carePlanTemplate)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (carePlanTemplate);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanTemplate.Id;
}

public void Modify (CarePlanTemplateEN carePlanTemplate)
{
        try
        {
                SessionInitializeTransaction ();
                CarePlanTemplateEN carePlanTemplateEN = (CarePlanTemplateEN)session.Load (typeof(CarePlanTemplateEN), carePlanTemplate.Id);

                carePlanTemplateEN.Status = carePlanTemplate.Status;


                carePlanTemplateEN.Intent = carePlanTemplate.Intent;


                carePlanTemplateEN.Title = carePlanTemplate.Title;


                carePlanTemplateEN.Modified = carePlanTemplate.Modified;


                carePlanTemplateEN.DurationDays = carePlanTemplate.DurationDays;


                carePlanTemplateEN.Name = carePlanTemplate.Name;


                carePlanTemplateEN.Description = carePlanTemplate.Description;

                session.Update (carePlanTemplateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
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
                CarePlanTemplateEN carePlanTemplateEN = (CarePlanTemplateEN)session.Load (typeof(CarePlanTemplateEN), id);
                session.Delete (carePlanTemplateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void AddCondition (int p_CarePlanTemplate_OID, System.Collections.Generic.IList<int> p_addressConditions_OIDs)
{
        MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplateEN = null;
        try
        {
                SessionInitializeTransaction ();
                carePlanTemplateEN = (CarePlanTemplateEN)session.Load (typeof(CarePlanTemplateEN), p_CarePlanTemplate_OID);
                MoSIoTGenNHibernate.EN.MosIoT.ConditionEN addressConditionsENAux = null;
                if (carePlanTemplateEN.AddressConditions == null) {
                        carePlanTemplateEN.AddressConditions = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.ConditionEN>();
                }

                foreach (int item in p_addressConditions_OIDs) {
                        addressConditionsENAux = new MoSIoTGenNHibernate.EN.MosIoT.ConditionEN ();
                        addressConditionsENAux = (MoSIoTGenNHibernate.EN.MosIoT.ConditionEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.ConditionEN), item);
                        addressConditionsENAux.CarePlanTemplate.Add (carePlanTemplateEN);

                        carePlanTemplateEN.AddressConditions.Add (addressConditionsENAux);
                }


                session.Update (carePlanTemplateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: CarePlanTemplateEN
public CarePlanTemplateEN ReadOID (int id
                                   )
{
        CarePlanTemplateEN carePlanTemplateEN = null;

        try
        {
                SessionInitializeTransaction ();
                carePlanTemplateEN = (CarePlanTemplateEN)session.Get (typeof(CarePlanTemplateEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carePlanTemplateEN;
}

public System.Collections.Generic.IList<CarePlanTemplateEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarePlanTemplateEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CarePlanTemplateEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CarePlanTemplateEN>();
                else
                        result = session.CreateCriteria (typeof(CarePlanTemplateEN)).List<CarePlanTemplateEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AddPatientProfile (int p_CarePlanTemplate_OID, int p_patientProfile_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN carePlanTemplateEN = null;
        try
        {
                SessionInitializeTransaction ();
                carePlanTemplateEN = (CarePlanTemplateEN)session.Load (typeof(CarePlanTemplateEN), p_CarePlanTemplate_OID);
                carePlanTemplateEN.PatientProfile = (MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN), p_patientProfile_OID);

                carePlanTemplateEN.PatientProfile.CarePlanTemplate.Add (carePlanTemplateEN);



                session.Update (carePlanTemplateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in CarePlanTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
