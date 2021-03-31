
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
 * Clase Comunication:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class ComunicationCAD : BasicCAD, IComunicationCAD
{
public ComunicationCAD() : base ()
{
}

public ComunicationCAD(ISession sessionAux) : base (sessionAux)
{
}



public ComunicationEN ReadOIDDefault (int id
                                      )
{
        ComunicationEN comunicationEN = null;

        try
        {
                SessionInitializeTransaction ();
                comunicationEN = (ComunicationEN)session.Get (typeof(ComunicationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ComunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comunicationEN;
}

public System.Collections.Generic.IList<ComunicationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ComunicationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ComunicationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ComunicationEN>();
                        else
                                result = session.CreateCriteria (typeof(ComunicationEN)).List<ComunicationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ComunicationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ComunicationEN comunication)
{
        try
        {
                SessionInitializeTransaction ();
                ComunicationEN comunicationEN = (ComunicationEN)session.Load (typeof(ComunicationEN), comunication.Id);

                comunicationEN.Severity = comunication.Severity;


                comunicationEN.Message = comunication.Message;


                comunicationEN.SendDate = comunication.SendDate;




                session.Update (comunicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ComunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ComunicationEN comunication)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (comunication);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ComunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return comunication.Id;
}

public void Modify (ComunicationEN comunication)
{
        try
        {
                SessionInitializeTransaction ();
                ComunicationEN comunicationEN = (ComunicationEN)session.Load (typeof(ComunicationEN), comunication.Id);

                comunicationEN.Severity = comunication.Severity;


                comunicationEN.Message = comunication.Message;


                comunicationEN.SendDate = comunication.SendDate;

                session.Update (comunicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ComunicationCAD.", ex);
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
                ComunicationEN comunicationEN = (ComunicationEN)session.Load (typeof(ComunicationEN), id);
                session.Delete (comunicationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in ComunicationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
