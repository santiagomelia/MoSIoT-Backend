
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
 * Clase DeviceTemplate:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class DeviceTemplateCAD : BasicCAD, IDeviceTemplateCAD
{
public DeviceTemplateCAD() : base ()
{
}

public DeviceTemplateCAD(ISession sessionAux) : base (sessionAux)
{
}



public DeviceTemplateEN ReadOIDDefault (int id
                                        )
{
        DeviceTemplateEN deviceTemplateEN = null;

        try
        {
                SessionInitializeTransaction ();
                deviceTemplateEN = (DeviceTemplateEN)session.Get (typeof(DeviceTemplateEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deviceTemplateEN;
}

public System.Collections.Generic.IList<DeviceTemplateEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DeviceTemplateEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DeviceTemplateEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DeviceTemplateEN>();
                        else
                                result = session.CreateCriteria (typeof(DeviceTemplateEN)).List<DeviceTemplateEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DeviceTemplateEN deviceTemplate)
{
        try
        {
                SessionInitializeTransaction ();
                DeviceTemplateEN deviceTemplateEN = (DeviceTemplateEN)session.Load (typeof(DeviceTemplateEN), deviceTemplate.Id);

                deviceTemplateEN.Name = deviceTemplate.Name;





                deviceTemplateEN.Type = deviceTemplate.Type;


                deviceTemplateEN.IsEdge = deviceTemplate.IsEdge;

                session.Update (deviceTemplateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (DeviceTemplateEN deviceTemplate)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (deviceTemplate);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deviceTemplate.Id;
}

public void Modify (DeviceTemplateEN deviceTemplate)
{
        try
        {
                SessionInitializeTransaction ();
                DeviceTemplateEN deviceTemplateEN = (DeviceTemplateEN)session.Load (typeof(DeviceTemplateEN), deviceTemplate.Id);

                deviceTemplateEN.Name = deviceTemplate.Name;


                deviceTemplateEN.Type = deviceTemplate.Type;


                deviceTemplateEN.IsEdge = deviceTemplate.IsEdge;

                session.Update (deviceTemplateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateCAD.", ex);
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
                DeviceTemplateEN deviceTemplateEN = (DeviceTemplateEN)session.Load (typeof(DeviceTemplateEN), id);
                session.Delete (deviceTemplateEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: DeviceTemplateEN
public DeviceTemplateEN ReadOID (int id
                                 )
{
        DeviceTemplateEN deviceTemplateEN = null;

        try
        {
                SessionInitializeTransaction ();
                deviceTemplateEN = (DeviceTemplateEN)session.Get (typeof(DeviceTemplateEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deviceTemplateEN;
}

public System.Collections.Generic.IList<DeviceTemplateEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DeviceTemplateEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DeviceTemplateEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DeviceTemplateEN>();
                else
                        result = session.CreateCriteria (typeof(DeviceTemplateEN)).List<DeviceTemplateEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceTemplateCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
