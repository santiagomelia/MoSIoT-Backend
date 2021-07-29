
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
 * Clase IMCommunication:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class IMCommunicationCAD : BasicCAD, IIMCommunicationCAD
{
public IMCommunicationCAD() : base ()
{
}

public IMCommunicationCAD(ISession sessionAux) : base (sessionAux)
{
}



public IMCommunicationEN ReadOIDDefault (int id
                                         )
{
        IMCommunicationEN iMCommunicationEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMCommunicationEN = (IMCommunicationEN)session.Get (typeof(IMCommunicationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCommunicationEN;
}

public System.Collections.Generic.IList<IMCommunicationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<IMCommunicationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(IMCommunicationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<IMCommunicationEN>();
                        else
                                result = session.CreateCriteria (typeof(IMCommunicationEN)).List<IMCommunicationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (IMCommunicationEN iMCommunication)
{
        try
        {
                SessionInitializeTransaction ();
                IMCommunicationEN iMCommunicationEN = (IMCommunicationEN)session.Load (typeof(IMCommunicationEN), iMCommunication.Id);

                session.Update (iMCommunicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (IMCommunicationEN iMCommunication)
{
        try
        {
                SessionInitializeTransaction ();
                if (iMCommunication.Entity != null) {
                        // Argumento OID y no colección.
                        iMCommunication.Entity = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), iMCommunication.Entity.Id);

                        iMCommunication.Entity.Attributes
                        .Add (iMCommunication);
                }

                session.Save (iMCommunication);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCommunication.Id;
}

public void Modify (IMCommunicationEN iMCommunication)
{
        try
        {
                SessionInitializeTransaction ();
                IMCommunicationEN iMCommunicationEN = (IMCommunicationEN)session.Load (typeof(IMCommunicationEN), iMCommunication.Id);

                iMCommunicationEN.Name = iMCommunication.Name;


                iMCommunicationEN.Description = iMCommunication.Description;

                session.Update (iMCommunicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationCAD.", ex);
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
                IMCommunicationEN iMCommunicationEN = (IMCommunicationEN)session.Load (typeof(IMCommunicationEN), id);
                session.Delete (iMCommunicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: IMCommunicationEN
public IMCommunicationEN ReadOID (int id
                                  )
{
        IMCommunicationEN iMCommunicationEN = null;

        try
        {
                SessionInitializeTransaction ();
                iMCommunicationEN = (IMCommunicationEN)session.Get (typeof(IMCommunicationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return iMCommunicationEN;
}

public System.Collections.Generic.IList<IMCommunicationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMCommunicationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(IMCommunicationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<IMCommunicationEN>();
                else
                        result = session.CreateCriteria (typeof(IMCommunicationEN)).List<IMCommunicationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AssignCommunication (int p_IMCommunication_OID, int p_comunication_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.IMCommunicationEN iMCommunicationEN = null;
        try
        {
                SessionInitializeTransaction ();
                iMCommunicationEN = (IMCommunicationEN)session.Load (typeof(IMCommunicationEN), p_IMCommunication_OID);
                iMCommunicationEN.Comunication = (MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.ComunicationEN), p_comunication_OID);



                session.Update (iMCommunicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in IMCommunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
