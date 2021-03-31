
using System;
// Definición clase RangeStateTelemetryEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RangeStateTelemetryEN
{
/**
 *	Atributo stateTelemetry
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN> stateTelemetry;



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






public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN> StateTelemetry {
        get { return stateTelemetry; } set { stateTelemetry = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Value {
        get { return value; } set { value = value;  }
}





public RangeStateTelemetryEN()
{
        stateTelemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN>();
}



public RangeStateTelemetryEN(int id, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN> stateTelemetry, string name, string value
                             )
{
        this.init (Id, stateTelemetry, name, value);
}


public RangeStateTelemetryEN(RangeStateTelemetryEN rangeStateTelemetry)
{
        this.init (Id, rangeStateTelemetry.StateTelemetry, rangeStateTelemetry.Name, rangeStateTelemetry.Value);
}

private void init (int id
                   , System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.StateTelemetryEN> stateTelemetry, string name, string value)
{
        this.Id = id;


        this.StateTelemetry = stateTelemetry;

        this.Name = name;

        this.Value = value;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RangeStateTelemetryEN t = obj as RangeStateTelemetryEN;
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
