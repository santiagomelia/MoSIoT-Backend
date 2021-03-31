

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
 *      Definition of the class DeviceTemplateCEN
 *
 */
public partial class DeviceTemplateCEN
{
private IDeviceTemplateCAD _IDeviceTemplateCAD;

public DeviceTemplateCEN()
{
        this._IDeviceTemplateCAD = new DeviceTemplateCAD ();
}

public DeviceTemplateCEN(IDeviceTemplateCAD _IDeviceTemplateCAD)
{
        this._IDeviceTemplateCAD = _IDeviceTemplateCAD;
}

public IDeviceTemplateCAD get_IDeviceTemplateCAD ()
{
        return this._IDeviceTemplateCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum p_type, bool p_isEdge)
{
        DeviceTemplateEN deviceTemplateEN = null;
        int oid;

        //Initialized DeviceTemplateEN
        deviceTemplateEN = new DeviceTemplateEN ();
        deviceTemplateEN.Name = p_name;

        deviceTemplateEN.Type = p_type;

        deviceTemplateEN.IsEdge = p_isEdge;

        //Call to DeviceTemplateCAD

        oid = _IDeviceTemplateCAD.New_ (deviceTemplateEN);
        return oid;
}

public void Modify (int p_DeviceTemplate_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum p_type, bool p_isEdge)
{
        DeviceTemplateEN deviceTemplateEN = null;

        //Initialized DeviceTemplateEN
        deviceTemplateEN = new DeviceTemplateEN ();
        deviceTemplateEN.Id = p_DeviceTemplate_OID;
        deviceTemplateEN.Name = p_name;
        deviceTemplateEN.Type = p_type;
        deviceTemplateEN.IsEdge = p_isEdge;
        //Call to DeviceTemplateCAD

        _IDeviceTemplateCAD.Modify (deviceTemplateEN);
}

public void Destroy (int id
                     )
{
        _IDeviceTemplateCAD.Destroy (id);
}

public DeviceTemplateEN ReadOID (int id
                                 )
{
        DeviceTemplateEN deviceTemplateEN = null;

        deviceTemplateEN = _IDeviceTemplateCAD.ReadOID (id);
        return deviceTemplateEN;
}

public System.Collections.Generic.IList<DeviceTemplateEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DeviceTemplateEN> list = null;

        list = _IDeviceTemplateCAD.ReadAll (first, size);
        return list;
}
}
}
