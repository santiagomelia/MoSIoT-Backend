
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
 * Clase IMTarget:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMTargetCAD : BasicCAD, IIMTargetCAD
{
public IMTargetCAD() : base ()
{
}

public IMTargetCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMTargetEN ReadOIDDefault (int id
                                  )
{
        IMTargetEN iMTargetEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMTargetEN = (IMTargetEN)session.Get (typeof(IMTargetEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMTargetEN;
}

public System.Collections.Generic.IList<IMTargetEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMTargetEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMTargetEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMTargetEN>();
                        else
                                result = session.CreateCriteria (typeof(IMTargetEN)).List<IMTargetEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTargetCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMTargetEN iMTarget)
{
        try
        {
                SessionInitializeTransaction ();
                IMTargetEN iMTargetEN = (IMTargetEN)session.Load (typeof(IMTargetEN), iMTarget.Id);

                session.Update (iMTargetEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMTargetEN iMTarget)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMTarget.Entity != null) {
                        // Argumento OID y no colección.
                        iMTarget.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMTarget.Entity.Id);

                        iMTarget.Entity.Attributes
                        .Add (iMTarget);
                }
                if (iMTarget.Target != null) {
                        // Argumento OID y no colección.
                        iMTarget.Target = (MoSIoTGenNHibernate.EN.MosIoT.TargetEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.TargetEN), iMTarget.Target.Id);
                }

                session.Save (iMTarget);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMTarget.Id;
}

public void Modify (IMTargetEN iMTarget)
{
        try
        {
                SessionInitializeTransaction ();
                IMTargetEN iMTargetEN = (IMTargetEN)session.Load (typeof(IMTargetEN), iMTarget.Id);

                iMTargetEN.Name = iMTarget.Name;


                iMTargetEN.Type = iMTarget.Type;


                iMTargetEN.IsOID = iMTarget.IsOID;


                iMTargetEN.IsWritable = iMTarget.IsWritable;


                iMTargetEN.Description = iMTarget.Description;


                iMTargetEN.Value = iMTarget.Value;

                session.Update (iMTargetEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTargetCAD.", ex);
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
                IMTargetEN iMTargetEN = (IMTargetEN)session.Load (typeof(IMTargetEN), id);
                session.Delete (iMTargetEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMTargetEN
public IMTargetEN ReadOID (int id
                           )
{
        IMTargetEN iMTargetEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMTargetEN = (IMTargetEN)session.Get (typeof(IMTargetEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMTargetEN;
}

public System.Collections.Generic.IList<IMTargetEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMTargetEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMTargetEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMTargetEN>();
                else
                        result = session.CreateCriteria (typeof(IMTargetEN)).List<IMTargetEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMTargetCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
