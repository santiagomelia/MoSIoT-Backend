
using System;
// Definición clase IMTelemetryValuesEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class IMTelemetryValuesEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo timeStamp
 */
private Nullable<DateTime> timeStamp;



/**
 *	Atributo valu
 */
private string valu;



/**
 *	Atributo iMTelemetry
 */
private MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN iMTelemetry;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Nullable<DateTime> TimeStamp {
        get { return timeStamp; } set { timeStamp = value;  }
}



public virtual string Valu {
        get { return valu; } set { valu = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN IMTelemetry {
        get { return iMTelemetry; } set { iMTelemetry = value;  }
}





public IMTelemetryValuesEN()
{
}



public IMTelemetryValuesEN(int id, Nullable<DateTime> timeStamp, string valu, MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN iMTelemetry
                           )
{
        this.init (Id, timeStamp, valu, iMTelemetry);
}


public IMTelemetryValuesEN(IMTelemetryValuesEN iMTelemetryValues)
{
        this.init (Id, iMTelemetryValues.TimeStamp, iMTelemetryValues.Valu, iMTelemetryValues.IMTelemetry);
}

private void init (int id
                   , Nullable<DateTime> timeStamp, string valu, MoSIoTGenNHibernate.EN.MosIoT.IMTelemetryEN iMTelemetry)
{
        this.Id = id;


        this.TimeStamp = timeStamp;

        this.Valu = valu;

        this.IMTelemetry = iMTelemetry;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        IMTelemetryValuesEN t = obj as IMTelemetryValuesEN;
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
