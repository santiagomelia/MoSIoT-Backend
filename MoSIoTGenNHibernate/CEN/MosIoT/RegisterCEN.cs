

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
 *      Definition of the class RegisterCEN
 *
 */
public partial class RegisterCEN
{
private IRegisterCAD _IRegisterCAD;

public RegisterCEN()
{
        this._IRegisterCAD = new RegisterCAD ();
}

public RegisterCEN(IRegisterCAD _IRegisterCAD)
{
        this._IRegisterCAD = _IRegisterCAD;
}

public IRegisterCAD get_IRegisterCAD ()
{
        return this._IRegisterCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum p_serviceType, string p_description, int p_entity, int p_entityAttributes)
{
        RegisterEN registerEN = null;
        int oid;

        //Initialized RegisterEN
        registerEN = new RegisterEN ();
        registerEN.Name = p_name;

        registerEN.Type = p_type;

        registerEN.ServiceType = p_serviceType;

        registerEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                registerEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                registerEN.Entity.Id = p_entity;
        }


        if (p_entityAttributes != -1) {
                // El argumento p_entityAttributes -> Property entityAttributes es oid = false
                // Lista de oids id
                registerEN.EntityAttributes = new MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN ();
                registerEN.EntityAttributes.Id = p_entityAttributes;
        }

        //Call to RegisterCAD

        oid = _IRegisterCAD.New_ (registerEN);
        return oid;
}

public void Modify (int p_Register_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum p_serviceType, string p_description)
{
        RegisterEN registerEN = null;

        //Initialized RegisterEN
        registerEN = new RegisterEN ();
        registerEN.Id = p_Register_OID;
        registerEN.Name = p_name;
        registerEN.Type = p_type;
        registerEN.ServiceType = p_serviceType;
        registerEN.Description = p_description;
        //Call to RegisterCAD

        _IRegisterCAD.Modify (registerEN);
}

public void Destroy (int id
                     )
{
        _IRegisterCAD.Destroy (id);
}

public RegisterEN ReadOID (int id
                           )
{
        RegisterEN registerEN = null;

        registerEN = _IRegisterCAD.ReadOID (id);
        return registerEN;
}

public System.Collections.Generic.IList<RegisterEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<RegisterEN> list = null;

        list = _IRegisterCAD.ReadAll (first, size);
        return list;
}
}
}
