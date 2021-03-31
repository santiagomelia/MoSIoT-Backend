
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
 * Clase Property:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class PropertyCAD : BasicCAD, IPropertyCAD
{
public PropertyCAD() : base ()
{
}

public PropertyCAD(ISession sessionAux) : base (sessionAux)
{
}



public PropertyEN ReadOIDDefault (int id
                                  )
{
        PropertyEN propertyEN = null;

        try
        {
                SessionInitializeTransaction ();
                propertyEN = (PropertyEN)session.Get (typeof(PropertyEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return propertyEN;
}

public System.Collections.Generic.IList<PropertyEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PropertyEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PropertyEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PropertyEN>();
                        else
                                result = session.CreateCriteria (typeof(PropertyEN)).List<PropertyEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PropertyCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PropertyEN property)
{
        try
        {
                SessionInitializeTransaction ();
                PropertyEN propertyEN = (PropertyEN)session.Load (typeof(PropertyEN), property.Id);


                propertyEN.Name = property.Name;


                propertyEN.IsWritable = property.IsWritable;


                propertyEN.IsCloudable = property.IsCloudable;


                session.Update (propertyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PropertyEN property)
{
        try
        {
                SessionInitializeTransaction ();
                if (property.DeviceTemplate != null) {
                        // Argumento OID y no colección.
                        property.DeviceTemplate = (MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN), property.DeviceTemplate.Id);

                        property.DeviceTemplate.Property
                        .Add (property);
                }

                session.Save (property);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return property.Id;
}

public void Modify (PropertyEN property)
{
        try
        {
                SessionInitializeTransaction ();
                PropertyEN propertyEN = (PropertyEN)session.Load (typeof(PropertyEN), property.Id);

                propertyEN.Name = property.Name;


                propertyEN.IsWritable = property.IsWritable;


                propertyEN.IsCloudable = property.IsCloudable;

                session.Update (propertyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PropertyCAD.", ex);
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
                PropertyEN propertyEN = (PropertyEN)session.Load (typeof(PropertyEN), id);
                session.Delete (propertyEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PropertyEN
public PropertyEN ReadOID (int id
                           )
{
        PropertyEN propertyEN = null;

        try
        {
                SessionInitializeTransaction ();
                propertyEN = (PropertyEN)session.Get (typeof(PropertyEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return propertyEN;
}

public System.Collections.Generic.IList<PropertyEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PropertyEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PropertyEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PropertyEN>();
                else
                        result = session.CreateCriteria (typeof(PropertyEN)).List<PropertyEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in PropertyCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
