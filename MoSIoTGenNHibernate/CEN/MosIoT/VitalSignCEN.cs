

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
 *      Definition of the class VitalSignCEN
 *
 */
public partial class VitalSignCEN
{
private IVitalSignCAD _IVitalSignCAD;

public VitalSignCEN()
{
        this._IVitalSignCAD = new VitalSignCAD ();
}

public VitalSignCEN(IVitalSignCAD _IVitalSignCAD)
{
        this._IVitalSignCAD = _IVitalSignCAD;
}

public IVitalSignCAD get_IVitalSignCAD ()
{
        return this._IVitalSignCAD;
}

public int New_ (string p_name, int p_scenario, string p_description, int p_measure)
{
        VitalSignEN vitalSignEN = null;
        int oid;

        //Initialized VitalSignEN
        vitalSignEN = new VitalSignEN ();
        vitalSignEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                vitalSignEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                vitalSignEN.Scenario.Id = p_scenario;
        }

        vitalSignEN.Description = p_description;


        if (p_measure != -1) {
                // El argumento p_measure -> Property measure es oid = false
                // Lista de oids id
                vitalSignEN.Measure = new MoSIoTGenNHibernate.EN.MosIoT.MeasureEN ();
                vitalSignEN.Measure.Id = p_measure;
        }

        //Call to VitalSignCAD

        oid = _IVitalSignCAD.New_ (vitalSignEN);
        return oid;
}

public void Modify (int p_VitalSign_OID, string p_name, string p_description)
{
        VitalSignEN vitalSignEN = null;

        //Initialized VitalSignEN
        vitalSignEN = new VitalSignEN ();
        vitalSignEN.Id = p_VitalSign_OID;
        vitalSignEN.Name = p_name;
        vitalSignEN.Description = p_description;
        //Call to VitalSignCAD

        _IVitalSignCAD.Modify (vitalSignEN);
}

public void Destroy (int id
                     )
{
        _IVitalSignCAD.Destroy (id);
}

public VitalSignEN ReadOID (int id
                            )
{
        VitalSignEN vitalSignEN = null;

        vitalSignEN = _IVitalSignCAD.ReadOID (id);
        return vitalSignEN;
}

public System.Collections.Generic.IList<VitalSignEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<VitalSignEN> list = null;

        list = _IVitalSignCAD.ReadAll (first, size);
        return list;
}
}
}
