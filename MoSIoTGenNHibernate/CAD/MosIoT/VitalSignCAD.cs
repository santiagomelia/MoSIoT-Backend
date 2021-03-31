
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
 * Clase VitalSign:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class VitalSignCAD : BasicCAD, IVitalSignCAD
{
public VitalSignCAD() : base ()
{
}

public VitalSignCAD(ISession sessionAux) : base (sessionAux)
{
}



public VitalSignEN ReadOIDDefault (int id
                                   )
{
        VitalSignEN vitalSignEN = null;

        try
        {
                SessionInitializeTransaction ();
                vitalSignEN = (VitalSignEN)session.Get (typeof(VitalSignEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in VitalSignCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vitalSignEN;
}

public System.Collections.Generic.IList<VitalSignEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<VitalSignEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(VitalSignEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<VitalSignEN>();
                        else
                                result = session.CreateCriteria (typeof(VitalSignEN)).List<VitalSignEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in VitalSignCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (VitalSignEN vitalSign)
{
        try
        {
                SessionInitializeTransaction ();
                VitalSignEN vitalSignEN = (VitalSignEN)session.Load (typeof(VitalSignEN), vitalSign.Id);

                session.Update (vitalSignEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in VitalSignCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (VitalSignEN vitalSign)
{
        try
        {
                SessionInitializeTransaction ();
                if (vitalSign.Scenario != null) {
                        // Argumento OID y no colección.
                        vitalSign.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), vitalSign.Scenario.Id);

                        vitalSign.Scenario.Entity
                        .Add (vitalSign);
                }
                if (vitalSign.Measure != null) {
                        // Argumento OID y no colección.
                        vitalSign.Measure = (MoSIoTGenNHibernate.EN.MosIoT.MeasureEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.MeasureEN), vitalSign.Measure.Id);
                }

                session.Save (vitalSign);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in VitalSignCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vitalSign.Id;
}

public void Modify (VitalSignEN vitalSign)
{
        try
        {
                SessionInitializeTransaction ();
                VitalSignEN vitalSignEN = (VitalSignEN)session.Load (typeof(VitalSignEN), vitalSign.Id);

                vitalSignEN.Name = vitalSign.Name;


                vitalSignEN.Description = vitalSign.Description;

                session.Update (vitalSignEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in VitalSignCAD.", ex);
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
                VitalSignEN vitalSignEN = (VitalSignEN)session.Load (typeof(VitalSignEN), id);
                session.Delete (vitalSignEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in VitalSignCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: VitalSignEN
public VitalSignEN ReadOID (int id
                            )
{
        VitalSignEN vitalSignEN = null;

        try
        {
                SessionInitializeTransaction ();
                vitalSignEN = (VitalSignEN)session.Get (typeof(VitalSignEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in VitalSignCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return vitalSignEN;
}

public System.Collections.Generic.IList<VitalSignEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<VitalSignEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(VitalSignEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<VitalSignEN>();
                else
                        result = session.CreateCriteria (typeof(VitalSignEN)).List<VitalSignEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in VitalSignCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
