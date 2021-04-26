
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
 * Clase AdaptationTypeRequired:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class AdaptationTypeRequiredCAD : BasicCAD, IAdaptationTypeRequiredCAD
{
public AdaptationTypeRequiredCAD() : base ()
{
}

public AdaptationTypeRequiredCAD(ISession sessionAux) : base (sessionAux)
{
}



public AdaptationTypeRequiredEN ReadOIDDefault (int id
                                                )
{
        AdaptationTypeRequiredEN adaptationTypeRequiredEN = null;

        try
        {
                SessionInitializeTransaction ();
                adaptationTypeRequiredEN = (AdaptationTypeRequiredEN)session.Get (typeof(AdaptationTypeRequiredEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationTypeRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adaptationTypeRequiredEN;
}

public System.Collections.Generic.IList<AdaptationTypeRequiredEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AdaptationTypeRequiredEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AdaptationTypeRequiredEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AdaptationTypeRequiredEN>();
                        else
                                result = session.CreateCriteria (typeof(AdaptationTypeRequiredEN)).List<AdaptationTypeRequiredEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationTypeRequiredCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AdaptationTypeRequiredEN adaptationTypeRequired)
{
        try
        {
                SessionInitializeTransaction ();
                AdaptationTypeRequiredEN adaptationTypeRequiredEN = (AdaptationTypeRequiredEN)session.Load (typeof(AdaptationTypeRequiredEN), adaptationTypeRequired.Id);

                adaptationTypeRequiredEN.AdaptionRequest = adaptationTypeRequired.AdaptionRequest;


                adaptationTypeRequiredEN.Description = adaptationTypeRequired.Description;



                session.Update (adaptationTypeRequiredEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationTypeRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AdaptationTypeRequiredEN adaptationTypeRequired)
{
        try
        {
                SessionInitializeTransaction ();
                if (adaptationTypeRequired.AccessMode != null) {
                        // Argumento OID y no colección.
                        adaptationTypeRequired.AccessMode = (MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN), adaptationTypeRequired.AccessMode.Id);

                        adaptationTypeRequired.AccessMode.AdaptationTypeRequired
                        .Add (adaptationTypeRequired);
                }

                session.Save (adaptationTypeRequired);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationTypeRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adaptationTypeRequired.Id;
}

public void Modify (AdaptationTypeRequiredEN adaptationTypeRequired)
{
        try
        {
                SessionInitializeTransaction ();
                AdaptationTypeRequiredEN adaptationTypeRequiredEN = (AdaptationTypeRequiredEN)session.Load (typeof(AdaptationTypeRequiredEN), adaptationTypeRequired.Id);

                adaptationTypeRequiredEN.AdaptionRequest = adaptationTypeRequired.AdaptionRequest;


                adaptationTypeRequiredEN.Description = adaptationTypeRequired.Description;

                session.Update (adaptationTypeRequiredEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationTypeRequiredCAD.", ex);
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
                AdaptationTypeRequiredEN adaptationTypeRequiredEN = (AdaptationTypeRequiredEN)session.Load (typeof(AdaptationTypeRequiredEN), id);
                session.Delete (adaptationTypeRequiredEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationTypeRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AdaptationTypeRequiredEN
public AdaptationTypeRequiredEN ReadOID (int id
                                         )
{
        AdaptationTypeRequiredEN adaptationTypeRequiredEN = null;

        try
        {
                SessionInitializeTransaction ();
                adaptationTypeRequiredEN = (AdaptationTypeRequiredEN)session.Get (typeof(AdaptationTypeRequiredEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationTypeRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return adaptationTypeRequiredEN;
}

public System.Collections.Generic.IList<AdaptationTypeRequiredEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AdaptationTypeRequiredEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AdaptationTypeRequiredEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AdaptationTypeRequiredEN>();
                else
                        result = session.CreateCriteria (typeof(AdaptationTypeRequiredEN)).List<AdaptationTypeRequiredEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AdaptationTypeRequiredCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
