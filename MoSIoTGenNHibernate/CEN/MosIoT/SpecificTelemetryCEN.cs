

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
 *      Definition of the class SpecificTelemetryCEN
 *
 */
public partial class SpecificTelemetryCEN
{
private ISpecificTelemetryCAD _ISpecificTelemetryCAD;

public SpecificTelemetryCEN()
{
        this._ISpecificTelemetryCAD = new SpecificTelemetryCAD ();
}

public SpecificTelemetryCEN(ISpecificTelemetryCAD _ISpecificTelemetryCAD)
{
        this._ISpecificTelemetryCAD = _ISpecificTelemetryCAD;
}

public ISpecificTelemetryCAD get_ISpecificTelemetryCAD ()
{
        return this._ISpecificTelemetryCAD;
}

public int New_ (int p_telemetry, string p_name)
{
        SpecificTelemetryEN specificTelemetryEN = null;
        int oid;

        //Initialized SpecificTelemetryEN
        specificTelemetryEN = new SpecificTelemetryEN ();

        if (p_telemetry != -1) {
                // El argumento p_telemetry -> Property telemetry es oid = false
                // Lista de oids id
                specificTelemetryEN.Telemetry = new MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN ();
                specificTelemetryEN.Telemetry.Id = p_telemetry;
        }

        specificTelemetryEN.Name = p_name;

        //Call to SpecificTelemetryCAD

        oid = _ISpecificTelemetryCAD.New_ (specificTelemetryEN);
        return oid;
}

public void Modify (int p_SpecificTelemetry_OID, string p_name)
{
        SpecificTelemetryEN specificTelemetryEN = null;

        //Initialized SpecificTelemetryEN
        specificTelemetryEN = new SpecificTelemetryEN ();
        specificTelemetryEN.Id = p_SpecificTelemetry_OID;
        specificTelemetryEN.Name = p_name;
        //Call to SpecificTelemetryCAD

        _ISpecificTelemetryCAD.Modify (specificTelemetryEN);
}

public void Destroy (int id
                     )
{
        _ISpecificTelemetryCAD.Destroy (id);
}

public SpecificTelemetryEN ReadOID (int id
                                    )
{
        SpecificTelemetryEN specificTelemetryEN = null;

        specificTelemetryEN = _ISpecificTelemetryCAD.ReadOID (id);
        return specificTelemetryEN;
}

public System.Collections.Generic.IList<SpecificTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<SpecificTelemetryEN> list = null;

        list = _ISpecificTelemetryCAD.ReadAll (first, size);
        return list;
}
}
}
