
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
 * Clase IMMedication:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMMedicationCAD : BasicCAD, IIMMedicationCAD
{
public IMMedicationCAD() : base ()
{
}

public IMMedicationCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMMedicationEN ReadOIDDefault (int id
                                      )
{
        IMMedicationEN iMMedicationEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMMedicationEN = (IMMedicationEN)session.Get (typeof(IMMedicationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMMedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMMedicationEN;
}

public System.Collections.Generic.IList<IMMedicationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMMedicationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMMedicationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMMedicationEN>();
                        else
                                result = session.CreateCriteria (typeof(IMMedicationEN)).List<IMMedicationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMMedicationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMMedicationEN iMMedication)
{
        try
        {
                SessionInitializeTransaction ();
                IMMedicationEN iMMedicationEN = (IMMedicationEN)session.Load (typeof(IMMedicationEN), iMMedication.Id);

                session.Update (iMMedicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMMedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMMedicationEN iMMedication)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMMedication.Entity != null) {
                        // Argumento OID y no colección.
                        iMMedication.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMMedication.Entity.Id);

                        iMMedication.Entity.Attributes
                        .Add (iMMedication);
                }

                session.Save (iMMedication);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMMedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMMedication.Id;
}

public void Modify (IMMedicationEN iMMedication)
{
        try
        {
                SessionInitializeTransaction ();
                IMMedicationEN iMMedicationEN = (IMMedicationEN)session.Load (typeof(IMMedicationEN), iMMedication.Id);

                iMMedicationEN.Name = iMMedication.Name;


                iMMedicationEN.Description = iMMedication.Description;

                session.Update (iMMedicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMMedicationCAD.", ex);
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
                IMMedicationEN iMMedicationEN = (IMMedicationEN)session.Load (typeof(IMMedicationEN), id);
                session.Delete (iMMedicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMMedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMMedicationEN
public IMMedicationEN ReadOID (int id
                               )
{
        IMMedicationEN iMMedicationEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMMedicationEN = (IMMedicationEN)session.Get (typeof(IMMedicationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMMedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMMedicationEN;
}

public System.Collections.Generic.IList<IMMedicationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMMedicationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMMedicationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMMedicationEN>();
                else
                        result = session.CreateCriteria (typeof(IMMedicationEN)).List<IMMedicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMMedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AssignMedication (int p_IMMedication_OID, int p_medication_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.IMMedicationEN iMMedicationEN = null;
        try
        {
                SessionInitializeTransaction ();
                iMMedicationEN = (IMMedicationEN)session.Load (typeof(IMMedicationEN), p_IMMedication_OID);
                iMMedicationEN.Medication = (MoSIoTGenNHibernate.EN.MosIoT.MedicationEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.MedicationEN), p_medication_OID);



                session.Update (iMMedicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMMedicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
