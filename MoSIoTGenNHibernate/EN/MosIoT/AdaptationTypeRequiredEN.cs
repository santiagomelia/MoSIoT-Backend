
using System;
// Definición clase AdaptationTypeRequiredEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class AdaptationTypeRequiredEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo adaptionRequest
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum adaptionRequest;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo accessMode
 */
private MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum AdaptionRequest {
        get { return adaptionRequest; } set { adaptionRequest = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN AccessMode {
        get { return accessMode; } set { accessMode = value;  }
}





public AdaptationTypeRequiredEN()
{
}



public AdaptationTypeRequiredEN(int id, MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum adaptionRequest, string description, MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode
                                )
{
        this.init (Id, adaptionRequest, description, accessMode);
}


public AdaptationTypeRequiredEN(AdaptationTypeRequiredEN adaptationTypeRequired)
{
        this.init (Id, adaptationTypeRequired.AdaptionRequest, adaptationTypeRequired.Description, adaptationTypeRequired.AccessMode);
}

private void init (int id
                   , MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum adaptionRequest, string description, MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode)
{
        this.Id = id;


        this.AdaptionRequest = adaptionRequest;

        this.Description = description;

        this.AccessMode = accessMode;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdaptationTypeRequiredEN t = obj as AdaptationTypeRequiredEN;
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
