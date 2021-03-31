
using System;
// Definición clase TrademarkEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class TrademarkEN
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
 *	Atributo device
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DeviceEN> device;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DeviceEN> Device {
        get { return device; } set { device = value;  }
}





public TrademarkEN()
{
        device = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.DeviceEN>();
}



public TrademarkEN(int id, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DeviceEN> device
                   )
{
        this.init (Id, name, device);
}


public TrademarkEN(TrademarkEN trademark)
{
        this.init (Id, trademark.Name, trademark.Device);
}

private void init (int id
                   , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.DeviceEN> device)
{
        this.Id = id;


        this.Name = name;

        this.Device = device;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        TrademarkEN t = obj as TrademarkEN;
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
