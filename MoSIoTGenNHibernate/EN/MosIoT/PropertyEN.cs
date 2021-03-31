
using System;
// Definición clase PropertyEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class PropertyEN
{
/**
 *	Atributo deviceTemplate
 */
private MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo isWritable
 */
private bool isWritable;



/**
 *	Atributo isCloudable
 */
private bool isCloudable;



/**
 *	Atributo telemetry
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> telemetry;






public virtual MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN DeviceTemplate {
        get { return deviceTemplate; } set { deviceTemplate = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual bool IsWritable {
        get { return isWritable; } set { isWritable = value;  }
}



public virtual bool IsCloudable {
        get { return isCloudable; } set { isCloudable = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> Telemetry {
        get { return telemetry; } set { telemetry = value;  }
}





public PropertyEN()
{
        telemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN>();
}



public PropertyEN(int id, MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate, string name, bool isWritable, bool isCloudable, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> telemetry
                  )
{
        this.init (Id, deviceTemplate, name, isWritable, isCloudable, telemetry);
}


public PropertyEN(PropertyEN property)
{
        this.init (Id, property.DeviceTemplate, property.Name, property.IsWritable, property.IsCloudable, property.Telemetry);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate, string name, bool isWritable, bool isCloudable, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> telemetry)
{
        this.Id = id;


        this.DeviceTemplate = deviceTemplate;

        this.Name = name;

        this.IsWritable = isWritable;

        this.IsCloudable = isCloudable;

        this.Telemetry = telemetry;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PropertyEN t = obj as PropertyEN;
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
