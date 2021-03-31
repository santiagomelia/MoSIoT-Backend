

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
 *      Definition of the class MedicationCEN
 *
 */
public partial class MedicationCEN
{
private IMedicationCAD _IMedicationCAD;

public MedicationCEN()
{
        this._IMedicationCAD = new MedicationCAD ();
}

public MedicationCEN(IMedicationCAD _IMedicationCAD)
{
        this._IMedicationCAD = _IMedicationCAD;
}

public IMedicationCAD get_IMedicationCAD ()
{
        return this._IMedicationCAD;
}

public int New_ (int p_careActivity, int p_productReference, string p_name, string p_manufacturer, string p_description, string p_dosage, MoSIoTGenNHibernate.Enumerated.MosIoT.FormTypeEnum p_form, string p_medicationCode)
{
        MedicationEN medicationEN = null;
        int oid;

        //Initialized MedicationEN
        medicationEN = new MedicationEN ();

        if (p_careActivity != -1) {
                // El argumento p_careActivity -> Property careActivity es oid = false
                // Lista de oids productReference
                medicationEN.CareActivity = new MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN ();
                medicationEN.CareActivity.Id = p_careActivity;
        }

        medicationEN.ProductReference = p_productReference;

        medicationEN.Name = p_name;

        medicationEN.Manufacturer = p_manufacturer;

        medicationEN.Description = p_description;

        medicationEN.Dosage = p_dosage;

        medicationEN.Form = p_form;

        medicationEN.MedicationCode = p_medicationCode;

        //Call to MedicationCAD

        oid = _IMedicationCAD.New_ (medicationEN);
        return oid;
}

public void Modify (int p_Medication_OID, string p_name, string p_manufacturer, string p_description, string p_dosage, MoSIoTGenNHibernate.Enumerated.MosIoT.FormTypeEnum p_form, string p_medicationCode)
{
        MedicationEN medicationEN = null;

        //Initialized MedicationEN
        medicationEN = new MedicationEN ();
        medicationEN.ProductReference = p_Medication_OID;
        medicationEN.Name = p_name;
        medicationEN.Manufacturer = p_manufacturer;
        medicationEN.Description = p_description;
        medicationEN.Dosage = p_dosage;
        medicationEN.Form = p_form;
        medicationEN.MedicationCode = p_medicationCode;
        //Call to MedicationCAD

        _IMedicationCAD.Modify (medicationEN);
}

public void Destroy (int productReference
                     )
{
        _IMedicationCAD.Destroy (productReference);
}

public MedicationEN ReadOID (int productReference
                             )
{
        MedicationEN medicationEN = null;

        medicationEN = _IMedicationCAD.ReadOID (productReference);
        return medicationEN;
}

public System.Collections.Generic.IList<MedicationEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<MedicationEN> list = null;

        list = _IMedicationCAD.ReadAll (first, size);
        return list;
}
}
}
