
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
 * Clase AdaptationDetailRequired:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class AdaptationDetailRequiredCAD : BasicCAD, IAdaptationDetailRequiredCAD
{
public AdaptationDetailRequiredCAD() : base ()
{
}

public AdaptationDetailRequiredCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdaptationDetailRequiredEN ReadOIDDefault (int id
                                                  )
{
        AdaptationDetailRequiredEN adaptationDetailRequiredEN = null;

        try
        {
                SessionInitializeTransaction ();
                adaptationDetailRequiredEN = (AdaptationDetailRequiredEN)session.Get (typeof(AdaptationDetailRequiredEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationDetailRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adaptationDetailRequiredEN;
}

public System.Collections.Generic.IList<AdaptationDetailRequiredEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AdaptationDetailRequiredEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AdaptationDetailRequiredEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AdaptationDetailRequiredEN>();
                        else
                                result = session.CreateCriteria (typeof(AdaptationDetailRequiredEN)).List<AdaptationDetailRequiredEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationDetailRequiredCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AdaptationDetailRequiredEN adaptationDetailRequired)
{
        try
        {
                SessionInitializeTransaction ();
                AdaptationDetailRequiredEN adaptationDetailRequiredEN = (AdaptationDetailRequiredEN)session.Load (typeof(AdaptationDetailRequiredEN), adaptationDetailRequired.Id);

                adaptationDetailRequiredEN.AdaptationRequest = adaptationDetailRequired.AdaptationRequest;



                adaptationDetailRequiredEN.Description = adaptationDetailRequired.Description;

                session.Update (adaptationDetailRequiredEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationDetailRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AdaptationDetailRequiredEN adaptationDetailRequired)
{
        try
        {
                SessionInitializeTransaction ();
                if (adaptationDetailRequired.AccessMode != null) {
                        // Argumento OID y no colección.
                        adaptationDetailRequired.AccessMode = (MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN), adaptationDetailRequired.AccessMode.Id);

                        adaptationDetailRequired.AccessMode.AdaptationDetailRequired
                        .Add (adaptationDetailRequired);
                }

                session.Save (adaptationDetailRequired);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationDetailRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adaptationDetailRequired.Id;
}

public void Modify (AdaptationDetailRequiredEN adaptationDetailRequired)
{
        try
        {
                SessionInitializeTransaction ();
                AdaptationDetailRequiredEN adaptationDetailRequiredEN = (AdaptationDetailRequiredEN)session.Load (typeof(AdaptationDetailRequiredEN), adaptationDetailRequired.Id);

                adaptationDetailRequiredEN.AdaptationRequest = adaptationDetailRequired.AdaptationRequest;


                adaptationDetailRequiredEN.Description = adaptationDetailRequired.Description;

                session.Update (adaptationDetailRequiredEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationDetailRequiredCAD.", ex);
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
                AdaptationDetailRequiredEN adaptationDetailRequiredEN = (AdaptationDetailRequiredEN)session.Load (typeof(AdaptationDetailRequiredEN), id);
                session.Delete (adaptationDetailRequiredEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationDetailRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AdaptationDetailRequiredEN
public AdaptationDetailRequiredEN ReadOID (int id
                                           )
{
        AdaptationDetailRequiredEN adaptationDetailRequiredEN = null;

        try
        {
                SessionInitializeTransaction ();
                adaptationDetailRequiredEN = (AdaptationDetailRequiredEN)session.Get (typeof(AdaptationDetailRequiredEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationDetailRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adaptationDetailRequiredEN;
}

public System.Collections.Generic.IList<AdaptationDetailRequiredEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdaptationDetailRequiredEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AdaptationDetailRequiredEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AdaptationDetailRequiredEN>();
                else
                        result = session.CreateCriteria (typeof(AdaptationDetailRequiredEN)).List<AdaptationDetailRequiredEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationDetailRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
