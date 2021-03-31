

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

public int New_ (string p_surnames, bool p_isActive, bool p_isDiseased, String p_pass, string p_name, string p_description, string p_email)
{
        RelatedPersonEN relatedPersonEN = null;
        int oid;

        //Initialized RelatedPersonEN
        relatedPersonEN = new RelatedPersonEN ();
        relatedPersonEN.Surnames = p_surnames;

        relatedPersonEN.IsActive = p_isActive;

        relatedPersonEN.IsDiseased = p_isDiseased;

        relatedPersonEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        relatedPersonEN.Name = p_name;

        relatedPersonEN.Description = p_description;

        relatedPersonEN.Email = p_email;

        //Call to RelatedPersonCAD

        oid = _IRelatedPersonCAD.New_ (relatedPersonEN);
        return oid;
}

public void Modify (int p_RelatedPerson_OID, string p_surnames, bool p_isActive, bool p_isDiseased, String p_pass, string p_name, string p_description, string p_email)
{
        RelatedPersonEN relatedPersonEN = null;

        //Initialized RelatedPersonEN
        relatedPersonEN = new RelatedPersonEN ();
        relatedPersonEN.Id = p_RelatedPerson_OID;
        relatedPersonEN.Surnames = p_surnames;
        relatedPersonEN.IsActive = p_isActive;
        relatedPersonEN.IsDiseased = p_isDiseased;
        relatedPersonEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        relatedPersonEN.Name = p_name;
        relatedPersonEN.Description = p_description;
        relatedPersonEN.Email = p_email;
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
