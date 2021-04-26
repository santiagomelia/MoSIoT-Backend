

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
 *      Definition of the class MeasureCEN
 *
 */
public partial class MeasureCEN
{
private IMeasureCAD _IMeasureCAD;

public MeasureCEN()
{
        this._IMeasureCAD = new MeasureCAD ();
}

public MeasureCEN(IMeasureCAD _IMeasureCAD)
{
        this._IMeasureCAD = _IMeasureCAD;
}

public IMeasureCAD get_IMeasureCAD ()
{
        return this._IMeasureCAD;
}

public int New_ (string p_name, string p_description, string p_LOINCcode)
{
        MeasureEN measureEN = null;
        int oid;

        //Initialized MeasureEN
        measureEN = new MeasureEN ();
        measureEN.Name = p_name;

        measureEN.Description = p_description;

        measureEN.LOINCcode = p_LOINCcode;

        //Call to MeasureCAD

        oid = _IMeasureCAD.New_ (measureEN);
        return oid;
}

public void Modify (int p_Measure_OID, string p_name, string p_description, string p_LOINCcode)
{
        MeasureEN measureEN = null;

        //Initialized MeasureEN
        measureEN = new MeasureEN ();
        measureEN.Id = p_Measure_OID;
        measureEN.Name = p_name;
        measureEN.Description = p_description;
        measureEN.LOINCcode = p_LOINCcode;
        //Call to MeasureCAD

        _IMeasureCAD.Modify (measureEN);
}

public void Destroy (int id
                     )
{
        _IMeasureCAD.Destroy (id);
}

public MeasureEN ReadOID (int id
                          )
{
        MeasureEN measureEN = null;

        measureEN = _IMeasureCAD.ReadOID (id);
        return measureEN;
}

public System.Collections.Generic.IList<MeasureEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MeasureEN> list = null;

        list = _IMeasureCAD.ReadAll (first, size);
        return list;
}
public void AddTelemetries (int p_Measure_OID, System.Collections.Generic.IList<int> p_telemetry_OIDs)
{
        //Call to MeasureCAD

        _IMeasureCAD.AddTelemetries (p_Measure_OID, p_telemetry_OIDs);
}
}
}
