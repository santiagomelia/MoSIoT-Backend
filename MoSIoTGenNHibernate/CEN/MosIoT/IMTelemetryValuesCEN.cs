

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
 *      Definition of the class IMTelemetryValuesCEN
 *
 */
public partial class IMTelemetryValuesCEN
{
private IIMTelemetryValuesCAD _IIMTelemetryValuesCAD;

public IMTelemetryValuesCEN()
{
        this._IIMTelemetryValuesCAD = new IMTelemetryValuesCAD ();
}

public IMTelemetryValuesCEN(IIMTelemetryValuesCAD _IIMTelemetryValuesCAD)
{
        this._IIMTelemetryValuesCAD = _IIMTelemetryValuesCAD;
}

public IIMTelemetryValuesCAD get_IIMTelemetryValuesCAD ()
{
        return this._IIMTelemetryValuesCAD;
}

public int New_ (Nullable<DateTime> p_timeStamp, string p_valu, int p_iMTelemetry)
{
        IMTelemetryValuesEN iMTelemetryValuesEN = null;
        int oid;

        //Initialized IMTelemetryValuesEN
        iMTelemetryValuesEN = new IMTelemetryValuesEN ();
        iMTelemetryValuesEN.TimeStamp = p_timeStamp;

        iMTelemetryValuesEN.Valu = p_valu;


        if (p_iMTelemetry != -1) {
                // El argumento p_iMTelemetry -> Property iMTelemetry es oid = false
                // Lista de oids id
                iMTelemetryValuesEN.IMTelemetry = new MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN ();
                iMTelemetryValuesEN.IMTelemetry.Id = p_iMTelemetry;
        }

        //Call to IMTelemetryValuesCAD

        oid = _IIMTelemetryValuesCAD.New_ (iMTelemetryValuesEN);
        return oid;
}

public void Modify (int p_IMTelemetryValues_OID, Nullable<DateTime> p_timeStamp, string p_valu)
{
        IMTelemetryValuesEN iMTelemetryValuesEN = null;

        //Initialized IMTelemetryValuesEN
        iMTelemetryValuesEN = new IMTelemetryValuesEN ();
        iMTelemetryValuesEN.Id = p_IMTelemetryValues_OID;
        iMTelemetryValuesEN.TimeStamp = p_timeStamp;
        iMTelemetryValuesEN.Valu = p_valu;
        //Call to IMTelemetryValuesCAD

        _IIMTelemetryValuesCAD.Modify (iMTelemetryValuesEN);
}

public void Destroy (int id
                     )
{
        _IIMTelemetryValuesCAD.Destroy (id);
}

public IMTelemetryValuesEN ReadOID (int id
                                    )
{
        IMTelemetryValuesEN iMTelemetryValuesEN = null;

        iMTelemetryValuesEN = _IIMTelemetryValuesCAD.ReadOID (id);
        return iMTelemetryValuesEN;
}

public System.Collections.Generic.IList<IMTelemetryValuesEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMTelemetryValuesEN> list = null;

        list = _IIMTelemetryValuesCAD.ReadAll (first, size);
        return list;
}
}
}
