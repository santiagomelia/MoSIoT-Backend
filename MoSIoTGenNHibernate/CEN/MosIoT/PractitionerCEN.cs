

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

public int New_ (string p_surnames, bool p_isActive, bool p_isDiseased, String p_pass, string p_name, string p_description, string p_email)
{
        PractitionerEN practitionerEN = null;
        int oid;

        //Initialized PractitionerEN
        practitionerEN = new PractitionerEN ();
        practitionerEN.Surnames = p_surnames;

        practitionerEN.IsActive = p_isActive;

        practitionerEN.IsDiseased = p_isDiseased;

        practitionerEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        practitionerEN.Name = p_name;

        practitionerEN.Description = p_description;

        practitionerEN.Email = p_email;

        //Call to PractitionerCAD

        oid = _IPractitionerCAD.New_ (practitionerEN);
        return oid;
}

public void Modify (int p_Practitioner_OID, string p_surnames, bool p_isActive, bool p_isDiseased, String p_pass, string p_name, string p_description, string p_email)
{
        PractitionerEN practitionerEN = null;

        //Initialized PractitionerEN
        practitionerEN = new PractitionerEN ();
        practitionerEN.Id = p_Practitioner_OID;
        practitionerEN.Surnames = p_surnames;
        practitionerEN.IsActive = p_isActive;
        practitionerEN.IsDiseased = p_isDiseased;
        practitionerEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        practitionerEN.Name = p_name;
        practitionerEN.Description = p_description;
        practitionerEN.Email = p_email;
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
