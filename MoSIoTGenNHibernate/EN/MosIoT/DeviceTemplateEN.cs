
using System;
// Definición clase DeviceTemplateEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class DeviceTemplateEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo name
 */
private string name;



/**
 *	Atributo property
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN> property;



/**
 *	Atributo command
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CommandEN> command;



/**
 *	Atributo telemetry
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> telemetry;



/**
 *	Atributo type
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum type;



/**
 *	Atributo isEdge
 */
private bool isEdge;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN> Property {
        get { return property; } set { property = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CommandEN> Command {
        get { return command; } set { command = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> Telemetry {
        get { return telemetry; } set { telemetry = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual bool IsEdge {
        get { return isEdge; } set { isEdge = value;  }
}





public DeviceTemplateEN()
{
        property = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN>();
        command = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.CommandEN>();
        telemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN>();
}



public DeviceTemplateEN(int id, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN> property, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CommandEN> command, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> telemetry, MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum type, bool isEdge
                        )
{
        this.init (Id, name, property, command, telemetry, type, isEdge);
}


public DeviceTemplateEN(DeviceTemplateEN deviceTemplate)
{
        this.init (Id, deviceTemplate.Name, deviceTemplate.Property, deviceTemplate.Command, deviceTemplate.Telemetry, deviceTemplate.Type, deviceTemplate.IsEdge);
}

private void init (int id
                   , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PropertyEN> property, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.CommandEN> command, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> telemetry, MoSIoTGenNHibernate.Enumerated.MosIoT.DeviceTypeEnum type, bool isEdge)
{
        this.Id = id;


        this.Name = name;

        this.Property = property;

        this.Command = command;

        this.Telemetry = telemetry;

        this.Type = type;

        this.IsEdge = isEdge;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DeviceTemplateEN t = obj as DeviceTemplateEN;
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
