
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
 * Clase Register:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class RegisterCAD : BasicCAD, IRegisterCAD
{
public RegisterCAD() : base ()
{
}

public RegisterCAD(ISession sessionAux) : base (sessionAux)
{
}



public RegisterEN ReadOIDDefault (int id
                                  )
{
        RegisterEN registerEN = null;

        try
        {
                SessionInitializeTransaction ();
                registerEN = (RegisterEN)session.Get (typeof(RegisterEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RegisterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return registerEN;
}

public System.Collections.Generic.IList<RegisterEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RegisterEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RegisterEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RegisterEN>();
                        else
                                result = session.CreateCriteria (typeof(RegisterEN)).List<RegisterEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RegisterCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RegisterEN register)
{
        try
        {
                SessionInitializeTransaction ();
                RegisterEN registerEN = (RegisterEN)session.Load (typeof(RegisterEN), register.Id);

                session.Update (registerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RegisterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RegisterEN register)
{
        try
        {
                SessionInitializeTransaction ();
                if (register.Entity != null) {
                        // Argumento OID y no colección.
                        register.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), register.Entity.Id);

                        register.Entity.Operations
                        .Add (register);
                }
                if (register.EntityAttributes != null) {
                        // Argumento OID y no colección.
                        register.EntityAttributes = (MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN), register.EntityAttributes.Id);

                        register.EntityAttributes.Register
                        .Add (register);
                }

                session.Save (register);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RegisterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return register.Id;
}

public void Modify (RegisterEN register)
{
        try
        {
                SessionInitializeTransaction ();
                RegisterEN registerEN = (RegisterEN)session.Load (typeof(RegisterEN), register.Id);

                registerEN.Name = register.Name;


                registerEN.Type = register.Type;


                registerEN.ServiceType = register.ServiceType;


                registerEN.Description = register.Description;

                session.Update (registerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RegisterCAD.", ex);
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
                RegisterEN registerEN = (RegisterEN)session.Load (typeof(RegisterEN), id);
                session.Delete (registerEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RegisterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RegisterEN
public RegisterEN ReadOID (int id
                           )
{
        RegisterEN registerEN = null;

        try
        {
                SessionInitializeTransaction ();
                registerEN = (RegisterEN)session.Get (typeof(RegisterEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RegisterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return registerEN;
}

public System.Collections.Generic.IList<RegisterEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RegisterEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RegisterEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RegisterEN>();
                else
                        result = session.CreateCriteria (typeof(RegisterEN)).List<RegisterEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RegisterCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
