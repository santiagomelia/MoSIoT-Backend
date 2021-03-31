
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
 * Clase Inheritance:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class InheritanceCAD : BasicCAD, IInheritanceCAD
{
public InheritanceCAD() : base ()
{
}

public InheritanceCAD(ISession sessionAux) : base (sessionAux)
{
}



public InheritanceEN ReadOIDDefault (int id
                                     )
{
        InheritanceEN inheritanceEN = null;

        try
        {
                SessionInitializeTransaction ();
                inheritanceEN = (InheritanceEN)session.Get (typeof(InheritanceEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in InheritanceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return inheritanceEN;
}

public System.Collections.Generic.IList<InheritanceEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<InheritanceEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(InheritanceEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<InheritanceEN>();
                        else
                                result = session.CreateCriteria (typeof(InheritanceEN)).List<InheritanceEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in InheritanceCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (InheritanceEN inheritance)
{
        try
        {
                SessionInitializeTransaction ();
                InheritanceEN inheritanceEN = (InheritanceEN)session.Load (typeof(InheritanceEN), inheritance.Id);


                session.Update (inheritanceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in InheritanceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (InheritanceEN inheritance)
{
        try
        {
                SessionInitializeTransaction ();
                if (inheritance.Son != null) {
                        // Argumento OID y no colección.
                        inheritance.Son = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), inheritance.Son.Id);

                        inheritance.Son.InheritanceSon
                        .Add (inheritance);
                }

                session.Save (inheritance);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in InheritanceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return inheritance.Id;
}

public void Modify (InheritanceEN inheritance)
{
        try
        {
                SessionInitializeTransaction ();
                InheritanceEN inheritanceEN = (InheritanceEN)session.Load (typeof(InheritanceEN), inheritance.Id);
                session.Update (inheritanceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in InheritanceCAD.", ex);
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
                InheritanceEN inheritanceEN = (InheritanceEN)session.Load (typeof(InheritanceEN), id);
                session.Delete (inheritanceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in InheritanceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: InheritanceEN
public InheritanceEN ReadOID (int id
                              )
{
        InheritanceEN inheritanceEN = null;

        try
        {
                SessionInitializeTransaction ();
                inheritanceEN = (InheritanceEN)session.Get (typeof(InheritanceEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in InheritanceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return inheritanceEN;
}

public System.Collections.Generic.IList<InheritanceEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<InheritanceEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(InheritanceEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<InheritanceEN>();
                else
                        result = session.CreateCriteria (typeof(InheritanceEN)).List<InheritanceEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in InheritanceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
