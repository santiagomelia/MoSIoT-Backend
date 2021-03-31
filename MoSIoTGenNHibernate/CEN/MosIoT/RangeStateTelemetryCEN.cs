

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
 *      Definition of the class RangeStateTelemetryCEN
 *
 */
public partial class RangeStateTelemetryCEN
{
private IRangeStateTelemetryCAD _IRangeStateTelemetryCAD;

public RangeStateTelemetryCEN()
{
        this._IRangeStateTelemetryCAD = new RangeStateTelemetryCAD ();
}

public RangeStateTelemetryCEN(IRangeStateTelemetryCAD _IRangeStateTelemetryCAD)
{
        this._IRangeStateTelemetryCAD = _IRangeStateTelemetryCAD;
}

public IRangeStateTelemetryCAD get_IRangeStateTelemetryCAD ()
{
        return this._IRangeStateTelemetryCAD;
}

public int New_ (string p_name, string p_value)
{
        RangeStateTelemetryEN rangeStateTelemetryEN = null;
        int oid;

        //Initialized RangeStateTelemetryEN
        rangeStateTelemetryEN = new RangeStateTelemetryEN ();
        rangeStateTelemetryEN.Name = p_name;

        rangeStateTelemetryEN.Value = p_value;

        //Call to RangeStateTelemetryCAD

        oid = _IRangeStateTelemetryCAD.New_ (rangeStateTelemetryEN);
        return oid;
}

public void Modify (int p_RangeStateTelemetry_OID, string p_name, string p_value)
{
        RangeStateTelemetryEN rangeStateTelemetryEN = null;

        //Initialized RangeStateTelemetryEN
        rangeStateTelemetryEN = new RangeStateTelemetryEN ();
        rangeStateTelemetryEN.Id = p_RangeStateTelemetry_OID;
        rangeStateTelemetryEN.Name = p_name;
        rangeStateTelemetryEN.Value = p_value;
        //Call to RangeStateTelemetryCAD

        _IRangeStateTelemetryCAD.Modify (rangeStateTelemetryEN);
}

public void Destroy (int id
                     )
{
        _IRangeStateTelemetryCAD.Destroy (id);
}

public RangeStateTelemetryEN ReadOID (int id
                                      )
{
        RangeStateTelemetryEN rangeStateTelemetryEN = null;

        rangeStateTelemetryEN = _IRangeStateTelemetryCAD.ReadOID (id);
        return rangeStateTelemetryEN;
}

public System.Collections.Generic.IList<RangeStateTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RangeStateTelemetryEN> list = null;

        list = _IRangeStateTelemetryCAD.ReadAll (first, size);
        return list;
}
}
}
