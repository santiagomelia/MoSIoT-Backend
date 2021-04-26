
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
 * Clase IMAdaptationRequest:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMAdaptationRequestCAD : BasicCAD, IIMAdaptationRequestCAD
{
public IMAdaptationRequestCAD() : base ()
{
}

public IMAdaptationRequestCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMAdaptationRequestEN ReadOIDDefault (int id
                                             )
{
        IMAdaptationRequestEN iMAdaptationRequestEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMAdaptationRequestEN = (IMAdaptationRequestEN)session.Get (typeof(IMAdaptationRequestEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAdaptationRequestEN;
}

public System.Collections.Generic.IList<IMAdaptationRequestEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMAdaptationRequestEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMAdaptationRequestEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMAdaptationRequestEN>();
                        else
                                result = session.CreateCriteria (typeof(IMAdaptationRequestEN)).List<IMAdaptationRequestEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationRequestCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMAdaptationRequestEN iMAdaptationRequest)
{
        try
        {
                SessionInitializeTransaction ();
                IMAdaptationRequestEN iMAdaptationRequestEN = (IMAdaptationRequestEN)session.Load (typeof(IMAdaptationRequestEN), iMAdaptationRequest.Id);

                session.Update (iMAdaptationRequestEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMAdaptationRequestEN iMAdaptationRequest)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMAdaptationRequest.Entity != null) {
                        // Argumento OID y no colección.
                        iMAdaptationRequest.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMAdaptationRequest.Entity.Id);

                        iMAdaptationRequest.Entity.Attributes
                        .Add (iMAdaptationRequest);
                }
                if (iMAdaptationRequest.AdaptationRequest != null) {
                        // Argumento OID y no colección.
                        iMAdaptationRequest.AdaptationRequest = (MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.AdaptationRequestEN), iMAdaptationRequest.AdaptationRequest.Id);
                }

                session.Save (iMAdaptationRequest);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAdaptationRequest.Id;
}

public void Modify (IMAdaptationRequestEN iMAdaptationRequest)
{
        try
        {
                SessionInitializeTransaction ();
                IMAdaptationRequestEN iMAdaptationRequestEN = (IMAdaptationRequestEN)session.Load (typeof(IMAdaptationRequestEN), iMAdaptationRequest.Id);

                iMAdaptationRequestEN.Name = iMAdaptationRequest.Name;


                iMAdaptationRequestEN.Type = iMAdaptationRequest.Type;


                iMAdaptationRequestEN.IsOID = iMAdaptationRequest.IsOID;


                iMAdaptationRequestEN.IsWritable = iMAdaptationRequest.IsWritable;


                iMAdaptationRequestEN.Description = iMAdaptationRequest.Description;


                iMAdaptationRequestEN.Value = iMAdaptationRequest.Value;

                session.Update (iMAdaptationRequestEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationRequestCAD.", ex);
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
                IMAdaptationRequestEN iMAdaptationRequestEN = (IMAdaptationRequestEN)session.Load (typeof(IMAdaptationRequestEN), id);
                session.Delete (iMAdaptationRequestEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMAdaptationRequestEN
public IMAdaptationRequestEN ReadOID (int id
                                      )
{
        IMAdaptationRequestEN iMAdaptationRequestEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMAdaptationRequestEN = (IMAdaptationRequestEN)session.Get (typeof(IMAdaptationRequestEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAdaptationRequestEN;
}

public System.Collections.Generic.IList<IMAdaptationRequestEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMAdaptationRequestEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMAdaptationRequestEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMAdaptationRequestEN>();
                else
                        result = session.CreateCriteria (typeof(IMAdaptationRequestEN)).List<IMAdaptationRequestEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
