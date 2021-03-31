
using System;
// Definición clase StateDeviceEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class StateDeviceEN
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
 *	Atributo value
 */
private string value;



/**
 *	Atributo stateTelemetry
 */
private MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN stateTelemetry;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Value {
        get { return value; } set { value = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN StateTelemetry {
        get { return stateTelemetry; } set { stateTelemetry = value;  }
}





public StateDeviceEN()
{
}



public StateDeviceEN(int id, string name, string value, MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN stateTelemetry
                     )
{
        this.init (Id, name, value, stateTelemetry);
}


public StateDeviceEN(StateDeviceEN stateDevice)
{
        this.init (Id, stateDevice.Name, stateDevice.Value, stateDevice.StateTelemetry);
}

private void init (int id
                   , string name, string value, MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN stateTelemetry)
{
        this.Id = id;


        this.Name = name;

        this.Value = value;

        this.StateTelemetry = stateTelemetry;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        StateDeviceEN t = obj as StateDeviceEN;
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
