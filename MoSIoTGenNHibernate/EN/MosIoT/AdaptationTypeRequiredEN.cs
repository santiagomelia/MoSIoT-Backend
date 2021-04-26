
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



/**
 *	Atributo iMAdaptationType
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.IMAdaptationTypeEN> iMAdaptationType;






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



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.IMAdaptationTypeEN> IMAdaptationType {
        get { return iMAdaptationType; } set { iMAdaptationType = value;  }
}





public AdaptationTypeRequiredEN()
{
        iMAdaptationType = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.IMAdaptationTypeEN>();
}



public AdaptationTypeRequiredEN(int id, MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum adaptionRequest, string description, MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.IMAdaptationTypeEN> iMAdaptationType
                                )
{
        this.init (Id, adaptionRequest, description, accessMode, iMAdaptationType);
}


public AdaptationTypeRequiredEN(AdaptationTypeRequiredEN adaptationTypeRequired)
{
        this.init (Id, adaptationTypeRequired.AdaptionRequest, adaptationTypeRequired.Description, adaptationTypeRequired.AccessMode, adaptationTypeRequired.IMAdaptationType);
}

private void init (int id
                   , MoSIoTGenNHibernate.Enumerated.MosIoT.AdaptationTypeValueEnum adaptionRequest, string description, MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.IMAdaptationTypeEN> iMAdaptationType)
{
        this.Id = id;


        this.AdaptionRequest = adaptionRequest;

        this.Description = description;

        this.AccessMode = accessMode;

        this.IMAdaptationType = iMAdaptationType;
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
