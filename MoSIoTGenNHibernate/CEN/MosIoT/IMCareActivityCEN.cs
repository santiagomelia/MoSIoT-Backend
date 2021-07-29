

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
 *      Definition of the class IMCareActivityCEN
 *
 */
public partial class IMCareActivityCEN
{
private IIMCareActivityCAD _IIMCareActivityCAD;

public IMCareActivityCEN()
{
        this._IIMCareActivityCAD = new IMCareActivityCAD ();
}

public IMCareActivityCEN(IIMCareActivityCAD _IIMCareActivityCAD)
{
        this._IIMCareActivityCAD = _IIMCareActivityCAD;
}

public IIMCareActivityCAD get_IIMCareActivityCAD ()
{
        return this._IIMCareActivityCAD;
}

public int New_ (string p_name, int p_scenario, string p_description)
{
        IMCareActivityEN iMCareActivityEN = null;
        int oid;

        //Initialized IMCareActivityEN
        iMCareActivityEN = new IMCareActivityEN ();
        iMCareActivityEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                iMCareActivityEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                iMCareActivityEN.Scenario.Id = p_scenario;
        }

        iMCareActivityEN.Description = p_description;

        //Call to IMCareActivityCAD

        oid = _IIMCareActivityCAD.New_ (iMCareActivityEN);
        return oid;
}

public void Modify (int p_IMCareActivity_OID, string p_name, string p_description)
{
        IMCareActivityEN iMCareActivityEN = null;

        //Initialized IMCareActivityEN
        iMCareActivityEN = new IMCareActivityEN ();
        iMCareActivityEN.Id = p_IMCareActivity_OID;
        iMCareActivityEN.Name = p_name;
        iMCareActivityEN.Description = p_description;
        //Call to IMCareActivityCAD

        _IIMCareActivityCAD.Modify (iMCareActivityEN);
}

public void Destroy (int id
                     )
{
        _IIMCareActivityCAD.Destroy (id);
}

public IMCareActivityEN ReadOID (int id
                                 )
{
        IMCareActivityEN iMCareActivityEN = null;

        iMCareActivityEN = _IIMCareActivityCAD.ReadOID (id);
        return iMCareActivityEN;
}

public System.Collections.Generic.IList<IMCareActivityEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMCareActivityEN> list = null;

        list = _IIMCareActivityCAD.ReadAll (first, size);
        return list;
}
public void AssignCareActivity (int p_IMCareActivity_OID, int p_careActivity_OID)
{
        //Call to IMCareActivityCAD

        _IIMCareActivityCAD.AssignCareActivity (p_IMCareActivity_OID, p_careActivity_OID);
}
}
}
