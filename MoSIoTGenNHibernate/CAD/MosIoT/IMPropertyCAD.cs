
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
 * Clase IMProperty:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMPropertyCAD : BasicCAD, IIMPropertyCAD
{
public IMPropertyCAD() : base ()
{
}

public IMPropertyCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMPropertyEN ReadOIDDefault (int id
                                    )
{
        IMPropertyEN iMPropertyEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMPropertyEN = (IMPropertyEN)session.Get (typeof(IMPropertyEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMPropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMPropertyEN;
}

public System.Collections.Generic.IList<IMPropertyEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMPropertyEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMPropertyEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMPropertyEN>();
                        else
                                result = session.CreateCriteria (typeof(IMPropertyEN)).List<IMPropertyEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMPropertyCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMPropertyEN iMProperty)
{
        try
        {
                SessionInitializeTransaction ();
                IMPropertyEN iMPropertyEN = (IMPropertyEN)session.Load (typeof(IMPropertyEN), iMProperty.Id);

                session.Update (iMPropertyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMPropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMPropertyEN iMProperty)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMProperty.Entity != null) {
                        // Argumento OID y no colección.
                        iMProperty.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMProperty.Entity.Id);

                        iMProperty.Entity.Attributes
                        .Add (iMProperty);
                }
                if (iMProperty.Property != null) {
                        // Argumento OID y no colección.
                        iMProperty.Property = (MoSIoTGenNHibernate.EN.MosIoT.PropertyEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.PropertyEN), iMProperty.Property.Id);
                }

                session.Save (iMProperty);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMPropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMProperty.Id;
}

public void Modify (IMPropertyEN iMProperty)
{
        try
        {
                SessionInitializeTransaction ();
                IMPropertyEN iMPropertyEN = (IMPropertyEN)session.Load (typeof(IMPropertyEN), iMProperty.Id);

                iMPropertyEN.Name = iMProperty.Name;


                iMPropertyEN.Type = iMProperty.Type;


                iMPropertyEN.IsOID = iMProperty.IsOID;


                iMPropertyEN.IsWritable = iMProperty.IsWritable;


                iMPropertyEN.Description = iMProperty.Description;


                iMPropertyEN.Value = iMProperty.Value;

                session.Update (iMPropertyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMPropertyCAD.", ex);
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
                IMPropertyEN iMPropertyEN = (IMPropertyEN)session.Load (typeof(IMPropertyEN), id);
                session.Delete (iMPropertyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMPropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMPropertyEN
public IMPropertyEN ReadOID (int id
                             )
{
        IMPropertyEN iMPropertyEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMPropertyEN = (IMPropertyEN)session.Get (typeof(IMPropertyEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMPropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMPropertyEN;
}

public System.Collections.Generic.IList<IMPropertyEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMPropertyEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMPropertyEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMPropertyEN>();
                else
                        result = session.CreateCriteria (typeof(IMPropertyEN)).List<IMPropertyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMPropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
