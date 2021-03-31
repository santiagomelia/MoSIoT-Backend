
using System;
// Definición clase MedicationEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class MedicationEN
{
/**
 *	Atributo careActivity
 */
private MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity;



/**
 *	Atributo productReference
 */
private int productReference;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo manufacturer
 */
private string manufacturer;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo dosage
 */
private string dosage;



/**
 *	Atributo form
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.FormTypeEnum form;



/**
 *	Atributo medicationCode
 */
private string medicationCode;






public virtual MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN CareActivity {
        get { return careActivity; } set { careActivity = value;  }
}



public virtual int ProductReference {
        get { return productReference; } set { productReference = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Manufacturer {
        get { return manufacturer; } set { manufacturer = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual string Dosage {
        get { return dosage; } set { dosage = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.FormTypeEnum Form {
        get { return form; } set { form = value;  }
}



public virtual string MedicationCode {
        get { return medicationCode; } set { medicationCode = value;  }
}





public MedicationEN()
{
}



public MedicationEN(int productReference, MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity, string name, string manufacturer, string description, string dosage, MoSIoTGenNHibernate.Enumerated.MosIoT.FormTypeEnum form, string medicationCode
                    )
{
        this.init (ProductReference, careActivity, name, manufacturer, description, dosage, form, medicationCode);
}


public MedicationEN(MedicationEN medication)
{
        this.init (ProductReference, medication.CareActivity, medication.Name, medication.Manufacturer, medication.Description, medication.Dosage, medication.Form, medication.MedicationCode);
}

private void init (int productReference
                   , MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN careActivity, string name, string manufacturer, string description, string dosage, MoSIoTGenNHibernate.Enumerated.MosIoT.FormTypeEnum form, string medicationCode)
{
        this.ProductReference = productReference;


        this.CareActivity = careActivity;

        this.Name = name;

        this.Manufacturer = manufacturer;

        this.Description = description;

        this.Dosage = dosage;

        this.Form = form;

        this.MedicationCode = medicationCode;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MedicationEN t = obj as MedicationEN;
        if (t == null)
                return false;
        if (ProductReference.Equals (t.ProductReference))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.ProductReference.GetHashCode ();
        return hash;
}
}
}
