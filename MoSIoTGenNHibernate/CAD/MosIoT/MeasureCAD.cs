
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
 * Clase Measure:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class MeasureCAD : BasicCAD, IMeasureCAD
{
public MeasureCAD() : base ()
{
}

public MeasureCAD(ISession sessionAux) : base (sessionAux)
{
}



public MeasureEN ReadOIDDefault (int id
                                 )
{
        MeasureEN measureEN = null;

        try
        {
                SessionInitializeTransaction ();
                measureEN = (MeasureEN)session.Get (typeof(MeasureEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MeasureCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return measureEN;
}

public System.Collections.Generic.IList<MeasureEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MeasureEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MeasureEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MeasureEN>();
                        else
                                result = session.CreateCriteria (typeof(MeasureEN)).List<MeasureEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MeasureCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MeasureEN measure)
{
        try
        {
                SessionInitializeTransaction ();
                MeasureEN measureEN = (MeasureEN)session.Load (typeof(MeasureEN), measure.Id);

                measureEN.Name = measure.Name;


                measureEN.Description = measure.Description;




                measureEN.LOINCcode = measure.LOINCcode;

                session.Update (measureEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MeasureCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MeasureEN measure)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (measure);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MeasureCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return measure.Id;
}

public void Modify (MeasureEN measure)
{
        try
        {
                SessionInitializeTransaction ();
                MeasureEN measureEN = (MeasureEN)session.Load (typeof(MeasureEN), measure.Id);

                measureEN.Name = measure.Name;


                measureEN.Description = measure.Description;


                measureEN.LOINCcode = measure.LOINCcode;

                session.Update (measureEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MeasureCAD.", ex);
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
                MeasureEN measureEN = (MeasureEN)session.Load (typeof(MeasureEN), id);
                session.Delete (measureEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MeasureCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: MeasureEN
public MeasureEN ReadOID (int id
                          )
{
        MeasureEN measureEN = null;

        try
        {
                SessionInitializeTransaction ();
                measureEN = (MeasureEN)session.Get (typeof(MeasureEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MeasureCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return measureEN;
}

public System.Collections.Generic.IList<MeasureEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MeasureEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(MeasureEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<MeasureEN>();
                else
                        result = session.CreateCriteria (typeof(MeasureEN)).List<MeasureEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in MeasureCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
