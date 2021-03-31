
using System;
// Definición clase RelatedPersonEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class RelatedPersonEN                                                                        : MoSIoTGenNHibernate.EN.MosIoT.UserEN


{
public RelatedPersonEN() : base ()
{
}



public RelatedPersonEN(int id,
                       Nullable<DateTime> birthDate, string address, string surnames, string phone, string photo, bool isActive, MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum type, bool isDiseased, String pass, string name, string description, string email
                       )
{
        this.init (Id, birthDate, address, surnames, phone, photo, isActive, type, isDiseased, pass, name, description, email);
}


public RelatedPersonEN(RelatedPersonEN relatedPerson)
{
        this.init (Id, relatedPerson.BirthDate, relatedPerson.Address, relatedPerson.Surnames, relatedPerson.Phone, relatedPerson.Photo, relatedPerson.IsActive, relatedPerson.Type, relatedPerson.IsDiseased, relatedPerson.Pass, relatedPerson.Name, relatedPerson.Description, relatedPerson.Email);
}

private void init (int id
                   , Nullable<DateTime> birthDate, string address, string surnames, string phone, string photo, bool isActive, MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum type, bool isDiseased, String pass, string name, string description, string email)
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
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        RelatedPersonEN t = obj as RelatedPersonEN;
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
