

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

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, int p_entity, string p_value, int p_nutritionOrder)
{
        IMNutritionOrderEN iMNutritionOrderEN = null;
        int oid;

        //Initialized IMNutritionOrderEN
        iMNutritionOrderEN = new IMNutritionOrderEN ();
        iMNutritionOrderEN.Name = p_name;

        iMNutritionOrderEN.Type = p_type;

        iMNutritionOrderEN.IsOID = p_isOID;

        iMNutritionOrderEN.IsWritable = p_isWritable;

        iMNutritionOrderEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                iMNutritionOrderEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                iMNutritionOrderEN.Entity.Id = p_entity;
        }

        iMNutritionOrderEN.Value = p_value;


        if (p_nutritionOrder != -1) {
                // El argumento p_nutritionOrder -> Property nutritionOrder es oid = false
                // Lista de oids id
                iMNutritionOrderEN.NutritionOrder = new MoSIoTGenNHibernate.EN.MosIoT.NutritionOrderEN ();
                iMNutritionOrderEN.NutritionOrder.Id = p_nutritionOrder;
        }

        //Call to IMNutritionOrderCAD

        oid = _IIMNutritionOrderCAD.New_ (iMNutritionOrderEN);
        return oid;
}

public void Modify (int p_IMNutritionOrder_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, bool p_isOID, bool p_isWritable, string p_description, string p_value)
{
        IMNutritionOrderEN iMNutritionOrderEN = null;

        //Initialized IMNutritionOrderEN
        iMNutritionOrderEN = new IMNutritionOrderEN ();
        iMNutritionOrderEN.Id = p_IMNutritionOrder_OID;
        iMNutritionOrderEN.Name = p_name;
        iMNutritionOrderEN.Type = p_type;
        iMNutritionOrderEN.IsOID = p_isOID;
        iMNutritionOrderEN.IsWritable = p_isWritable;
        iMNutritionOrderEN.Description = p_description;
        iMNutritionOrderEN.Value = p_value;
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
}
}
