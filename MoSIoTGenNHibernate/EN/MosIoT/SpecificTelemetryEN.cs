
using System;
// Definición clase SpecificTelemetryEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class SpecificTelemetryEN
{
/**
 *	Atributo telemetry
 */
private MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo name
 */
private string name;






public virtual MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN Telemetry {
        get { return telemetry; } set { telemetry = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}





public SpecificTelemetryEN()
{
}



public SpecificTelemetryEN(int id, MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name
                           )
{
        this.init (Id, telemetry, name);
}


public SpecificTelemetryEN(SpecificTelemetryEN specificTelemetry)
{
        this.init (Id, specificTelemetry.Telemetry, specificTelemetry.Name);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN telemetry, string name)
{
        this.Id = id;


        this.Telemetry = telemetry;

        this.Name = name;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        SpecificTelemetryEN t = obj as SpecificTelemetryEN;
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
