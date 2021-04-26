
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
 * Clase IMDisability:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMDisabilityCAD : BasicCAD, IIMDisabilityCAD
{
public IMDisabilityCAD() : base ()
{
}

public IMDisabilityCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMDisabilityEN ReadOIDDefault (int id
                                      )
{
        IMDisabilityEN iMDisabilityEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMDisabilityEN = (IMDisabilityEN)session.Get (typeof(IMDisabilityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMDisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMDisabilityEN;
}

public System.Collections.Generic.IList<IMDisabilityEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMDisabilityEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMDisabilityEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMDisabilityEN>();
                        else
                                result = session.CreateCriteria (typeof(IMDisabilityEN)).List<IMDisabilityEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMDisabilityCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMDisabilityEN iMDisability)
{
        try
        {
                SessionInitializeTransaction ();
                IMDisabilityEN iMDisabilityEN = (IMDisabilityEN)session.Load (typeof(IMDisabilityEN), iMDisability.Id);

                session.Update (iMDisabilityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMDisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMDisabilityEN iMDisability)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMDisability.Entity != null) {
                        // Argumento OID y no colección.
                        iMDisability.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMDisability.Entity.Id);

                        iMDisability.Entity.Attributes
                        .Add (iMDisability);
                }
                if (iMDisability.Disability != null) {
                        // Argumento OID y no colección.
                        iMDisability.Disability = (MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.DisabilityEN), iMDisability.Disability.Id);
                }

                session.Save (iMDisability);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMDisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMDisability.Id;
}

public void Modify (IMDisabilityEN iMDisability)
{
        try
        {
                SessionInitializeTransaction ();
                IMDisabilityEN iMDisabilityEN = (IMDisabilityEN)session.Load (typeof(IMDisabilityEN), iMDisability.Id);

                iMDisabilityEN.Name = iMDisability.Name;


                iMDisabilityEN.Type = iMDisability.Type;


                iMDisabilityEN.IsOID = iMDisability.IsOID;


                iMDisabilityEN.IsWritable = iMDisability.IsWritable;


                iMDisabilityEN.Description = iMDisability.Description;


                iMDisabilityEN.Value = iMDisability.Value;

                session.Update (iMDisabilityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMDisabilityCAD.", ex);
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
                IMDisabilityEN iMDisabilityEN = (IMDisabilityEN)session.Load (typeof(IMDisabilityEN), id);
                session.Delete (iMDisabilityEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMDisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMDisabilityEN
public IMDisabilityEN ReadOID (int id
                               )
{
        IMDisabilityEN iMDisabilityEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMDisabilityEN = (IMDisabilityEN)session.Get (typeof(IMDisabilityEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMDisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMDisabilityEN;
}

public System.Collections.Generic.IList<IMDisabilityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMDisabilityEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMDisabilityEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMDisabilityEN>();
                else
                        result = session.CreateCriteria (typeof(IMDisabilityEN)).List<IMDisabilityEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMDisabilityCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
