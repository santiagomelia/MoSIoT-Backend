
using System;
// Definición clase TelemetryEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class TelemetryEN
{
/**
 *	Atributo deviceTemplate
 */
private MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate;



/**
 *	Atributo frecuency
 */
private double frecuency;



/**
 *	Atributo typeTelemetry
 */
private MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN typeTelemetry;



/**
 *	Atributo schema
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum schema;



/**
 *	Atributo unit
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum unit;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo type
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum type;



/**
 *	Atributo properties
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN> properties;



/**
 *	Atributo vitalSign
 */
private MoSIoTGenNHibernate.EN.MosIoT.MeasureEN vitalSign;



/**
 *	Atributo iMTelemetry
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN> iMTelemetry;






public virtual MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN DeviceTemplate {
        get { return deviceTemplate; } set { deviceTemplate = value;  }
}



public virtual double Frecuency {
        get { return frecuency; } set { frecuency = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN TypeTelemetry {
        get { return typeTelemetry; } set { typeTelemetry = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Schema {
        get { return schema; } set { schema = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum Unit {
        get { return unit; } set { unit = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN> Properties {
        get { return properties; } set { properties = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.MeasureEN VitalSign {
        get { return vitalSign; } set { vitalSign = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN> IMTelemetry {
        get { return iMTelemetry; } set { iMTelemetry = value;  }
}





public TelemetryEN()
{
        properties = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN>();
        iMTelemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN>();
}



public TelemetryEN(int id, MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate, double frecuency, MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN typeTelemetry, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum schema, MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum unit, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum type, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN> properties, MoSIoTGenNHibernate.EN.MosIoT.MeasureEN vitalSign, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN> iMTelemetry
                   )
{
        this.init (Id, deviceTemplate, frecuency, typeTelemetry, schema, unit, name, type, properties, vitalSign, iMTelemetry);
}


public TelemetryEN(TelemetryEN telemetry)
{
        this.init (Id, telemetry.DeviceTemplate, telemetry.Frecuency, telemetry.TypeTelemetry, telemetry.Schema, telemetry.Unit, telemetry.Name, telemetry.Type, telemetry.Properties, telemetry.VitalSign, telemetry.IMTelemetry);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate, double frecuency, MoSIoTGenNHibernate.EN.MosIoT.SpecificTelemetryEN typeTelemetry, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum schema, MoSIoTGenNHibernate.Enumerated.MosIoT.TypeUnitEnum unit, string name, MoSIoTGenNHibernate.Enumerated.MosIoT.TelemetryTypeEnum type, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN> properties, MoSIoTGenNHibernate.EN.MosIoT.MeasureEN vitalSign, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN> iMTelemetry)
{
        this.Id = id;


        this.DeviceTemplate = deviceTemplate;

        this.Frecuency = frecuency;

        this.TypeTelemetry = typeTelemetry;

        this.Schema = schema;

        this.Unit = unit;

        this.Name = name;

        this.Type = type;

        this.Properties = properties;

        this.VitalSign = vitalSign;

        this.IMTelemetry = iMTelemetry;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TelemetryEN t = obj as TelemetryEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
