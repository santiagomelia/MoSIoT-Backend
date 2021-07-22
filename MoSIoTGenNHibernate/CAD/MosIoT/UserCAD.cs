
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
 * Clase User:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class UserCAD : BasicCAD, IUserCAD
{
public UserCAD() : base ()
{
}

public UserCAD(ISession sessionAux) : base (sessionAux)
{
}



public UserEN ReadOIDDefault (int id
                              )
{
        UserEN userEN = null;

        try
        {
                SessionInitializeTransaction ();
                userEN = (UserEN)session.Get (typeof(UserEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return userEN;
}

public System.Collections.Generic.IList<UserEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UserEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UserEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UserEN>();
                        else
                                result = session.CreateCriteria (typeof(UserEN)).List<UserEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UserEN user)
{
        try
        {
                SessionInitializeTransaction ();
                UserEN userEN = (UserEN)session.Load (typeof(UserEN), user.Id);

                userEN.BirthDate = user.BirthDate;


                userEN.Address = user.Address;


                userEN.Surnames = user.Surnames;


                userEN.Phone = user.Phone;


                userEN.Photo = user.Photo;


                userEN.IsActive = user.IsActive;


                userEN.Type = user.Type;


                userEN.IsDiseased = user.IsDiseased;


                userEN.Pass = user.Pass;


                userEN.Name = user.Name;


                userEN.Description = user.Description;


                userEN.Email = user.Email;





                session.Update (userEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
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
                UserEN userEN = (UserEN)session.Load (typeof(UserEN), id);
                session.Delete (userEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: UserEN
public UserEN ReadOID (int id
                       )
{
        UserEN userEN = null;

        try
        {
                SessionInitializeTransaction ();
                userEN = (UserEN)session.Get (typeof(UserEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return userEN;
}

public System.Collections.Generic.IList<UserEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UserEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UserEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<UserEN>();
                else
                        result = session.CreateCriteria (typeof(UserEN)).List<UserEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public int New_ (UserEN user)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (user);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return user.Id;
}

public void Modify (UserEN user)
{
        try
        {
                SessionInitializeTransaction ();
                UserEN userEN = (UserEN)session.Load (typeof(UserEN), user.Id);

                userEN.Surnames = user.Surnames;


                userEN.IsActive = user.IsActive;


                userEN.Type = user.Type;


                userEN.IsDiseased = user.IsDiseased;


                userEN.Pass = user.Pass;


                userEN.Name = user.Name;


                userEN.Description = user.Description;


                userEN.Email = user.Email;

                session.Update (userEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in UserCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
