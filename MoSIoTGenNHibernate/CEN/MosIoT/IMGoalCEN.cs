

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
 *      Definition of the class IMGoalCEN
 *
 */
public partial class IMGoalCEN
{
private IIMGoalCAD _IIMGoalCAD;

public IMGoalCEN()
{
        this._IIMGoalCAD = new IMGoalCAD ();
}

public IMGoalCEN(IIMGoalCAD _IIMGoalCAD)
{
        this._IIMGoalCAD = _IIMGoalCAD;
}

public IIMGoalCAD get_IIMGoalCAD ()
{
        return this._IIMGoalCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, int p_entity, string p_value, int p_goal)
{
        IMGoalEN iMGoalEN = null;
        int oid;

        //Initialized IMGoalEN
        iMGoalEN = new IMGoalEN ();
        iMGoalEN.Name = p_name;

        iMGoalEN.Type = p_type;

        iMGoalEN.IsOID = p_isOID;

        iMGoalEN.IsWritable = p_isWritable;

        iMGoalEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMGoalEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMGoalEN.Entity.Id = p_entity;
        }

        iMGoalEN.Value = p_value;


        if (p_goal != -1) {
                // El argumento p_goal -> Property goal es oid = false
                // Lista de oids id
                iMGoalEN.Goal = new MoSIoTGenNHibernate.EN.MosIoT.GoalEN ();
                iMGoalEN.Goal.Id = p_goal;
        }

        //Call to IMGoalCAD

        oid = _IIMGoalCAD.New_ (iMGoalEN);
        return oid;
}

public void Modify (int p_IMGoal_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, string p_value)
{
        IMGoalEN iMGoalEN = null;

        //Initialized IMGoalEN
        iMGoalEN = new IMGoalEN ();
        iMGoalEN.Id = p_IMGoal_OID;
        iMGoalEN.Name = p_name;
        iMGoalEN.Type = p_type;
        iMGoalEN.IsOID = p_isOID;
        iMGoalEN.IsWritable = p_isWritable;
        iMGoalEN.Description = p_description;
        iMGoalEN.Value = p_value;
        //Call to IMGoalCAD

        _IIMGoalCAD.Modify (iMGoalEN);
}

public void Destroy (int id
                     )
{
        _IIMGoalCAD.Destroy (id);
}

public IMGoalEN ReadOID (int id
                         )
{
        IMGoalEN iMGoalEN = null;

        iMGoalEN = _IIMGoalCAD.ReadOID (id);
        return iMGoalEN;
}

public System.Collections.Generic.IList<IMGoalEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMGoalEN> list = null;

        list = _IIMGoalCAD.ReadAll (first, size);
        return list;
}
}
}
