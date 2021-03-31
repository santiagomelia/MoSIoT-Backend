
using System;
// Definición clase HealthDataEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class HealthDataEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo description
 */
private string description;



/**
 *	Atributo language
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum language;



/**
 *	Atributo system
 */
private string system;



/**
 *	Atributo code
 */
private string code;



/**
 *	Atributo display
 */
private string display;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum Language {
        get { return language; } set { language = value;  }
}



public virtual string System {
        get { return system; } set { system = value;  }
}



public virtual string Code {
        get { return code; } set { code = value;  }
}



public virtual string Display {
        get { return display; } set { display = value;  }
}





public HealthDataEN()
{
}



public HealthDataEN(int id, string description, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum language, string system, string code, string display
                    )
{
        this.init (Id, description, language, system, code, display);
}


public HealthDataEN(HealthDataEN healthData)
{
        this.init (Id, healthData.Description, healthData.Language, healthData.System, healthData.Code, healthData.Display);
}

private void init (int id
                   , string description, MoSIoTGenNHibernate.Enumerated.MosIoT.LanguageCodeEnum language, string system, string code, string display)
{
        this.Id = id;


        this.Description = description;

        this.Language = language;

        this.System = system;

        this.Code = code;

        this.Display = display;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        HealthDataEN t = obj as HealthDataEN;
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
