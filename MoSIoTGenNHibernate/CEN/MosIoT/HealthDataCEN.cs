

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
 *      Definition of the class HealthDataCEN
 *
 */
public partial class HealthDataCEN
{
private IHealthDataCAD _IHealthDataCAD;

public HealthDataCEN()
{
        this._IHealthDataCAD = new HealthDataCAD ();
}

public HealthDataCEN(IHealthDataCAD _IHealthDataCAD)
{
        this._IHealthDataCAD = _IHealthDataCAD;
}

public IHealthDataCAD get_IHealthDataCAD ()
{
        return this._IHealthDataCAD;
}

public int New_ (string p_description, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum p_language, string p_system, string p_code, string p_display)
{
        HealthDataEN healthDataEN = null;
        int oid;

        //Initialized HealthDataEN
        healthDataEN = new HealthDataEN ();
        healthDataEN.Description = p_description;

        healthDataEN.Language = p_language;

        healthDataEN.System = p_system;

        healthDataEN.Code = p_code;

        healthDataEN.Display = p_display;

        //Call to HealthDataCAD

        oid = _IHealthDataCAD.New_ (healthDataEN);
        return oid;
}

public void Modify (int p_HealthData_OID, string p_description, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum p_language, string p_system, string p_code, string p_display)
{
        HealthDataEN healthDataEN = null;

        //Initialized HealthDataEN
        healthDataEN = new HealthDataEN ();
        healthDataEN.Id = p_HealthData_OID;
        healthDataEN.Description = p_description;
        healthDataEN.Language = p_language;
        healthDataEN.System = p_system;
        healthDataEN.Code = p_code;
        healthDataEN.Display = p_display;
        //Call to HealthDataCAD

        _IHealthDataCAD.Modify (healthDataEN);
}

public void Destroy (int id
                     )
{
        _IHealthDataCAD.Destroy (id);
}
}
}
