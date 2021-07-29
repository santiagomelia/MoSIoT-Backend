

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
 *      Definition of the class IMNutritionOrderCEN
 *
 */
public partial class IMNutritionOrderCEN
{
private IIMNutritionOrderCAD _IIMNutritionOrderCAD;

public IMNutritionOrderCEN()
{
        this._IIMNutritionOrderCAD = new IMNutritionOrderCAD ();
}

public IMNutritionOrderCEN(IIMNutritionOrderCAD _IIMNutritionOrderCAD)
{
        this._IIMNutritionOrderCAD = _IIMNutritionOrderCAD;
}

public IIMNutritionOrderCAD get_IIMNutritionOrderCAD ()
{
        return this._IIMNutritionOrderCAD;
}

public int New_ (string p_name, string p_description, int p_entity)
{
        IMNutritionOrderEN iMNutritionOrderEN = null;
        int oid;

        //Initialized IMNutritionOrderEN
        iMNutritionOrderEN = new IMNutritionOrderEN ();
        iMNutritionOrderEN.Name = p_name;

        iMNutritionOrderEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMNutritionOrderEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMNutritionOrderEN.Entity.Id = p_entity;
        }

        //Call to IMNutritionOrderCAD

        oid = _IIMNutritionOrderCAD.New_ (iMNutritionOrderEN);
        return oid;
}

public void Modify (int p_IMNutritionOrder_OID, string p_name, string p_description)
{
        IMNutritionOrderEN iMNutritionOrderEN = null;

        //Initialized IMNutritionOrderEN
        iMNutritionOrderEN = new IMNutritionOrderEN ();
        iMNutritionOrderEN.Id = p_IMNutritionOrder_OID;
        iMNutritionOrderEN.Name = p_name;
        iMNutritionOrderEN.Description = p_description;
        //Call to IMNutritionOrderCAD

        _IIMNutritionOrderCAD.Modify (iMNutritionOrderEN);
}

public void Destroy (int id
                     )
{
        _IIMNutritionOrderCAD.Destroy (id);
}

public IMNutritionOrderEN ReadOID (int id
                                   )
{
        IMNutritionOrderEN iMNutritionOrderEN = null;

        iMNutritionOrderEN = _IIMNutritionOrderCAD.ReadOID (id);
        return iMNutritionOrderEN;
}

public System.Collections.Generic.IList<IMNutritionOrderEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMNutritionOrderEN> list = null;

        list = _IIMNutritionOrderCAD.ReadAll (first, size);
        return list;
}
public void AssignNutrition (int p_IMNutritionOrder_OID, int p_nutritionOrder_OID)
{
        //Call to IMNutritionOrderCAD

        _IIMNutritionOrderCAD.AssignNutrition (p_IMNutritionOrder_OID, p_nutritionOrder_OID);
}
}
}
