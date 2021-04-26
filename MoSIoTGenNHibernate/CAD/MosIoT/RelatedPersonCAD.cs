
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
 * Clase RelatedPerson:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class RelatedPersonCAD : BasicCAD, IRelatedPersonCAD
{
public RelatedPersonCAD() : base ()
{
}

public RelatedPersonCAD(ISession sessionAux) : base (sessionAux)
{
}



public RelatedPersonEN ReadOIDDefault (int id
                                       )
{
        RelatedPersonEN relatedPersonEN = null;

        try
        {
                SessionInitializeTransaction ();
                relatedPersonEN = (RelatedPersonEN)session.Get (typeof(RelatedPersonEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return relatedPersonEN;
}

public System.Collections.Generic.IList<RelatedPersonEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<RelatedPersonEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(RelatedPersonEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<RelatedPersonEN>();
                        else
                                result = session.CreateCriteria (typeof(RelatedPersonEN)).List<RelatedPersonEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (RelatedPersonEN relatedPerson)
{
        try
        {
                SessionInitializeTransaction ();
                RelatedPersonEN relatedPersonEN = (RelatedPersonEN)session.Load (typeof(RelatedPersonEN), relatedPerson.Id);

                session.Update (relatedPersonEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (RelatedPersonEN relatedPerson)
{
        try
        {
                SessionInitializeTransaction ();
                if (relatedPerson.Scenario != null) {
                        // Argumento OID y no colección.
                        relatedPerson.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), relatedPerson.Scenario.Id);

                        relatedPerson.Scenario.Entity
                        .Add (relatedPerson);
                }
                if (relatedPerson.UserRelatedPerson != null) {
                        // Argumento OID y no colección.
                        relatedPerson.UserRelatedPerson = (MoSIoTGenNHibernate.EN.MosIoT.UserEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.UserEN), relatedPerson.UserRelatedPerson.Id);

                        relatedPerson.UserRelatedPerson.RelatedPerson
                        .Add (relatedPerson);
                }

                session.Save (relatedPerson);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return relatedPerson.Id;
}

public void Modify (RelatedPersonEN relatedPerson)
{
        try
        {
                SessionInitializeTransaction ();
                RelatedPersonEN relatedPersonEN = (RelatedPersonEN)session.Load (typeof(RelatedPersonEN), relatedPerson.Id);

                relatedPersonEN.Name = relatedPerson.Name;


                relatedPersonEN.Description = relatedPerson.Description;

                session.Update (relatedPersonEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
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
                RelatedPersonEN relatedPersonEN = (RelatedPersonEN)session.Load (typeof(RelatedPersonEN), id);
                session.Delete (relatedPersonEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: RelatedPersonEN
public RelatedPersonEN ReadOID (int id
                                )
{
        RelatedPersonEN relatedPersonEN = null;

        try
        {
                SessionInitializeTransaction ();
                relatedPersonEN = (RelatedPersonEN)session.Get (typeof(RelatedPersonEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return relatedPersonEN;
}

public System.Collections.Generic.IList<RelatedPersonEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RelatedPersonEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(RelatedPersonEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<RelatedPersonEN>();
                else
                        result = session.CreateCriteria (typeof(RelatedPersonEN)).List<RelatedPersonEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in RelatedPersonCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
