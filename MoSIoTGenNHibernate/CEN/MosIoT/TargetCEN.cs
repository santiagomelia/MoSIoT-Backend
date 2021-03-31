

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
 *      Definition of the class TargetCEN
 *
 */
public partial class TargetCEN
{
private ITargetCAD _ITargetCAD;

public TargetCEN()
{
        this._ITargetCAD = new TargetCAD ();
}

public TargetCEN(ITargetCAD _ITargetCAD)
{
        this._ITargetCAD = _ITargetCAD;
}

public ITargetCAD get_ITargetCAD ()
{
        return this._ITargetCAD;
}

public int New_ (int p_goal, string p_desiredValue, string p_description, Nullable<DateTime> p_dueDate)
{
        TargetEN targetEN = null;
        int oid;

        //Initialized TargetEN
        targetEN = new TargetEN ();

        if (p_goal != -1) {
                // El argumento p_goal -> Property goal es oid = false
                // Lista de oids id
                targetEN.Goal = new MoSIoTGenNHibernate.EN.MosIoT.GoalEN ();
                targetEN.Goal.Id = p_goal;
        }

        targetEN.DesiredValue = p_desiredValue;

        targetEN.Description = p_description;

        targetEN.DueDate = p_dueDate;

        //Call to TargetCAD

        oid = _ITargetCAD.New_ (targetEN);
        return oid;
}

public void Modify (int p_Target_OID, string p_desiredValue, string p_description, Nullable<DateTime> p_dueDate)
{
        TargetEN targetEN = null;

        //Initialized TargetEN
        targetEN = new TargetEN ();
        targetEN.Id = p_Target_OID;
        targetEN.DesiredValue = p_desiredValue;
        targetEN.Description = p_description;
        targetEN.DueDate = p_dueDate;
        //Call to TargetCAD

        _ITargetCAD.Modify (targetEN);
}

public void Destroy (int id
                     )
{
        _ITargetCAD.Destroy (id);
}

public TargetEN ReadOID (int id
                         )
{
        TargetEN targetEN = null;

        targetEN = _ITargetCAD.ReadOID (id);
        return targetEN;
}

public System.Collections.Generic.IList<TargetEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<TargetEN> list = null;

        list = _ITargetCAD.ReadAll (first, size);
        return list;
}
}
}
