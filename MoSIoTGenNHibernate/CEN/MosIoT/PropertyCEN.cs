

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
 *      Definition of the class PropertyCEN
 *
 */
public partial class PropertyCEN
{
private IPropertyCAD _IPropertyCAD;

public PropertyCEN()
{
        this._IPropertyCAD = new PropertyCAD ();
}

public PropertyCEN(IPropertyCAD _IPropertyCAD)
{
        this._IPropertyCAD = _IPropertyCAD;
}

public IPropertyCAD get_IPropertyCAD ()
{
        return this._IPropertyCAD;
}

public int New_ (int p_deviceTemplate, string p_name, bool p_isWritable, bool p_isCloudable)
{
        PropertyEN propertyEN = null;
        int oid;

        //Initialized PropertyEN
        propertyEN = new PropertyEN ();

        if (p_deviceTemplate != -1) {
                // El argumento p_deviceTemplate -> Property deviceTemplate es oid = false
                // Lista de oids id
                propertyEN.DeviceTemplate = new MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN ();
                propertyEN.DeviceTemplate.Id = p_deviceTemplate;
        }

        propertyEN.Name = p_name;

        propertyEN.IsWritable = p_isWritable;

        propertyEN.IsCloudable = p_isCloudable;

        //Call to PropertyCAD

        oid = _IPropertyCAD.New_ (propertyEN);
        return oid;
}

public void Modify (int p_Property_OID, string p_name, bool p_isWritable, bool p_isCloudable)
{
        PropertyEN propertyEN = null;

        //Initialized PropertyEN
        propertyEN = new PropertyEN ();
        propertyEN.Id = p_Property_OID;
        propertyEN.Name = p_name;
        propertyEN.IsWritable = p_isWritable;
        propertyEN.IsCloudable = p_isCloudable;
        //Call to PropertyCAD

        _IPropertyCAD.Modify (propertyEN);
}

public void Destroy (int id
                     )
{
        _IPropertyCAD.Destroy (id);
}

public PropertyEN ReadOID (int id
                           )
{
        PropertyEN propertyEN = null;

        propertyEN = _IPropertyCAD.ReadOID (id);
        return propertyEN;
}

public System.Collections.Generic.IList<PropertyEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PropertyEN> list = null;

        list = _IPropertyCAD.ReadAll (first, size);
        return list;
}
}
}
