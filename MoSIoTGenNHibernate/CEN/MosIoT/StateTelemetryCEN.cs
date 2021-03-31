

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
 *      Definition of the class StateTelemetryCEN
 *
 */
public partial class StateTelemetryCEN
{
private IStateTelemetryCAD _IStateTelemetryCAD;

public StateTelemetryCEN()
{
        this._IStateTelemetryCAD = new StateTelemetryCAD ();
}

public StateTelemetryCEN(IStateTelemetryCAD _IStateTelemetryCAD)
{
        this._IStateTelemetryCAD = _IStateTelemetryCAD;
}

public IStateTelemetryCAD get_IStateTelemetryCAD ()
{
        return this._IStateTelemetryCAD;
}

public int New_ (int p_telemetry, string p_name)
{
        StateTelemetryEN stateTelemetryEN = null;
        int oid;

        //Initialized StateTelemetryEN
        stateTelemetryEN = new StateTelemetryEN ();

        if (p_telemetry != -1) {
                // El argumento p_telemetry -> Property telemetry es oid = false
                // Lista de oids id
                stateTelemetryEN.Telemetry = new MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN ();
                stateTelemetryEN.Telemetry.Id = p_telemetry;
        }

        stateTelemetryEN.Name = p_name;

        //Call to StateTelemetryCAD

        oid = _IStateTelemetryCAD.New_ (stateTelemetryEN);
        return oid;
}

public void Modify (int p_StateTelemetry_OID, string p_name)
{
        StateTelemetryEN stateTelemetryEN = null;

        //Initialized StateTelemetryEN
        stateTelemetryEN = new StateTelemetryEN ();
        stateTelemetryEN.Id = p_StateTelemetry_OID;
        stateTelemetryEN.Name = p_name;
        //Call to StateTelemetryCAD

        _IStateTelemetryCAD.Modify (stateTelemetryEN);
}

public void Destroy (int id
                     )
{
        _IStateTelemetryCAD.Destroy (id);
}

public StateTelemetryEN ReadOID (int id
                                 )
{
        StateTelemetryEN stateTelemetryEN = null;

        stateTelemetryEN = _IStateTelemetryCAD.ReadOID (id);
        return stateTelemetryEN;
}

public System.Collections.Generic.IList<StateTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<StateTelemetryEN> list = null;

        list = _IStateTelemetryCAD.ReadAll (first, size);
        return list;
}
}
}
