

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
 *      Definition of the class IMMedicationCEN
 *
 */
public partial class IMMedicationCEN
{
private IIMMedicationCAD _IIMMedicationCAD;

public IMMedicationCEN()
{
        this._IIMMedicationCAD = new IMMedicationCAD ();
}

public IMMedicationCEN(IIMMedicationCAD _IIMMedicationCAD)
{
        this._IIMMedicationCAD = _IIMMedicationCAD;
}

public IIMMedicationCAD get_IIMMedicationCAD ()
{
        return this._IIMMedicationCAD;
}

public int New_ (string p_name, string p_description, int p_entity)
{
        IMMedicationEN iMMedicationEN = null;
        int oid;

        //Initialized IMMedicationEN
        iMMedicationEN = new IMMedicationEN ();
        iMMedicationEN.Name = p_name;

        iMMedicationEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMMedicationEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMMedicationEN.Entity.Id = p_entity;
        }

        //Call to IMMedicationCAD

        oid = _IIMMedicationCAD.New_ (iMMedicationEN);
        return oid;
}

public void Modify (int p_IMMedication_OID, string p_name, string p_description)
{
        IMMedicationEN iMMedicationEN = null;

        //Initialized IMMedicationEN
        iMMedicationEN = new IMMedicationEN ();
        iMMedicationEN.Id = p_IMMedication_OID;
        iMMedicationEN.Name = p_name;
        iMMedicationEN.Description = p_description;
        //Call to IMMedicationCAD

        _IIMMedicationCAD.Modify (iMMedicationEN);
}

public void Destroy (int id
                     )
{
        _IIMMedicationCAD.Destroy (id);
}

public IMMedicationEN ReadOID (int id
                               )
{
        IMMedicationEN iMMedicationEN = null;

        iMMedicationEN = _IIMMedicationCAD.ReadOID (id);
        return iMMedicationEN;
}

public System.Collections.Generic.IList<IMMedicationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMMedicationEN> list = null;

        list = _IIMMedicationCAD.ReadAll (first, size);
        return list;
}
public void AssignMedication (int p_IMMedication_OID, int p_medication_OID)
{
        //Call to IMMedicationCAD

        _IIMMedicationCAD.AssignMedication (p_IMMedication_OID, p_medication_OID);
}
}
}
