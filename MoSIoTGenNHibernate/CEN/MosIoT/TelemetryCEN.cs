

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
 *      Definition of the class TelemetryCEN
 *
 */
public partial class TelemetryCEN
{
private ITelemetryCAD _ITelemetryCAD;

public TelemetryCEN()
{
        this._ITelemetryCAD = new TelemetryCAD ();
}

public TelemetryCEN(ITelemetryCAD _ITelemetryCAD)
{
        this._ITelemetryCAD = _ITelemetryCAD;
}

public ITelemetryCAD get_ITelemetryCAD ()
{
        return this._ITelemetryCAD;
}

public int New_ (int p_deviceTemplate, double p_frecuency, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_schema, MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum p_unit, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum p_type)
{
        TelemetryEN telemetryEN = null;
        int oid;

        //Initialized TelemetryEN
        telemetryEN = new TelemetryEN ();

        if (p_deviceTemplate != -1) {
                // El argumento p_deviceTemplate -> Property deviceTemplate es oid = false
                // Lista de oids id
                telemetryEN.DeviceTemplate = new MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN ();
                telemetryEN.DeviceTemplate.Id = p_deviceTemplate;
        }

        telemetryEN.Frecuency = p_frecuency;

        telemetryEN.Schema = p_schema;

        telemetryEN.Unit = p_unit;

        telemetryEN.Name = p_name;

        telemetryEN.Type = p_type;

        //Call to TelemetryCAD

        oid = _ITelemetryCAD.New_ (telemetryEN);
        return oid;
}

public void Modify (int p_Telemetry_OID, double p_frecuency, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_schema, MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum p_unit, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum p_type)
{
        TelemetryEN telemetryEN = null;

        //Initialized TelemetryEN
        telemetryEN = new TelemetryEN ();
        telemetryEN.Id = p_Telemetry_OID;
        telemetryEN.Frecuency = p_frecuency;
        telemetryEN.Schema = p_schema;
        telemetryEN.Unit = p_unit;
        telemetryEN.Name = p_name;
        telemetryEN.Type = p_type;
        //Call to TelemetryCAD

        _ITelemetryCAD.Modify (telemetryEN);
}

public void Destroy (int id
                     )
{
        _ITelemetryCAD.Destroy (id);
}

public TelemetryEN ReadOID (int id
                            )
{
        TelemetryEN telemetryEN = null;

        telemetryEN = _ITelemetryCAD.ReadOID (id);
        return telemetryEN;
}

public System.Collections.Generic.IList<TelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TelemetryEN> list = null;

        list = _ITelemetryCAD.ReadAll (first, size);
        return list;
}
public void AsignarSpecific (int p_Telemetry_OID, int p_typeTelemetry_OID)
{
        //Call to TelemetryCAD

        _ITelemetryCAD.AsignarSpecific (p_Telemetry_OID, p_typeTelemetry_OID);
}
}
}
