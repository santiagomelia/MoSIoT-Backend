
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
 * Clase Trademark:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class TrademarkCAD : BasicCAD, ITrademarkCAD
{
public TrademarkCAD() : base ()
{
}

public TrademarkCAD(ISession sessionAux) : base (sessionAux)
{
}



public TrademarkEN ReadOIDDefault (int id
                                   )
{
        TrademarkEN trademarkEN = null;

        try
        {
                SessionInitializeTransaction ();
                trademarkEN = (TrademarkEN)session.Get (typeof(TrademarkEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TrademarkCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return trademarkEN;
}

public System.Collections.Generic.IList<TrademarkEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<TrademarkEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(TrademarkEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<TrademarkEN>();
                        else
                                result = session.CreateCriteria (typeof(TrademarkEN)).List<TrademarkEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TrademarkCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (TrademarkEN trademark)
{
        try
        {
                SessionInitializeTransaction ();
                TrademarkEN trademarkEN = (TrademarkEN)session.Load (typeof(TrademarkEN), trademark.Id);

                trademarkEN.Name = trademark.Name;


                session.Update (trademarkEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TrademarkCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (TrademarkEN trademark)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (trademark);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TrademarkCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return trademark.Id;
}

public void Modify (TrademarkEN trademark)
{
        try
        {
                SessionInitializeTransaction ();
                TrademarkEN trademarkEN = (TrademarkEN)session.Load (typeof(TrademarkEN), trademark.Id);

                trademarkEN.Name = trademark.Name;

                session.Update (trademarkEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TrademarkCAD.", ex);
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
                TrademarkEN trademarkEN = (TrademarkEN)session.Load (typeof(TrademarkEN), id);
                session.Delete (trademarkEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TrademarkCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: TrademarkEN
public TrademarkEN ReadOID (int id
                            )
{
        TrademarkEN trademarkEN = null;

        try
        {
                SessionInitializeTransaction ();
                trademarkEN = (TrademarkEN)session.Get (typeof(TrademarkEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TrademarkCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return trademarkEN;
}

public System.Collections.Generic.IList<TrademarkEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TrademarkEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(TrademarkEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<TrademarkEN>();
                else
                        result = session.CreateCriteria (typeof(TrademarkEN)).List<TrademarkEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in TrademarkCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
