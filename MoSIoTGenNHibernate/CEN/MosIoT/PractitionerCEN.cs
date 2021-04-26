

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
 *      Definition of the class PractitionerCEN
 *
 */
public partial class PractitionerCEN
{
private IPractitionerCAD _IPractitionerCAD;

public PractitionerCEN()
{
        this._IPractitionerCAD = new PractitionerCAD ();
}

public PractitionerCEN(IPractitionerCAD _IPractitionerCAD)
{
        this._IPractitionerCAD = _IPractitionerCAD;
}

public IPractitionerCAD get_IPractitionerCAD ()
{
        return this._IPractitionerCAD;
}

public int New_ (string p_name, int p_scenario, string p_description, int p_userPractitioner)
{
        PractitionerEN practitionerEN = null;
        int oid;

        //Initialized PractitionerEN
        practitionerEN = new PractitionerEN ();
        practitionerEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                practitionerEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                practitionerEN.Scenario.Id = p_scenario;
        }

        practitionerEN.Description = p_description;


        if (p_userPractitioner != -1) {
                // El argumento p_userPractitioner -> Property userPractitioner es oid = false
                // Lista de oids id
                practitionerEN.UserPractitioner = new MoSIoTGenNHibernate.EN.MosIoT.UserEN ();
                practitionerEN.UserPractitioner.Id = p_userPractitioner;
        }

        //Call to PractitionerCAD

        oid = _IPractitionerCAD.New_ (practitionerEN);
        return oid;
}

public void Modify (int p_Practitioner_OID, string p_name, string p_description)
{
        PractitionerEN practitionerEN = null;

        //Initialized PractitionerEN
        practitionerEN = new PractitionerEN ();
        practitionerEN.Id = p_Practitioner_OID;
        practitionerEN.Name = p_name;
        practitionerEN.Description = p_description;
        //Call to PractitionerCAD

        _IPractitionerCAD.Modify (practitionerEN);
}

public void Destroy (int id
                     )
{
        _IPractitionerCAD.Destroy (id);
}

public PractitionerEN ReadOID (int id
                               )
{
        PractitionerEN practitionerEN = null;

        practitionerEN = _IPractitionerCAD.ReadOID (id);
        return practitionerEN;
}

public System.Collections.Generic.IList<PractitionerEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PractitionerEN> list = null;

        list = _IPractitionerCAD.ReadAll (first, size);
        return list;
}
}
}
