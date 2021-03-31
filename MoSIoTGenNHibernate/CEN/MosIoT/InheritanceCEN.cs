

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
 *      Definition of the class InheritanceCEN
 *
 */
public partial class InheritanceCEN
{
private IInheritanceCAD _IInheritanceCAD;

public InheritanceCEN()
{
        this._IInheritanceCAD = new InheritanceCAD ();
}

public InheritanceCEN(IInheritanceCAD _IInheritanceCAD)
{
        this._IInheritanceCAD = _IInheritanceCAD;
}

public IInheritanceCAD get_IInheritanceCAD ()
{
        return this._IInheritanceCAD;
}

public int New_ (int p_son)
{
        InheritanceEN inheritanceEN = null;
        int oid;

        //Initialized InheritanceEN
        inheritanceEN = new InheritanceEN ();

        if (p_son != -1) {
                // El argumento p_son -> Property son es oid = false
                // Lista de oids id
                inheritanceEN.Son = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                inheritanceEN.Son.Id = p_son;
        }

        //Call to InheritanceCAD

        oid = _IInheritanceCAD.New_ (inheritanceEN);
        return oid;
}

public void Modify (int p_Inheritance_OID)
{
        InheritanceEN inheritanceEN = null;

        //Initialized InheritanceEN
        inheritanceEN = new InheritanceEN ();
        inheritanceEN.Id = p_Inheritance_OID;
        //Call to InheritanceCAD

        _IInheritanceCAD.Modify (inheritanceEN);
}

public void Destroy (int id
                     )
{
        _IInheritanceCAD.Destroy (id);
}

public InheritanceEN ReadOID (int id
                              )
{
        InheritanceEN inheritanceEN = null;

        inheritanceEN = _IInheritanceCAD.ReadOID (id);
        return inheritanceEN;
}

public System.Collections.Generic.IList<InheritanceEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<InheritanceEN> list = null;

        list = _IInheritanceCAD.ReadAll (first, size);
        return list;
}
}
}
