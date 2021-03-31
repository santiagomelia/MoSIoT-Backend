
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
 * Clase AdaptationRequest:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class AdaptationRequestCAD : BasicCAD, IAdaptationRequestCAD
{
public AdaptationRequestCAD() : base ()
{
}

public AdaptationRequestCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdaptationRequestEN ReadOIDDefault (int id
                                           )
{
        AdaptationRequestEN adaptationRequestEN = null;

        try
        {
                SessionInitializeTransaction ();
                adaptationRequestEN = (AdaptationRequestEN)session.Get (typeof(AdaptationRequestEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adaptationRequestEN;
}

public System.Collections.Generic.IList<AdaptationRequestEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AdaptationRequestEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AdaptationRequestEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AdaptationRequestEN>();
                        else
                                result = session.CreateCriteria (typeof(AdaptationRequestEN)).List<AdaptationRequestEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationRequestCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AdaptationRequestEN adaptationRequest)
{
        try
        {
                SessionInitializeTransaction ();
                AdaptationRequestEN adaptationRequestEN = (AdaptationRequestEN)session.Load (typeof(AdaptationRequestEN), adaptationRequest.Id);

                adaptationRequestEN.AccessModeTarget = adaptationRequest.AccessModeTarget;



                adaptationRequestEN.LanguageOfAdaptation = adaptationRequest.LanguageOfAdaptation;


                adaptationRequestEN.Description = adaptationRequest.Description;

                session.Update (adaptationRequestEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AdaptationRequestEN adaptationRequest)
{
        try
        {
                SessionInitializeTransaction ();
                if (adaptationRequest.AccessMode != null) {
                        // Argumento OID y no colección.
                        adaptationRequest.AccessMode = (MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN), adaptationRequest.AccessMode.Id);

                        adaptationRequest.AccessMode.AdaptationRequest
                        .Add (adaptationRequest);
                }

                session.Save (adaptationRequest);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adaptationRequest.Id;
}

public void Modify (AdaptationRequestEN adaptationRequest)
{
        try
        {
                SessionInitializeTransaction ();
                AdaptationRequestEN adaptationRequestEN = (AdaptationRequestEN)session.Load (typeof(AdaptationRequestEN), adaptationRequest.Id);

                adaptationRequestEN.AccessModeTarget = adaptationRequest.AccessModeTarget;


                adaptationRequestEN.LanguageOfAdaptation = adaptationRequest.LanguageOfAdaptation;


                adaptationRequestEN.Description = adaptationRequest.Description;

                session.Update (adaptationRequestEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationRequestCAD.", ex);
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
                AdaptationRequestEN adaptationRequestEN = (AdaptationRequestEN)session.Load (typeof(AdaptationRequestEN), id);
                session.Delete (adaptationRequestEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AdaptationRequestEN
public AdaptationRequestEN ReadOID (int id
                                    )
{
        AdaptationRequestEN adaptationRequestEN = null;

        try
        {
                SessionInitializeTransaction ();
                adaptationRequestEN = (AdaptationRequestEN)session.Get (typeof(AdaptationRequestEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adaptationRequestEN;
}

public System.Collections.Generic.IList<AdaptationRequestEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdaptationRequestEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AdaptationRequestEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AdaptationRequestEN>();
                else
                        result = session.CreateCriteria (typeof(AdaptationRequestEN)).List<AdaptationRequestEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationRequestCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
