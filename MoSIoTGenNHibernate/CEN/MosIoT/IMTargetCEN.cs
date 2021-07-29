

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
 *      Definition of the class IMTargetCEN
 *
 */
public partial class IMTargetCEN
{
private IIMTargetCAD _IIMTargetCAD;

public IMTargetCEN()
{
        this._IIMTargetCAD = new IMTargetCAD ();
}

public IMTargetCEN(IIMTargetCAD _IIMTargetCAD)
{
        this._IIMTargetCAD = _IIMTargetCAD;
}

public IIMTargetCAD get_IIMTargetCAD ()
{
        return this._IIMTargetCAD;
}

public int New_ (string p_name, string p_description, int p_entity)
{
        IMTargetEN iMTargetEN = null;
        int oid;

        //Initialized IMTargetEN
        iMTargetEN = new IMTargetEN ();
        iMTargetEN.Name = p_name;

        iMTargetEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMTargetEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMTargetEN.Entity.Id = p_entity;
        }

        //Call to IMTargetCAD

        oid = _IIMTargetCAD.New_ (iMTargetEN);
        return oid;
}

public void Modify (int p_IMTarget_OID, string p_name, string p_description)
{
        IMTargetEN iMTargetEN = null;

        //Initialized IMTargetEN
        iMTargetEN = new IMTargetEN ();
        iMTargetEN.Id = p_IMTarget_OID;
        iMTargetEN.Name = p_name;
        iMTargetEN.Description = p_description;
        //Call to IMTargetCAD

        _IIMTargetCAD.Modify (iMTargetEN);
}

public void Destroy (int id
                     )
{
        _IIMTargetCAD.Destroy (id);
}

public IMTargetEN ReadOID (int id
                           )
{
        IMTargetEN iMTargetEN = null;

        iMTargetEN = _IIMTargetCAD.ReadOID (id);
        return iMTargetEN;
}

public System.Collections.Generic.IList<IMTargetEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMTargetEN> list = null;

        list = _IIMTargetCAD.ReadAll (first, size);
        return list;
}
public void AssignTarget (int p_IMTarget_OID, int p_target_OID)
{
        //Call to IMTargetCAD

        _IIMTargetCAD.AssignTarget (p_IMTarget_OID, p_target_OID);
}
}
}
