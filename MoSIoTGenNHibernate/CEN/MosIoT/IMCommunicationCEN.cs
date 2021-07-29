

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
 *      Definition of the class IMCommunicationCEN
 *
 */
public partial class IMCommunicationCEN
{
private IIMCommunicationCAD _IIMCommunicationCAD;

public IMCommunicationCEN()
{
        this._IIMCommunicationCAD = new IMCommunicationCAD ();
}

public IMCommunicationCEN(IIMCommunicationCAD _IIMCommunicationCAD)
{
        this._IIMCommunicationCAD = _IIMCommunicationCAD;
}

public IIMCommunicationCAD get_IIMCommunicationCAD ()
{
        return this._IIMCommunicationCAD;
}

public int New_ (string p_name, string p_description, int p_entity)
{
        IMCommunicationEN iMCommunicationEN = null;
        int oid;

        //Initialized IMCommunicationEN
        iMCommunicationEN = new IMCommunicationEN ();
        iMCommunicationEN.Name = p_name;

        iMCommunicationEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMCommunicationEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMCommunicationEN.Entity.Id = p_entity;
        }

        //Call to IMCommunicationCAD

        oid = _IIMCommunicationCAD.New_ (iMCommunicationEN);
        return oid;
}

public void Modify (int p_IMCommunication_OID, string p_name, string p_description)
{
        IMCommunicationEN iMCommunicationEN = null;

        //Initialized IMCommunicationEN
        iMCommunicationEN = new IMCommunicationEN ();
        iMCommunicationEN.Id = p_IMCommunication_OID;
        iMCommunicationEN.Name = p_name;
        iMCommunicationEN.Description = p_description;
        //Call to IMCommunicationCAD

        _IIMCommunicationCAD.Modify (iMCommunicationEN);
}

public void Destroy (int id
                     )
{
        _IIMCommunicationCAD.Destroy (id);
}

public IMCommunicationEN ReadOID (int id
                                  )
{
        IMCommunicationEN iMCommunicationEN = null;

        iMCommunicationEN = _IIMCommunicationCAD.ReadOID (id);
        return iMCommunicationEN;
}

public System.Collections.Generic.IList<IMCommunicationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMCommunicationEN> list = null;

        list = _IIMCommunicationCAD.ReadAll (first, size);
        return list;
}
public void AssignCommunication (int p_IMCommunication_OID, int p_comunication_OID)
{
        //Call to IMCommunicationCAD

        _IIMCommunicationCAD.AssignCommunication (p_IMCommunication_OID, p_comunication_OID);
}
}
}
