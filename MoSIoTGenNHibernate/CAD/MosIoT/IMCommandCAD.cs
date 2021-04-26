
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
 * Clase IMCommand:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMCommandCAD : BasicCAD, IIMCommandCAD
{
public IMCommandCAD() : base ()
{
}

public IMCommandCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMCommandEN ReadOIDDefault (int id
                                   )
{
        IMCommandEN iMCommandEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMCommandEN = (IMCommandEN)session.Get (typeof(IMCommandEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCommandEN;
}

public System.Collections.Generic.IList<IMCommandEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMCommandEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMCommandEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMCommandEN>();
                        else
                                result = session.CreateCriteria (typeof(IMCommandEN)).List<IMCommandEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommandCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMCommandEN iMCommand)
{
        try
        {
                SessionInitializeTransaction ();
                IMCommandEN iMCommandEN = (IMCommandEN)session.Load (typeof(IMCommandEN), iMCommand.Id);

                session.Update (iMCommandEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMCommandEN iMCommand)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMCommand.Entity != null) {
                        // Argumento OID y no colección.
                        iMCommand.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMCommand.Entity.Id);

                        iMCommand.Entity.Operations
                        .Add (iMCommand);
                }
                if (iMCommand.Command != null) {
                        // Argumento OID y no colección.
                        iMCommand.Command = (MoSIoTGenNHibernate.EN.MosIoT.CommandEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.CommandEN), iMCommand.Command.Id);
                }

                session.Save (iMCommand);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCommand.Id;
}

public void Modify (IMCommandEN iMCommand)
{
        try
        {
                SessionInitializeTransaction ();
                IMCommandEN iMCommandEN = (IMCommandEN)session.Load (typeof(IMCommandEN), iMCommand.Id);

                iMCommandEN.Name = iMCommand.Name;


                iMCommandEN.Type = iMCommand.Type;


                iMCommandEN.ServiceType = iMCommand.ServiceType;


                iMCommandEN.Description = iMCommand.Description;

                session.Update (iMCommandEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommandCAD.", ex);
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
                IMCommandEN iMCommandEN = (IMCommandEN)session.Load (typeof(IMCommandEN), id);
                session.Delete (iMCommandEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMCommandEN
public IMCommandEN ReadOID (int id
                            )
{
        IMCommandEN iMCommandEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMCommandEN = (IMCommandEN)session.Get (typeof(IMCommandEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCommandEN;
}

public System.Collections.Generic.IList<IMCommandEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMCommandEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMCommandEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMCommandEN>();
                else
                        result = session.CreateCriteria (typeof(IMCommandEN)).List<IMCommandEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommandCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
