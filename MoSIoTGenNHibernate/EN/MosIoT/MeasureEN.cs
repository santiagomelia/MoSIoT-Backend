
using System;
// Definición clase MeasureEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class MeasureEN
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
 *	Atributo description
 */
private string description;



/**
 *	Atributo target
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TargetEN> target;



/**
 *	Atributo telemetry
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> telemetry;



/**
 *	Atributo lOINCcode
 */
private string lOINCcode;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TargetEN> Target {
        get { return target; } set { target = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> Telemetry {
        get { return telemetry; } set { telemetry = value;  }
}



public virtual string LOINCcode {
        get { return lOINCcode; } set { lOINCcode = value;  }
}





public MeasureEN()
{
        target = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TargetEN>();
        telemetry = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN>();
}



public MeasureEN(int id, string name, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TargetEN> target, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> telemetry, string lOINCcode
                 )
{
        this.init (Id, name, description, target, telemetry, lOINCcode);
}


public MeasureEN(MeasureEN measure)
{
        this.init (Id, measure.Name, measure.Description, measure.Target, measure.Telemetry, measure.LOINCcode);
}

private void init (int id
                   , string name, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TargetEN> target, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.TelemetryEN> telemetry, string lOINCcode)
{
        this.Id = id;


        this.Name = name;

        this.Description = description;

        this.Target = target;

        this.Telemetry = telemetry;

        this.LOINCcode = lOINCcode;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MeasureEN t = obj as MeasureEN;
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
