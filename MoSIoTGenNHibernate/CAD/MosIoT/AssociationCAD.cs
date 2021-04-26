
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
 * Clase Association:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class AssociationCAD : BasicCAD, IAssociationCAD
{
public AssociationCAD() : base ()
{
}

public AssociationCAD(ISession sessionAux) : base (sessionAux)
{
}



public AssociationEN ReadOIDDefault (int id
                                     )
{
        AssociationEN associationEN = null;

        try
        {
                SessionInitializeTransaction ();
                associationEN = (AssociationEN)session.Get (typeof(AssociationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AssociationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return associationEN;
}

public System.Collections.Generic.IList<AssociationEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AssociationEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AssociationEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AssociationEN>();
                        else
                                result = session.CreateCriteria (typeof(AssociationEN)).List<AssociationEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AssociationCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AssociationEN association)
{
        try
        {
                SessionInitializeTransaction ();
                AssociationEN associationEN = (AssociationEN)session.Load (typeof(AssociationEN), association.Id);

                associationEN.Name = association.Name;




                associationEN.Type = association.Type;


                associationEN.CardinalityOrigin = association.CardinalityOrigin;


                associationEN.CardinalityTarget = association.CardinalityTarget;





                associationEN.Description = association.Description;

                session.Update (associationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AssociationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AssociationEN association)
{
        try
        {
                SessionInitializeTransaction ();
                if (association.RolOrigin != null) {
                        // Argumento OID y no colección.
                        association.RolOrigin = (MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN), association.RolOrigin.Id);

                        association.RolOrigin.OriginAsociation
                        .Add (association);
                }
                if (association.RolTarget != null) {
                        // Argumento OID y no colección.
                        association.RolTarget = (MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN), association.RolTarget.Id);

                        association.RolTarget.TargetAssociation
                        .Add (association);
                }
                if (association.EntityOrigin != null) {
                        // Argumento OID y no colección.
                        association.EntityOrigin = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), association.EntityOrigin.Id);

                        association.EntityOrigin.OriginAssociation
                        .Add (association);
                }
                if (association.EntityTarget != null) {
                        // Argumento OID y no colección.
                        association.EntityTarget = (MoSIoTGenNHibernate.EN.MosIoT.EntityEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.EntityEN), association.EntityTarget.Id);

                        association.EntityTarget.TargetAssociation
                        .Add (association);
                }
                if (association.IoTScenario != null) {
                        // Argumento OID y no colección.
                        association.IoTScenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), association.IoTScenario.Id);

                        association.IoTScenario.Association
                        .Add (association);
                }

                session.Save (association);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AssociationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return association.Id;
}

public void Modify (AssociationEN association)
{
        try
        {
                SessionInitializeTransaction ();
                AssociationEN associationEN = (AssociationEN)session.Load (typeof(AssociationEN), association.Id);

                associationEN.Name = association.Name;


                associationEN.Type = association.Type;


                associationEN.CardinalityOrigin = association.CardinalityOrigin;


                associationEN.CardinalityTarget = association.CardinalityTarget;


                associationEN.Description = association.Description;

                session.Update (associationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AssociationCAD.", ex);
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
                AssociationEN associationEN = (AssociationEN)session.Load (typeof(AssociationEN), id);
                session.Delete (associationEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AssociationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AssociationEN
public AssociationEN ReadOID (int id
                              )
{
        AssociationEN associationEN = null;

        try
        {
                SessionInitializeTransaction ();
                associationEN = (AssociationEN)session.Get (typeof(AssociationEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AssociationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return associationEN;
}

public System.Collections.Generic.IList<AssociationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AssociationEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AssociationEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AssociationEN>();
                else
                        result = session.CreateCriteria (typeof(AssociationEN)).List<AssociationEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in AssociationCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
