

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
 *      Definition of the class IMTelemetryCEN
 *
 */
public partial class IMTelemetryCEN
{
private IIMTelemetryCAD _IIMTelemetryCAD;

public IMTelemetryCEN()
{
        this._IIMTelemetryCAD = new IMTelemetryCAD ();
}

public IMTelemetryCEN(IIMTelemetryCAD _IIMTelemetryCAD)
{
        this._IIMTelemetryCAD = _IIMTelemetryCAD;
}

public IIMTelemetryCAD get_IIMTelemetryCAD ()
{
        return this._IIMTelemetryCAD;
}

public int New_ (string p_name, int p_scenario, string p_description)
{
        IMTelemetryEN iMTelemetryEN = null;
        int oid;

        //Initialized IMTelemetryEN
        iMTelemetryEN = new IMTelemetryEN ();
        iMTelemetryEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                iMTelemetryEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                iMTelemetryEN.Scenario.Id = p_scenario;
        }

        iMTelemetryEN.Description = p_description;

        //Call to IMTelemetryCAD

        oid = _IIMTelemetryCAD.New_ (iMTelemetryEN);
        return oid;
}

public void Modify (int p_IMTelemetry_OID, string p_name, string p_description)
{
        IMTelemetryEN iMTelemetryEN = null;

        //Initialized IMTelemetryEN
        iMTelemetryEN = new IMTelemetryEN ();
        iMTelemetryEN.Id = p_IMTelemetry_OID;
        iMTelemetryEN.Name = p_name;
        iMTelemetryEN.Description = p_description;
        //Call to IMTelemetryCAD

        _IIMTelemetryCAD.Modify (iMTelemetryEN);
}

public void Destroy (int id
                     )
{
        _IIMTelemetryCAD.Destroy (id);
}

public IMTelemetryEN ReadOID (int id
                              )
{
        IMTelemetryEN iMTelemetryEN = null;

        iMTelemetryEN = _IIMTelemetryCAD.ReadOID (id);
        return iMTelemetryEN;
}

public System.Collections.Generic.IList<IMTelemetryEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMTelemetryEN> list = null;

        list = _IIMTelemetryCAD.ReadAll (first, size);
        return list;
}
public void AssignTelemetry (int p_IMTelemetry_OID, int p_telemetry_OID)
{
        //Call to IMTelemetryCAD

        _IIMTelemetryCAD.AssignTelemetry (p_IMTelemetry_OID, p_telemetry_OID);
}
}
}
