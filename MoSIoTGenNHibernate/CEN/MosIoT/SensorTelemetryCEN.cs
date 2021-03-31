

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
 *      Definition of the class SensorTelemetryCEN
 *
 */
public partial class SensorTelemetryCEN
{
private ISensorTelemetryCAD _ISensorTelemetryCAD;

public SensorTelemetryCEN()
{
        this._ISensorTelemetryCAD = new SensorTelemetryCAD ();
}

public SensorTelemetryCEN(ISensorTelemetryCAD _ISensorTelemetryCAD)
{
        this._ISensorTelemetryCAD = _ISensorTelemetryCAD;
}

public ISensorTelemetryCAD get_ISensorTelemetryCAD ()
{
        return this._ISensorTelemetryCAD;
}

public int New_ (int p_telemetry, string p_name, string p_sensorType)
{
        SensorTelemetryEN sensorTelemetryEN = null;
        int oid;

        //Initialized SensorTelemetryEN
        sensorTelemetryEN = new SensorTelemetryEN ();

        if (p_telemetry != -1) {
                // El argumento p_telemetry -> Property telemetry es oid = false
                // Lista de oids id
                sensorTelemetryEN.Telemetry = new MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN ();
                sensorTelemetryEN.Telemetry.Id = p_telemetry;
        }

        sensorTelemetryEN.Name = p_name;

        sensorTelemetryEN.SensorType = p_sensorType;

        //Call to SensorTelemetryCAD

        oid = _ISensorTelemetryCAD.New_ (sensorTelemetryEN);
        return oid;
}

public void Modify (int p_SensorTelemetry_OID, string p_name, string p_sensorType)
{
        SensorTelemetryEN sensorTelemetryEN = null;

        //Initialized SensorTelemetryEN
        sensorTelemetryEN = new SensorTelemetryEN ();
        sensorTelemetryEN.Id = p_SensorTelemetry_OID;
        sensorTelemetryEN.Name = p_name;
        sensorTelemetryEN.SensorType = p_sensorType;
        //Call to SensorTelemetryCAD

        _ISensorTelemetryCAD.Modify (sensorTelemetryEN);
}

public void Destroy (int id
                     )
{
        _ISensorTelemetryCAD.Destroy (id);
}

public SensorTelemetryEN ReadOID (int id
                                  )
{
        SensorTelemetryEN sensorTelemetryEN = null;

        sensorTelemetryEN = _ISensorTelemetryCAD.ReadOID (id);
        return sensorTelemetryEN;
}

public System.Collections.Generic.IList<SensorTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SensorTelemetryEN> list = null;

        list = _ISensorTelemetryCAD.ReadAll (first, size);
        return list;
}
}
}
