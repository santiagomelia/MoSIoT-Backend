
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
 * Clase IMAdaptationDetail:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMAdaptationDetailCAD : BasicCAD, IIMAdaptationDetailCAD
{
public IMAdaptationDetailCAD() : base ()
{
}

public IMAdaptationDetailCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMAdaptationDetailEN ReadOIDDefault (int id
                                            )
{
        IMAdaptationDetailEN iMAdaptationDetailEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMAdaptationDetailEN = (IMAdaptationDetailEN)session.Get (typeof(IMAdaptationDetailEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAdaptationDetailEN;
}

public System.Collections.Generic.IList<IMAdaptationDetailEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMAdaptationDetailEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMAdaptationDetailEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMAdaptationDetailEN>();
                        else
                                result = session.CreateCriteria (typeof(IMAdaptationDetailEN)).List<IMAdaptationDetailEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMAdaptationDetailEN iMAdaptationDetail)
{
        try
        {
                SessionInitializeTransaction ();
                IMAdaptationDetailEN iMAdaptationDetailEN = (IMAdaptationDetailEN)session.Load (typeof(IMAdaptationDetailEN), iMAdaptationDetail.Id);

                session.Update (iMAdaptationDetailEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMAdaptationDetailEN iMAdaptationDetail)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMAdaptationDetail.Entity != null) {
                        // Argumento OID y no colección.
                        iMAdaptationDetail.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMAdaptationDetail.Entity.Id);

                        iMAdaptationDetail.Entity.Attributes
                        .Add (iMAdaptationDetail);
                }

                session.Save (iMAdaptationDetail);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAdaptationDetail.Id;
}

public void Modify (IMAdaptationDetailEN iMAdaptationDetail)
{
        try
        {
                SessionInitializeTransaction ();
                IMAdaptationDetailEN iMAdaptationDetailEN = (IMAdaptationDetailEN)session.Load (typeof(IMAdaptationDetailEN), iMAdaptationDetail.Id);

                iMAdaptationDetailEN.Name = iMAdaptationDetail.Name;


                iMAdaptationDetailEN.Description = iMAdaptationDetail.Description;

                session.Update (iMAdaptationDetailEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailCAD.", ex);
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
                IMAdaptationDetailEN iMAdaptationDetailEN = (IMAdaptationDetailEN)session.Load (typeof(IMAdaptationDetailEN), id);
                session.Delete (iMAdaptationDetailEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMAdaptationDetailEN
public IMAdaptationDetailEN ReadOID (int id
                                     )
{
        IMAdaptationDetailEN iMAdaptationDetailEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMAdaptationDetailEN = (IMAdaptationDetailEN)session.Get (typeof(IMAdaptationDetailEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAdaptationDetailEN;
}

public System.Collections.Generic.IList<IMAdaptationDetailEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMAdaptationDetailEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMAdaptationDetailEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMAdaptationDetailEN>();
                else
                        result = session.CreateCriteria (typeof(IMAdaptationDetailEN)).List<IMAdaptationDetailEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AssignAdaptationD (int p_IMAdaptationDetail_OID, int p_adaptationDetailRequired_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.IMAdaptationDetailEN iMAdaptationDetailEN = null;
        try
        {
                SessionInitializeTransaction ();
                iMAdaptationDetailEN = (IMAdaptationDetailEN)session.Load (typeof(IMAdaptationDetailEN), p_IMAdaptationDetail_OID);
                iMAdaptationDetailEN.AdaptationDetailRequired = (MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.AdaptationDetailRequiredEN), p_adaptationDetailRequired_OID);



                session.Update (iMAdaptationDetailEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationDetailCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
