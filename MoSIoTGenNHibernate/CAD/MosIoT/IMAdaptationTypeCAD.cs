
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
 * Clase IMAdaptationType:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMAdaptationTypeCAD : BasicCAD, IIMAdaptationTypeCAD
{
public IMAdaptationTypeCAD() : base ()
{
}

public IMAdaptationTypeCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMAdaptationTypeEN ReadOIDDefault (int id
                                          )
{
        IMAdaptationTypeEN iMAdaptationTypeEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMAdaptationTypeEN = (IMAdaptationTypeEN)session.Get (typeof(IMAdaptationTypeEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationTypeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAdaptationTypeEN;
}

public System.Collections.Generic.IList<IMAdaptationTypeEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMAdaptationTypeEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMAdaptationTypeEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMAdaptationTypeEN>();
                        else
                                result = session.CreateCriteria (typeof(IMAdaptationTypeEN)).List<IMAdaptationTypeEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationTypeCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMAdaptationTypeEN iMAdaptationType)
{
        try
        {
                SessionInitializeTransaction ();
                IMAdaptationTypeEN iMAdaptationTypeEN = (IMAdaptationTypeEN)session.Load (typeof(IMAdaptationTypeEN), iMAdaptationType.Id);

                session.Update (iMAdaptationTypeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationTypeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMAdaptationTypeEN iMAdaptationType)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMAdaptationType.Entity != null) {
                        // Argumento OID y no colección.
                        iMAdaptationType.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMAdaptationType.Entity.Id);

                        iMAdaptationType.Entity.Attributes
                        .Add (iMAdaptationType);
                }
                if (iMAdaptationType.AdaptationTypeRequired != null) {
                        // Argumento OID y no colección.
                        iMAdaptationType.AdaptationTypeRequired = (MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.AdaptationTypeRequiredEN), iMAdaptationType.AdaptationTypeRequired.Id);

                        iMAdaptationType.AdaptationTypeRequired.IMAdaptationType
                        .Add (iMAdaptationType);
                }

                session.Save (iMAdaptationType);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationTypeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAdaptationType.Id;
}

public void Modify (IMAdaptationTypeEN iMAdaptationType)
{
        try
        {
                SessionInitializeTransaction ();
                IMAdaptationTypeEN iMAdaptationTypeEN = (IMAdaptationTypeEN)session.Load (typeof(IMAdaptationTypeEN), iMAdaptationType.Id);

                iMAdaptationTypeEN.Name = iMAdaptationType.Name;


                iMAdaptationTypeEN.Type = iMAdaptationType.Type;


                iMAdaptationTypeEN.IsOID = iMAdaptationType.IsOID;


                iMAdaptationTypeEN.IsWritable = iMAdaptationType.IsWritable;


                iMAdaptationTypeEN.Description = iMAdaptationType.Description;


                iMAdaptationTypeEN.Value = iMAdaptationType.Value;

                session.Update (iMAdaptationTypeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationTypeCAD.", ex);
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
                IMAdaptationTypeEN iMAdaptationTypeEN = (IMAdaptationTypeEN)session.Load (typeof(IMAdaptationTypeEN), id);
                session.Delete (iMAdaptationTypeEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationTypeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMAdaptationTypeEN
public IMAdaptationTypeEN ReadOID (int id
                                   )
{
        IMAdaptationTypeEN iMAdaptationTypeEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMAdaptationTypeEN = (IMAdaptationTypeEN)session.Get (typeof(IMAdaptationTypeEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationTypeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMAdaptationTypeEN;
}

public System.Collections.Generic.IList<IMAdaptationTypeEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMAdaptationTypeEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMAdaptationTypeEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMAdaptationTypeEN>();
                else
                        result = session.CreateCriteria (typeof(IMAdaptationTypeEN)).List<IMAdaptationTypeEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMAdaptationTypeCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
