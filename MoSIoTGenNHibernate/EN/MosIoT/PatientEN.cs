
using System;
// Definición clase PatientEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class PatientEN                                                                      : MoSIoTGenNHibernate.EN.MosIoT.UserEN


{
/**
 *	Atributo patientProfile
 */
private MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile;






public virtual MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN PatientProfile {
        get { return patientProfile; } set { patientProfile = value;  }
}





public PatientEN() : base ()
{
}



public PatientEN(int id, MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile
                 , Nullable<DateTime> birthDate, string address, string surnames, string phone, string photo, bool isActive, MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum type, bool isDiseased, String pass, string name, string description, string email
                 )
{
        this.init (Id, patientProfile, birthDate, address, surnames, phone, photo, isActive, type, isDiseased, pass, name, description, email);
}


public PatientEN(PatientEN patient)
{
        this.init (Id, patient.PatientProfile, patient.BirthDate, patient.Address, patient.Surnames, patient.Phone, patient.Photo, patient.IsActive, patient.Type, patient.IsDiseased, patient.Pass, patient.Name, patient.Description, patient.Email);
}

private void init (int id
                   , MoSIoTGenNHibernate.EN.MosIoT.PatientProfileEN patientProfile, Nullable<DateTime> birthDate, string address, string surnames, string phone, string photo, bool isActive, MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum type, bool isDiseased, String pass, string name, string description, string email)
{
        this.Id = id;


        this.PatientProfile = patientProfile;

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
        PatientEN t = obj as PatientEN;
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
