

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
 *      Definition of the class RelatedPersonCEN
 *
 */
public partial class RelatedPersonCEN
{
private IRelatedPersonCAD _IRelatedPersonCAD;

public RelatedPersonCEN()
{
        this._IRelatedPersonCAD = new RelatedPersonCAD ();
}

public RelatedPersonCEN(IRelatedPersonCAD _IRelatedPersonCAD)
{
        this._IRelatedPersonCAD = _IRelatedPersonCAD;
}

public IRelatedPersonCAD get_IRelatedPersonCAD ()
{
        return this._IRelatedPersonCAD;
}

public int New_ (string p_name, int p_scenario, string p_description, int p_userRelatedPerson)
{
        RelatedPersonEN relatedPersonEN = null;
        int oid;

        //Initialized RelatedPersonEN
        relatedPersonEN = new RelatedPersonEN ();
        relatedPersonEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                relatedPersonEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                relatedPersonEN.Scenario.Id = p_scenario;
        }

        relatedPersonEN.Description = p_description;


        if (p_userRelatedPerson != -1) {
                // El argumento p_userRelatedPerson -> Property userRelatedPerson es oid = false
                // Lista de oids id
                relatedPersonEN.UserRelatedPerson = new MoSIoTGenNHibernate.EN.MosIoT.UserEN ();
                relatedPersonEN.UserRelatedPerson.Id = p_userRelatedPerson;
        }

        //Call to RelatedPersonCAD

        oid = _IRelatedPersonCAD.New_ (relatedPersonEN);
        return oid;
}

public void Modify (int p_RelatedPerson_OID, string p_name, string p_description)
{
        RelatedPersonEN relatedPersonEN = null;

        //Initialized RelatedPersonEN
        relatedPersonEN = new RelatedPersonEN ();
        relatedPersonEN.Id = p_RelatedPerson_OID;
        relatedPersonEN.Name = p_name;
        relatedPersonEN.Description = p_description;
        //Call to RelatedPersonCAD

        _IRelatedPersonCAD.Modify (relatedPersonEN);
}

public void Destroy (int id
                     )
{
        _IRelatedPersonCAD.Destroy (id);
}

public RelatedPersonEN ReadOID (int id
                                )
{
        RelatedPersonEN relatedPersonEN = null;

        relatedPersonEN = _IRelatedPersonCAD.ReadOID (id);
        return relatedPersonEN;
}

public System.Collections.Generic.IList<RelatedPersonEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RelatedPersonEN> list = null;

        list = _IRelatedPersonCAD.ReadAll (first, size);
        return list;
}
}
}
