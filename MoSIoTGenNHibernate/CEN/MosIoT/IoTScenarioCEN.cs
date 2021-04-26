

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
 *      Definition of the class IoTScenarioCEN
 *
 */
public partial class IoTScenarioCEN
{
private IIoTScenarioCAD _IIoTScenarioCAD;

public IoTScenarioCEN()
{
        this._IIoTScenarioCAD = new IoTScenarioCAD ();
}

public IoTScenarioCEN(IIoTScenarioCAD _IIoTScenarioCAD)
{
        this._IIoTScenarioCAD = _IIoTScenarioCAD;
}

public IIoTScenarioCAD get_IIoTScenarioCAD ()
{
        return this._IIoTScenarioCAD;
}

public int New_ (string p_name, string p_description)
{
        IoTScenarioEN ioTScenarioEN = null;
        int oid;

        //Initialized IoTScenarioEN
        ioTScenarioEN = new IoTScenarioEN ();
        ioTScenarioEN.Name = p_name;

        ioTScenarioEN.Description = p_description;

        //Call to IoTScenarioCAD

        oid = _IIoTScenarioCAD.New_ (ioTScenarioEN);
        return oid;
}

public void Modify (int p_IoTScenario_OID, string p_name, string p_description)
{
        IoTScenarioEN ioTScenarioEN = null;

        //Initialized IoTScenarioEN
        ioTScenarioEN = new IoTScenarioEN ();
        ioTScenarioEN.Id = p_IoTScenario_OID;
        ioTScenarioEN.Name = p_name;
        ioTScenarioEN.Description = p_description;
        //Call to IoTScenarioCAD

        _IIoTScenarioCAD.Modify (ioTScenarioEN);
}

public void Destroy (int id
                     )
{
        _IIoTScenarioCAD.Destroy (id);
}

public IoTScenarioEN ReadOID (int id
                              )
{
        IoTScenarioEN ioTScenarioEN = null;

        ioTScenarioEN = _IIoTScenarioCAD.ReadOID (id);
        return ioTScenarioEN;
}

public System.Collections.Generic.IList<IoTScenarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IoTScenarioEN> list = null;

        list = _IIoTScenarioCAD.ReadAll (first, size);
        return list;
}
}
}
