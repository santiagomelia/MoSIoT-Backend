

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;

using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


namespace MoSIoTGenNHibernate.CEN.MosIoT
{
/*
 *      Definition of the class DeviceCEN
 *
 */
public partial class DeviceCEN
{
private IDeviceCAD _IDeviceCAD;

public DeviceCEN()
{
        this._IDeviceCAD = new DeviceCAD ();
}

public DeviceCEN(IDeviceCAD _IDeviceCAD)
{
        this._IDeviceCAD = _IDeviceCAD;
}

public IDeviceCAD get_IDeviceCAD ()
{
        return this._IDeviceCAD;
}

public int New_ (string p_name, int p_scenario, string p_description, bool p_deviceSwitch, string p_tag, bool p_isSimulated, string p_serialNumber, string p_firmVersion, string p_trademark, int p_deviceTemplate)
{
        DeviceEN deviceEN = null;
        int oid;

        //Initialized DeviceEN
        deviceEN = new DeviceEN ();
        deviceEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                deviceEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                deviceEN.Scenario.Id = p_scenario;
        }

        deviceEN.Description = p_description;

        deviceEN.DeviceSwitch = p_deviceSwitch;

        deviceEN.Tag = p_tag;

        deviceEN.IsSimulated = p_isSimulated;

        deviceEN.SerialNumber = p_serialNumber;

        deviceEN.FirmVersion = p_firmVersion;

        deviceEN.Trademark = p_trademark;


        if (p_deviceTemplate != -1) {
                // El argumento p_deviceTemplate -> Property deviceTemplate es oid = false
                // Lista de oids id
                deviceEN.DeviceTemplate = new MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN ();
                deviceEN.DeviceTemplate.Id = p_deviceTemplate;
        }

        //Call to DeviceCAD

        oid = _IDeviceCAD.New_ (deviceEN);
        return oid;
}

public void Modify (int p_Device_OID, string p_name, string p_description, bool p_deviceSwitch, string p_tag, bool p_isSimulated, string p_serialNumber, string p_firmVersion, string p_trademark)
{
        DeviceEN deviceEN = null;

        //Initialized DeviceEN
        deviceEN = new DeviceEN ();
        deviceEN.Id = p_Device_OID;
        deviceEN.Name = p_name;
        deviceEN.Description = p_description;
        deviceEN.DeviceSwitch = p_deviceSwitch;
        deviceEN.Tag = p_tag;
        deviceEN.IsSimulated = p_isSimulated;
        deviceEN.SerialNumber = p_serialNumber;
        deviceEN.FirmVersion = p_firmVersion;
        deviceEN.Trademark = p_trademark;
        //Call to DeviceCAD

        _IDeviceCAD.Modify (deviceEN);
}

public void Destroy (int id
                     )
{
        _IDeviceCAD.Destroy (id);
}

public DeviceEN ReadOID (int id
                         )
{
        DeviceEN deviceEN = null;

        deviceEN = _IDeviceCAD.ReadOID (id);
        return deviceEN;
}

public System.Collections.Generic.IList<DeviceEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DeviceEN> list = null;

        list = _IDeviceCAD.ReadAll (first, size);
        return list;
}
}
}
