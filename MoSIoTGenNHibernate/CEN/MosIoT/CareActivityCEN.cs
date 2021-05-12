

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
 *      Definition of the class CareActivityCEN
 *
 */
public partial class CareActivityCEN
{
private ICareActivityCAD _ICareActivityCAD;

public CareActivityCEN()
{
        this._ICareActivityCAD = new CareActivityCAD ();
}

public CareActivityCEN(ICareActivityCAD _ICareActivityCAD)
{
        this._ICareActivityCAD = _ICareActivityCAD;
}

public ICareActivityCAD get_ICareActivityCAD ()
{
        return this._ICareActivityCAD;
}

public int New_ (int p_carePlanTemplate, MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum p_periodicity, string p_description, int p_duration, string p_location, string p_outcomeCode, MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum p_typeActivity, string p_activityCode, string p_name)
{
        CareActivityEN careActivityEN = null;
        int oid;

        //Initialized CareActivityEN
        careActivityEN = new CareActivityEN ();

        if (p_carePlanTemplate != -1) {
                // El argumento p_carePlanTemplate -> Property carePlanTemplate es oid = false
                // Lista de oids id
                careActivityEN.CarePlanTemplate = new MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN ();
                careActivityEN.CarePlanTemplate.Id = p_carePlanTemplate;
        }

        careActivityEN.Periodicity = p_periodicity;

        careActivityEN.Description = p_description;

        careActivityEN.Duration = p_duration;

        careActivityEN.Location = p_location;

        careActivityEN.OutcomeCode = p_outcomeCode;

        careActivityEN.TypeActivity = p_typeActivity;

        careActivityEN.ActivityCode = p_activityCode;

        careActivityEN.Name = p_name;

        //Call to CareActivityCAD

        oid = _ICareActivityCAD.New_ (careActivityEN);
        return oid;
}

public void Modify (int p_CareActivity_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.TypePeriodicityEnum p_periodicity, string p_description, int p_duration, string p_location, string p_outcomeCode, MoSIoTGenNHibernate.Enumerated.MosIoT.TypeActivityEnum p_typeActivity, string p_activityCode, string p_name)
{
        CareActivityEN careActivityEN = null;

        //Initialized CareActivityEN
        careActivityEN = new CareActivityEN ();
        careActivityEN.Id = p_CareActivity_OID;
        careActivityEN.Periodicity = p_periodicity;
        careActivityEN.Description = p_description;
        careActivityEN.Duration = p_duration;
        careActivityEN.Location = p_location;
        careActivityEN.OutcomeCode = p_outcomeCode;
        careActivityEN.TypeActivity = p_typeActivity;
        careActivityEN.ActivityCode = p_activityCode;
        careActivityEN.Name = p_name;
        //Call to CareActivityCAD

        _ICareActivityCAD.Modify (careActivityEN);
}

public void Destroy (int id
                     )
{
        _ICareActivityCAD.Destroy (id);
}

public CareActivityEN ReadOID (int id
                               )
{
        CareActivityEN careActivityEN = null;

        careActivityEN = _ICareActivityCAD.ReadOID (id);
        return careActivityEN;
}

public System.Collections.Generic.IList<CareActivityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CareActivityEN> list = null;

        list = _ICareActivityCAD.ReadAll (first, size);
        return list;
}
}
}
