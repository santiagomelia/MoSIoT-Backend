
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
 * Clase Medication:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class MedicationCAD : BasicCAD, IMedicationCAD
{
public MedicationCAD() : base ()
{
}

public MedicationCAD(ISession sessionAux) : base (sessionAux)
{
}



public MedicationEN ReadOIDDefault (int productReference
                                    )
{
        MedicationEN medicationEN = null;

        try
        {
                SessionInitializeTransaction ();
                medicationEN = (MedicationEN)session.Get (typeof(MedicationEN), productReference);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return medicationEN;
}

public System.Collections.Generic.IList<MedicationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MedicationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MedicationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MedicationEN>();
                        else
                                result = session.CreateCriteria (typeof(MedicationEN)).List<MedicationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MedicationEN medication)
{
        try
        {
                SessionInitializeTransaction ();
                MedicationEN medicationEN = (MedicationEN)session.Load (typeof(MedicationEN), medication.ProductReference);


                medicationEN.Name = medication.Name;


                medicationEN.Manufacturer = medication.Manufacturer;


                medicationEN.Description = medication.Description;


                medicationEN.Dosage = medication.Dosage;


                medicationEN.Form = medication.Form;


                medicationEN.MedicationCode = medication.MedicationCode;

                session.Update (medicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MedicationEN medication)
{
        try
        {
                SessionInitializeTransaction ();
                if (medication.CareActivity != null) {
                        // Argumento OID y no colección.
                        medication.CareActivity = (MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN), medication.CareActivity.Id);

                        medication.CareActivity.Medication
                                = medication;
                }

                session.Save (medication);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return medication.ProductReference;
}

public void Modify (MedicationEN medication)
{
        try
        {
                SessionInitializeTransaction ();
                MedicationEN medicationEN = (MedicationEN)session.Load (typeof(MedicationEN), medication.ProductReference);

                medicationEN.Name = medication.Name;


                medicationEN.Manufacturer = medication.Manufacturer;


                medicationEN.Description = medication.Description;


                medicationEN.Dosage = medication.Dosage;


                medicationEN.Form = medication.Form;


                medicationEN.MedicationCode = medication.MedicationCode;

                session.Update (medicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int productReference
                     )
{
        try
        {
                SessionInitializeTransaction ();
                MedicationEN medicationEN = (MedicationEN)session.Load (typeof(MedicationEN), productReference);
                session.Delete (medicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: MedicationEN
public MedicationEN ReadOID (int productReference
                             )
{
        MedicationEN medicationEN = null;

        try
        {
                SessionInitializeTransaction ();
                medicationEN = (MedicationEN)session.Get (typeof(MedicationEN), productReference);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return medicationEN;
}

public System.Collections.Generic.IList<MedicationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MedicationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MedicationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MedicationEN>();
                else
                        result = session.CreateCriteria (typeof(MedicationEN)).List<MedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
