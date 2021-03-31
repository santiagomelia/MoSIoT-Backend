
using System;
// Definición clase AdaptationRequestEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class AdaptationRequestEN
{
/**
 *	Atributo accessModeTarget
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum accessModeTarget;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo accessMode
 */
private MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode;



/**
 *	Atributo languageOfAdaptation
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum languageOfAdaptation;



/**
 *	Atributo description
 */
private string description;






public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum AccessModeTarget {
        get { return accessModeTarget; } set { accessModeTarget = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN AccessMode {
        get { return accessMode; } set { accessMode = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum LanguageOfAdaptation {
        get { return languageOfAdaptation; } set { languageOfAdaptation = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}





public AdaptationRequestEN()
{
}



public AdaptationRequestEN(int id, MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum accessModeTarget, MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum languageOfAdaptation, string description
                           )
{
        this.init (Id, accessModeTarget, accessMode, languageOfAdaptation, description);
}


public AdaptationRequestEN(AdaptationRequestEN adaptationRequest)
{
        this.init (Id, adaptationRequest.AccessModeTarget, adaptationRequest.AccessMode, adaptationRequest.LanguageOfAdaptation, adaptationRequest.Description);
}

private void init (int id
                   , MoSIoTGenNHibernate.Enumerated.MosIoT.AccessModeValueEnum accessModeTarget, MoSIoTGenNHibernate.EN.MosIoT.AccessModeEN accessMode, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum languageOfAdaptation, string description)
{
        this.Id = id;


        this.AccessModeTarget = accessModeTarget;

        this.AccessMode = accessMode;

        this.LanguageOfAdaptation = languageOfAdaptation;

        this.Description = description;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdaptationRequestEN t = obj as AdaptationRequestEN;
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
