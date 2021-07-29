

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
 *      Definition of the class IMCommandCEN
 *
 */
public partial class IMCommandCEN
{
private IIMCommandCAD _IIMCommandCAD;

public IMCommandCEN()
{
        this._IIMCommandCAD = new IMCommandCAD ();
}

public IMCommandCEN(IIMCommandCAD _IIMCommandCAD)
{
        this._IIMCommandCAD = _IIMCommandCAD;
}

public IIMCommandCAD get_IIMCommandCAD ()
{
        return this._IIMCommandCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum p_serviceType, string p_description, int p_entity)
{
        IMCommandEN iMCommandEN = null;
        int oid;

        //Initialized IMCommandEN
        iMCommandEN = new IMCommandEN ();
        iMCommandEN.Name = p_name;

        iMCommandEN.Type = p_type;

        iMCommandEN.ServiceType = p_serviceType;

        iMCommandEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMCommandEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMCommandEN.Entity.Id = p_entity;
        }

        //Call to IMCommandCAD

        oid = _IIMCommandCAD.New_ (iMCommandEN);
        return oid;
}

public void Modify (int p_IMCommand_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum p_serviceType, string p_description)
{
        IMCommandEN iMCommandEN = null;

        //Initialized IMCommandEN
        iMCommandEN = new IMCommandEN ();
        iMCommandEN.Id = p_IMCommand_OID;
        iMCommandEN.Name = p_name;
        iMCommandEN.Type = p_type;
        iMCommandEN.ServiceType = p_serviceType;
        iMCommandEN.Description = p_description;
        //Call to IMCommandCAD

        _IIMCommandCAD.Modify (iMCommandEN);
}

public void Destroy (int id
                     )
{
        _IIMCommandCAD.Destroy (id);
}

public IMCommandEN ReadOID (int id
                            )
{
        IMCommandEN iMCommandEN = null;

        iMCommandEN = _IIMCommandCAD.ReadOID (id);
        return iMCommandEN;
}

public System.Collections.Generic.IList<IMCommandEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMCommandEN> list = null;

        list = _IIMCommandCAD.ReadAll (first, size);
        return list;
}
public void AssignCommand (int p_IMCommand_OID, int p_command_OID)
{
        //Call to IMCommandCAD

        _IIMCommandCAD.AssignCommand (p_IMCommand_OID, p_command_OID);
}
}
}
