

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
 *      Definition of the class AssociationCEN
 *
 */
public partial class AssociationCEN
{
private IAssociationCAD _IAssociationCAD;

public AssociationCEN()
{
        this._IAssociationCAD = new AssociationCAD ();
}

public AssociationCEN(IAssociationCAD _IAssociationCAD)
{
        this._IAssociationCAD = _IAssociationCAD;
}

public IAssociationCAD get_IAssociationCAD ()
{
        return this._IAssociationCAD;
}

public int New_ (string p_name, int p_rolOrigin, int p_rolTarget, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum p_cardinalityOrigin, MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum p_cardinalityTarget, int p_entityOrigin, int p_entityTarget, int p_ioTScenario)
{
        AssociationEN associationEN = null;
        int oid;

        //Initialized AssociationEN
        associationEN = new AssociationEN ();
        associationEN.Name = p_name;


        if (p_rolOrigin != -1) {
                // El argumento p_rolOrigin -> Property rolOrigin es oid = false
                // Lista de oids id
                associationEN.RolOrigin = new MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN ();
                associationEN.RolOrigin.Id = p_rolOrigin;
        }


        if (p_rolTarget != -1) {
                // El argumento p_rolTarget -> Property rolTarget es oid = false
                // Lista de oids id
                associationEN.RolTarget = new MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN ();
                associationEN.RolTarget.Id = p_rolTarget;
        }

        associationEN.Type = p_type;

        associationEN.CardinalityOrigin = p_cardinalityOrigin;

        associationEN.CardinalityTarget = p_cardinalityTarget;


        if (p_entityOrigin != -1) {
                // El argumento p_entityOrigin -> Property entityOrigin es oid = false
                // Lista de oids id
                associationEN.EntityOrigin = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                associationEN.EntityOrigin.Id = p_entityOrigin;
        }


        if (p_entityTarget != -1) {
                // El argumento p_entityTarget -> Property entityTarget es oid = false
                // Lista de oids id
                associationEN.EntityTarget = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                associationEN.EntityTarget.Id = p_entityTarget;
        }


        if (p_ioTScenario != -1) {
                // El argumento p_ioTScenario -> Property ioTScenario es oid = false
                // Lista de oids id
                associationEN.IoTScenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                associationEN.IoTScenario.Id = p_ioTScenario;
        }

        //Call to AssociationCAD

        oid = _IAssociationCAD.New_ (associationEN);
        return oid;
}

public void Modify (int p_Association_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.AssociationTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum p_cardinalityOrigin, MoSIoTGenNHibernate.Enumerated.MosIoT.CardinalityTypeEnum p_cardinalityTarget)
{
        AssociationEN associationEN = null;

        //Initialized AssociationEN
        associationEN = new AssociationEN ();
        associationEN.Id = p_Association_OID;
        associationEN.Name = p_name;
        associationEN.Type = p_type;
        associationEN.CardinalityOrigin = p_cardinalityOrigin;
        associationEN.CardinalityTarget = p_cardinalityTarget;
        //Call to AssociationCAD

        _IAssociationCAD.Modify (associationEN);
}

public void Destroy (int id
                     )
{
        _IAssociationCAD.Destroy (id);
}

public AssociationEN ReadOID (int id
                              )
{
        AssociationEN associationEN = null;

        associationEN = _IAssociationCAD.ReadOID (id);
        return associationEN;
}

public System.Collections.Generic.IList<AssociationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AssociationEN> list = null;

        list = _IAssociationCAD.ReadAll (first, size);
        return list;
}
}
}
