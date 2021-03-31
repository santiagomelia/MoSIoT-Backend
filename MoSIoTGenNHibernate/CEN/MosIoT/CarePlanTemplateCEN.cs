

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
 *      Definition of the class CarePlanTemplateCEN
 *
 */
public partial class CarePlanTemplateCEN
{
private ICarePlanTemplateCAD _ICarePlanTemplateCAD;

public CarePlanTemplateCEN()
{
        this._ICarePlanTemplateCAD = new CarePlanTemplateCAD ();
}

public CarePlanTemplateCEN(ICarePlanTemplateCAD _ICarePlanTemplateCAD)
{
        this._ICarePlanTemplateCAD = _ICarePlanTemplateCAD;
}

public ICarePlanTemplateCAD get_ICarePlanTemplateCAD ()
{
        return this._ICarePlanTemplateCAD;
}

public int New_ (MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum p_status, MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanInentEnum p_intent, string p_title, Nullable<DateTime> p_modified, int p_durationDays, string p_name, string p_description)
{
        CarePlanTemplateEN carePlanTemplateEN = null;
        int oid;

        //Initialized CarePlanTemplateEN
        carePlanTemplateEN = new CarePlanTemplateEN ();
        carePlanTemplateEN.Status = p_status;

        carePlanTemplateEN.Intent = p_intent;

        carePlanTemplateEN.Title = p_title;

        carePlanTemplateEN.Modified = p_modified;

        carePlanTemplateEN.DurationDays = p_durationDays;

        carePlanTemplateEN.Name = p_name;

        carePlanTemplateEN.Description = p_description;

        //Call to CarePlanTemplateCAD

        oid = _ICarePlanTemplateCAD.New_ (carePlanTemplateEN);
        return oid;
}

public void Modify (int p_CarePlanTemplate_OID, MoSIoTGenNHibernate.Enumerated.MosIoT.CareStatusEnum p_status, MoSIoTGenNHibernate.Enumerated.MosIoT.CarePlanInentEnum p_intent, string p_title, Nullable<DateTime> p_modified, int p_durationDays, string p_name, string p_description)
{
        CarePlanTemplateEN carePlanTemplateEN = null;

        //Initialized CarePlanTemplateEN
        carePlanTemplateEN = new CarePlanTemplateEN ();
        carePlanTemplateEN.Id = p_CarePlanTemplate_OID;
        carePlanTemplateEN.Status = p_status;
        carePlanTemplateEN.Intent = p_intent;
        carePlanTemplateEN.Title = p_title;
        carePlanTemplateEN.Modified = p_modified;
        carePlanTemplateEN.DurationDays = p_durationDays;
        carePlanTemplateEN.Name = p_name;
        carePlanTemplateEN.Description = p_description;
        //Call to CarePlanTemplateCAD

        _ICarePlanTemplateCAD.Modify (carePlanTemplateEN);
}

public void Destroy (int id
                     )
{
        _ICarePlanTemplateCAD.Destroy (id);
}

public void AddCondition (int p_CarePlanTemplate_OID, System.Collections.Generic.IList<int> p_addressConditions_OIDs)
{
        //Call to CarePlanTemplateCAD

        _ICarePlanTemplateCAD.AddCondition (p_CarePlanTemplate_OID, p_addressConditions_OIDs);
}
public CarePlanTemplateEN ReadOID (int id
                                   )
{
        CarePlanTemplateEN carePlanTemplateEN = null;

        carePlanTemplateEN = _ICarePlanTemplateCAD.ReadOID (id);
        return carePlanTemplateEN;
}

public System.Collections.Generic.IList<CarePlanTemplateEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarePlanTemplateEN> list = null;

        list = _ICarePlanTemplateCAD.ReadAll (first, size);
        return list;
}
}
}
