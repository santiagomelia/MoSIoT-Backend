

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
 *      Definition of the class NutritionOrderCEN
 *
 */
public partial class NutritionOrderCEN
{
private INutritionOrderCAD _INutritionOrderCAD;

public NutritionOrderCEN()
{
        this._INutritionOrderCAD = new NutritionOrderCAD ();
}

public NutritionOrderCEN(INutritionOrderCAD _INutritionOrderCAD)
{
        this._INutritionOrderCAD = _INutritionOrderCAD;
}

public INutritionOrderCAD get_INutritionOrderCAD ()
{
        return this._INutritionOrderCAD;
}

public int New_ (string p_description, string p_dietCode, int p_careActivity, string p_name)
{
        NutritionOrderEN nutritionOrderEN = null;
        int oid;

        //Initialized NutritionOrderEN
        nutritionOrderEN = new NutritionOrderEN ();
        nutritionOrderEN.Description = p_description;

        nutritionOrderEN.DietCode = p_dietCode;


        if (p_careActivity != -1) {
                // El argumento p_careActivity -> Property careActivity es oid = false
                // Lista de oids id
                nutritionOrderEN.CareActivity = new MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN ();
                nutritionOrderEN.CareActivity.Id = p_careActivity;
        }

        nutritionOrderEN.Name = p_name;

        //Call to NutritionOrderCAD

        oid = _INutritionOrderCAD.New_ (nutritionOrderEN);
        return oid;
}

public void Modify (int p_NutritionOrder_OID, string p_description, string p_dietCode, string p_name)
{
        NutritionOrderEN nutritionOrderEN = null;

        //Initialized NutritionOrderEN
        nutritionOrderEN = new NutritionOrderEN ();
        nutritionOrderEN.Id = p_NutritionOrder_OID;
        nutritionOrderEN.Description = p_description;
        nutritionOrderEN.DietCode = p_dietCode;
        nutritionOrderEN.Name = p_name;
        //Call to NutritionOrderCAD

        _INutritionOrderCAD.Modify (nutritionOrderEN);
}

public void Destroy (int id
                     )
{
        _INutritionOrderCAD.Destroy (id);
}

public NutritionOrderEN ReadOID (int id
                                 )
{
        NutritionOrderEN nutritionOrderEN = null;

        nutritionOrderEN = _INutritionOrderCAD.ReadOID (id);
        return nutritionOrderEN;
}

public System.Collections.Generic.IList<NutritionOrderEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<NutritionOrderEN> list = null;

        list = _INutritionOrderCAD.ReadAll (first, size);
        return list;
}
}
}
