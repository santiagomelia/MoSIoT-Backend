

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
 *      Definition of the class ConditionCEN
 *
 */
public partial class ConditionCEN
{
private IConditionCAD _IConditionCAD;

public ConditionCEN()
{
        this._IConditionCAD = new ConditionCAD ();
}

public ConditionCEN(IConditionCAD _IConditionCAD)
{
        this._IConditionCAD = _IConditionCAD;
}

public IConditionCAD get_IConditionCAD ()
{
        return this._IConditionCAD;
}

public int New_ (int p_patientProfile, Nullable<DateTime> p_dateInitial, string p_description, MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum p_clinicalStatus, MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum p_disease, string p_name)
{
        ConditionEN conditionEN = null;
        int oid;

        //Initialized ConditionEN
        conditionEN = new ConditionEN ();

        if (p_patientProfile != -1) {
                // El argumento p_patientProfile -> Property patientProfile es oid = false
                // Lista de oids id
                conditionEN.PatientProfile = new MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN ();
                conditionEN.PatientProfile.Id = p_patientProfile;
        }

        conditionEN.DateInitial = p_dateInitial;

        conditionEN.Description = p_description;

        conditionEN.ClinicalStatus = p_clinicalStatus;

        conditionEN.Disease = p_disease;

        conditionEN.Name = p_name;

        //Call to ConditionCAD

        oid = _IConditionCAD.New_ (conditionEN);
        return oid;
}

public void Modify (int p_Condition_OID, Nullable<DateTime> p_dateInitial, string p_description, MoSIoTGenNHibernate.Enumerated.MosIoT.ClinicalStatusEnum p_clinicalStatus, MoSIoTGenNHibernate.Enumerated.MosIoT.DiseaseEnum p_disease, string p_name)
{
        ConditionEN conditionEN = null;

        //Initialized ConditionEN
        conditionEN = new ConditionEN ();
        conditionEN.Id = p_Condition_OID;
        conditionEN.DateInitial = p_dateInitial;
        conditionEN.Description = p_description;
        conditionEN.ClinicalStatus = p_clinicalStatus;
        conditionEN.Disease = p_disease;
        conditionEN.Name = p_name;
        //Call to ConditionCAD

        _IConditionCAD.Modify (conditionEN);
}

public void Destroy (int id
                     )
{
        _IConditionCAD.Destroy (id);
}

public ConditionEN ReadOID (int id
                            )
{
        ConditionEN conditionEN = null;

        conditionEN = _IConditionCAD.ReadOID (id);
        return conditionEN;
}

public System.Collections.Generic.IList<ConditionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ConditionEN> list = null;

        list = _IConditionCAD.ReadAll (first, size);
        return list;
}
}
}
