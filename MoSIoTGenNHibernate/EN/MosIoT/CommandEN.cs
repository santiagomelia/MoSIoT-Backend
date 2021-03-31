
using System;
// Definición clase CommandEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class CommandEN
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
 *	Atributo isSynchronous
 */
private bool isSynchronous;



/**
 *	Atributo telemetries
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN> telemetries;



/**
 *	Atributo type
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum type;



/**
 *	Atributo description
 */
private string description;






public virtual MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN DeviceTemplate {
        get { return deviceTemplate; } set { deviceTemplate = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual bool IsSynchronous {
        get { return isSynchronous; } set { isSynchronous = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN> Telemetries {
        get { return telemetries; } set { telemetries = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}





public CommandEN()
{
        telemetries = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN>();
}



public CommandEN(int id, MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate, string name, bool isSynchronous, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN> telemetries, MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum type, string description
                 )
{
        this.init (Id, deviceTemplate, name, isSynchronous, telemetries, type, description);
}


public CommandEN(CommandEN command)
{
        this.init (Id, command.DeviceTemplate, command.Name, command.IsSynchronous, command.Telemetries, command.Type, command.Description);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate, string name, bool isSynchronous, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EventTelemetryEN> telemetries, MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum type, string description)
{
        this.Id = id;


        this.DeviceTemplate = deviceTemplate;

        this.Name = name;

        this.IsSynchronous = isSynchronous;

        this.Telemetries = telemetries;

        this.Type = type;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CommandEN t = obj as CommandEN;
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
