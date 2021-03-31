

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
 *      Definition of the class StateDeviceCEN
 *
 */
public partial class StateDeviceCEN
{
private IStateDeviceCAD _IStateDeviceCAD;

public StateDeviceCEN()
{
        this._IStateDeviceCAD = new StateDeviceCAD ();
}

public StateDeviceCEN(IStateDeviceCAD _IStateDeviceCAD)
{
        this._IStateDeviceCAD = _IStateDeviceCAD;
}

public IStateDeviceCAD get_IStateDeviceCAD ()
{
        return this._IStateDeviceCAD;
}

public int New_ (string p_name, string p_value, int p_stateTelemetry)
{
        StateDeviceEN stateDeviceEN = null;
        int oid;

        //Initialized StateDeviceEN
        stateDeviceEN = new StateDeviceEN ();
        stateDeviceEN.Name = p_name;

        stateDeviceEN.Value = p_value;


        if (p_stateTelemetry != -1) {
                // El argumento p_stateTelemetry -> Property stateTelemetry es oid = false
                // Lista de oids id
                stateDeviceEN.StateTelemetry = new MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN ();
                stateDeviceEN.StateTelemetry.Id = p_stateTelemetry;
        }

        //Call to StateDeviceCAD

        oid = _IStateDeviceCAD.New_ (stateDeviceEN);
        return oid;
}

public void Modify (int p_StateDevice_OID, string p_name, string p_value)
{
        StateDeviceEN stateDeviceEN = null;

        //Initialized StateDeviceEN
        stateDeviceEN = new StateDeviceEN ();
        stateDeviceEN.Id = p_StateDevice_OID;
        stateDeviceEN.Name = p_name;
        stateDeviceEN.Value = p_value;
        //Call to StateDeviceCAD

        _IStateDeviceCAD.Modify (stateDeviceEN);
}

public void Destroy (int id
                     )
{
        _IStateDeviceCAD.Destroy (id);
}

public StateDeviceEN ReadOID (int id
                              )
{
        StateDeviceEN stateDeviceEN = null;

        stateDeviceEN = _IStateDeviceCAD.ReadOID (id);
        return stateDeviceEN;
}

public System.Collections.Generic.IList<StateDeviceEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<StateDeviceEN> list = null;

        list = _IStateDeviceCAD.ReadAll (first, size);
        return list;
}
}
}
