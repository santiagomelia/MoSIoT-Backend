
using System;
// Definición clase AdaptationDetailRequiredEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class AdaptationDetailRequiredEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo adaptationRequest
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum adaptationRequest;



/**
 *	Atributo accessMode
 */
private MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode;



/**
 *	Atributo description
 */
private string description;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum AdaptationRequest {
        get { return adaptationRequest; } set { adaptationRequest = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN AccessMode {
        get { return accessMode; } set { accessMode = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}





public AdaptationDetailRequiredEN()
{
}



public AdaptationDetailRequiredEN(int id, MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum adaptationRequest, MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode, string description
                                  )
{
        this.init (Id, adaptationRequest, accessMode, description);
}


public AdaptationDetailRequiredEN(AdaptationDetailRequiredEN adaptationDetailRequired)
{
        this.init (Id, adaptationDetailRequired.AdaptationRequest, adaptationDetailRequired.AccessMode, adaptationDetailRequired.Description);
}

private void init (int id
                   , MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationDetailValueEnum adaptationRequest, MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode, string description)
{
        this.Id = id;


        this.AdaptationRequest = adaptationRequest;

        this.AccessMode = accessMode;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdaptationDetailRequiredEN t = obj as AdaptationDetailRequiredEN;
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
