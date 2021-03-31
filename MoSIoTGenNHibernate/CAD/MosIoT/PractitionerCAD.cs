
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
 * Clase Practitioner:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class PractitionerCAD : BasicCAD, IPractitionerCAD
{
public PractitionerCAD() : base ()
{
}

public PractitionerCAD(ISession sessionAux) : base (sessionAux)
{
}



public PractitionerEN ReadOIDDefault (int id
                                      )
{
        PractitionerEN practitionerEN = null;

        try
        {
                SessionInitializeTransaction ();
                practitionerEN = (PractitionerEN)session.Get (typeof(PractitionerEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return practitionerEN;
}

public System.Collections.Generic.IList<PractitionerEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PractitionerEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PractitionerEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PractitionerEN>();
                        else
                                result = session.CreateCriteria (typeof(PractitionerEN)).List<PractitionerEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PractitionerEN practitioner)
{
        try
        {
                SessionInitializeTransaction ();
                PractitionerEN practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), practitioner.Id);
                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PractitionerEN practitioner)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (practitioner);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return practitioner.Id;
}

public void Modify (PractitionerEN practitioner)
{
        try
        {
                SessionInitializeTransaction ();
                PractitionerEN practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), practitioner.Id);

                practitionerEN.Surnames = practitioner.Surnames;


                practitionerEN.IsActive = practitioner.IsActive;


                practitionerEN.IsDiseased = practitioner.IsDiseased;


                practitionerEN.Pass = practitioner.Pass;


                practitionerEN.Name = practitioner.Name;


                practitionerEN.Description = practitioner.Description;


                practitionerEN.Email = practitioner.Email;

                session.Update (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
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
                PractitionerEN practitionerEN = (PractitionerEN)session.Load (typeof(PractitionerEN), id);
                session.Delete (practitionerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PractitionerEN
public PractitionerEN ReadOID (int id
                               )
{
        PractitionerEN practitionerEN = null;

        try
        {
                SessionInitializeTransaction ();
                practitionerEN = (PractitionerEN)session.Get (typeof(PractitionerEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return practitionerEN;
}

public System.Collections.Generic.IList<PractitionerEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PractitionerEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PractitionerEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PractitionerEN>();
                else
                        result = session.CreateCriteria (typeof(PractitionerEN)).List<PractitionerEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PractitionerCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
