
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
 * Clase Device:
 *
 */

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial class DeviceCAD : BasicCAD, IDeviceCAD
{
public DeviceCAD() : base ()
{
}

public DeviceCAD(ISession sessionAux) : base (sessionAux)
{
}



public DeviceEN ReadOIDDefault (int id
                                )
{
        DeviceEN deviceEN = null;

        try
        {
                SessionInitializeTransaction ();
                deviceEN = (DeviceEN)session.Get (typeof(DeviceEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deviceEN;
}

public System.Collections.Generic.IList<DeviceEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DeviceEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DeviceEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DeviceEN>();
                        else
                                result = session.CreateCriteria (typeof(DeviceEN)).List<DeviceEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DeviceEN device)
{
        try
        {
                SessionInitializeTransaction ();
                DeviceEN deviceEN = (DeviceEN)session.Load (typeof(DeviceEN), device.Id);

                deviceEN.DeviceSwitch = device.DeviceSwitch;


                deviceEN.Tag = device.Tag;


                deviceEN.IsSimulated = device.IsSimulated;


                deviceEN.SerialNumber = device.SerialNumber;


                deviceEN.FirmVersion = device.FirmVersion;


                deviceEN.Trademark = device.Trademark;


                session.Update (deviceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (DeviceEN device)
{
        try
        {
                SessionInitializeTransaction ();
                if (device.Scenario != null) {
                        // Argumento OID y no colección.
                        device.Scenario = (MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN), device.Scenario.Id);

                        device.Scenario.Entity
                        .Add (device);
                }

                session.Save (device);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return device.Id;
}

public void Modify (DeviceEN device)
{
        try
        {
                SessionInitializeTransaction ();
                DeviceEN deviceEN = (DeviceEN)session.Load (typeof(DeviceEN), device.Id);

                deviceEN.Name = device.Name;


                deviceEN.Description = device.Description;


                deviceEN.DeviceSwitch = device.DeviceSwitch;


                deviceEN.Tag = device.Tag;


                deviceEN.IsSimulated = device.IsSimulated;


                deviceEN.SerialNumber = device.SerialNumber;


                deviceEN.FirmVersion = device.FirmVersion;


                deviceEN.Trademark = device.Trademark;

                session.Update (deviceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceCAD.", ex);
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
                DeviceEN deviceEN = (DeviceEN)session.Load (typeof(DeviceEN), id);
                session.Delete (deviceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: DeviceEN
public DeviceEN ReadOID (int id
                         )
{
        DeviceEN deviceEN = null;

        try
        {
                SessionInitializeTransaction ();
                deviceEN = (DeviceEN)session.Get (typeof(DeviceEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return deviceEN;
}

public System.Collections.Generic.IList<DeviceEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DeviceEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DeviceEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DeviceEN>();
                else
                        result = session.CreateCriteria (typeof(DeviceEN)).List<DeviceEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AssignDeviceTemplate (int p_Device_OID, int p_deviceTemplate_OID)
{
        MoSIoTGenNHibernate.EN.MosIoT.DeviceEN deviceEN = null;
        try
        {
                SessionInitializeTransaction ();
                deviceEN = (DeviceEN)session.Load (typeof(DeviceEN), p_Device_OID);
                deviceEN.DeviceTemplate = (MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN)session.Load (typeof(MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN), p_deviceTemplate_OID);



                session.Update (deviceEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is MoSIoTGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new MoSIoTGenNHibernate.Exceptions.DataLayerException ("Error in DeviceCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
