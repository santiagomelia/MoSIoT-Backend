

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
 *      Definition of the class CarePlanCEN
 *
 */
public partial class CarePlanCEN
{
private ICarePlanCAD _ICarePlanCAD;

public CarePlanCEN()
{
        this._ICarePlanCAD = new CarePlanCAD ();
}

public CarePlanCEN(ICarePlanCAD _ICarePlanCAD)
{
        this._ICarePlanCAD = _ICarePlanCAD;
}

public ICarePlanCAD get_ICarePlanCAD ()
{
        return this._ICarePlanCAD;
}

public int New_ (string p_name, int p_scenario, string p_description, int p_template)
{
        CarePlanEN carePlanEN = null;
        int oid;

        //Initialized CarePlanEN
        carePlanEN = new CarePlanEN ();
        carePlanEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                carePlanEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                carePlanEN.Scenario.Id = p_scenario;
        }

        carePlanEN.Description = p_description;


        if (p_template != -1) {
                // El argumento p_template -> Property template es oid = false
                // Lista de oids id
                carePlanEN.Template = new MoSIoTGenNHibernate.EN.MosIoT.CarePlanTemplateEN ();
                carePlanEN.Template.Id = p_template;
        }

        //Call to CarePlanCAD

        oid = _ICarePlanCAD.New_ (carePlanEN);
        return oid;
}

public void Modify (int p_CarePlan_OID, string p_name, string p_description)
{
        CarePlanEN carePlanEN = null;

        //Initialized CarePlanEN
        carePlanEN = new CarePlanEN ();
        carePlanEN.Id = p_CarePlan_OID;
        carePlanEN.Name = p_name;
        carePlanEN.Description = p_description;
        //Call to CarePlanCAD

        _ICarePlanCAD.Modify (carePlanEN);
}

public void Destroy (int id
                     )
{
        _ICarePlanCAD.Destroy (id);
}

public CarePlanEN ReadOID (int id
                           )
{
        CarePlanEN carePlanEN = null;

        carePlanEN = _ICarePlanCAD.ReadOID (id);
        return carePlanEN;
}

public System.Collections.Generic.IList<CarePlanEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarePlanEN> list = null;

        list = _ICarePlanCAD.ReadAll (first, size);
        return list;
}
}
}
