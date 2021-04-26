
using System;
// Definición clase UserEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class UserEN
{
/**
 *	Atributo birthDate
 */
private Nullable<DateTime> birthDate;



/**
 *	Atributo address
 */
private string address;



/**
 *	Atributo surnames
 */
private string surnames;



/**
 *	Atributo phone
 */
private string phone;



/**
 *	Atributo photo
 */
private string photo;



/**
 *	Atributo isActive
 */
private bool isActive;



/**
 *	Atributo type
 */
private MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum type;



/**
 *	Atributo isDiseased
 */
private bool isDiseased;



/**
 *	Atributo pass
 */
private String pass;



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
 *	Atributo email
 */
private string email;



/**
 *	Atributo relatedPerson
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RelatedPersonEN> relatedPerson;



/**
 *	Atributo practitioner
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PractitionerEN> practitioner;



/**
 *	Atributo patient
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PatientEN> patient;



/**
 *	Atributo notifications
 */
private System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.NotifyEN> notifications;






public virtual Nullable<DateTime> BirthDate {
        get { return birthDate; } set { birthDate = value;  }
}



public virtual string Address {
        get { return address; } set { address = value;  }
}



public virtual string Surnames {
        get { return surnames; } set { surnames = value;  }
}



public virtual string Phone {
        get { return phone; } set { phone = value;  }
}



public virtual string Photo {
        get { return photo; } set { photo = value;  }
}



public virtual bool IsActive {
        get { return isActive; } set { isActive = value;  }
}



public virtual MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum Type {
        get { return type; } set { type = value;  }
}



public virtual bool IsDiseased {
        get { return isDiseased; } set { isDiseased = value;  }
}



public virtual String Pass {
        get { return pass; } set { pass = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Name {
        get { return name; } set { name = value;  }
}



public virtual string Description {
        get { return description; } set { description = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RelatedPersonEN> RelatedPerson {
        get { return relatedPerson; } set { relatedPerson = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PractitionerEN> Practitioner {
        get { return practitioner; } set { practitioner = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PatientEN> Patient {
        get { return patient; } set { patient = value;  }
}



public virtual System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.NotifyEN> Notifications {
        get { return notifications; } set { notifications = value;  }
}





public UserEN()
{
        relatedPerson = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.RelatedPersonEN>();
        practitioner = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.PractitionerEN>();
        patient = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.PatientEN>();
        notifications = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.NotifyEN>();
}



public UserEN(int id, Nullable<DateTime> birthDate, string address, string surnames, string phone, string photo, bool isActive, MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum type, bool isDiseased, String pass, string name, string description, string email, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RelatedPersonEN> relatedPerson, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PractitionerEN> practitioner, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PatientEN> patient, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.NotifyEN> notifications
              )
{
        this.init (Id, birthDate, address, surnames, phone, photo, isActive, type, isDiseased, pass, name, description, email, relatedPerson, practitioner, patient, notifications);
}


public UserEN(UserEN user)
{
        this.init (Id, user.BirthDate, user.Address, user.Surnames, user.Phone, user.Photo, user.IsActive, user.Type, user.IsDiseased, user.Pass, user.Name, user.Description, user.Email, user.RelatedPerson, user.Practitioner, user.Patient, user.Notifications);
}

private void init (int id
                   , Nullable<DateTime> birthDate, string address, string surnames, string phone, string photo, bool isActive, MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum type, bool isDiseased, String pass, string name, string description, string email, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.RelatedPersonEN> relatedPerson, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PractitionerEN> practitioner, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.PatientEN> patient, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.NotifyEN> notifications)
{
        this.Id = id;


        this.BirthDate = birthDate;

        this.Address = address;

        this.Surnames = surnames;

        this.Phone = phone;

        this.Photo = photo;

        this.IsActive = isActive;

        this.Type = type;

        this.IsDiseased = isDiseased;

        this.Pass = pass;

        this.Name = name;

        this.Description = description;

        this.Email = email;

        this.RelatedPerson = relatedPerson;

        this.Practitioner = practitioner;

        this.Patient = patient;

        this.Notifications = notifications;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UserEN t = obj as UserEN;
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
