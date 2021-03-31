
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
 * Clase Disability:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class DisabilityCAD : BasicCAD, IDisabilityCAD
{
public DisabilityCAD() : base ()
{
}

public DisabilityCAD(ISession sessionAux) : base (sessionAux)
{
}



public DisabilityEN ReadOIDDefault (int id
                                    )
{
        DisabilityEN disabilityEN = null;

        try
        {
                SessionInitializeTransaction ();
                disabilityEN = (DisabilityEN)session.Get (typeof(DisabilityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return disabilityEN;
}

public System.Collections.Generic.IList<DisabilityEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DisabilityEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DisabilityEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DisabilityEN>();
                        else
                                result = session.CreateCriteria (typeof(DisabilityEN)).List<DisabilityEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DisabilityCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DisabilityEN disability)
{
        try
        {
                SessionInitializeTransaction ();
                DisabilityEN disabilityEN = (DisabilityEN)session.Load (typeof(DisabilityEN), disability.Id);


                disabilityEN.Name = disability.Name;


                disabilityEN.Type = disability.Type;


                disabilityEN.Severity = disability.Severity;




                disabilityEN.Description = disability.Description;

                session.Update (disabilityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (DisabilityEN disability)
{
        try
        {
                SessionInitializeTransaction ();
                if (disability.Patient != null) {
                        // Argumento OID y no colección.
                        disability.Patient = (MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN), disability.Patient.Id);

                        disability.Patient.Disability
                        .Add (disability);
                }

                session.Save (disability);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return disability.Id;
}

public void Modify (DisabilityEN disability)
{
        try
        {
                SessionInitializeTransaction ();
                DisabilityEN disabilityEN = (DisabilityEN)session.Load (typeof(DisabilityEN), disability.Id);

                disabilityEN.Name = disability.Name;


                disabilityEN.Type = disability.Type;


                disabilityEN.Severity = disability.Severity;


                disabilityEN.Description = disability.Description;

                session.Update (disabilityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DisabilityCAD.", ex);
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
                DisabilityEN disabilityEN = (DisabilityEN)session.Load (typeof(DisabilityEN), id);
                session.Delete (disabilityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: DisabilityEN
public DisabilityEN ReadOID (int id
                             )
{
        DisabilityEN disabilityEN = null;

        try
        {
                SessionInitializeTransaction ();
                disabilityEN = (DisabilityEN)session.Get (typeof(DisabilityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return disabilityEN;
}

public System.Collections.Generic.IList<DisabilityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DisabilityEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DisabilityEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DisabilityEN>();
                else
                        result = session.CreateCriteria (typeof(DisabilityEN)).List<DisabilityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
