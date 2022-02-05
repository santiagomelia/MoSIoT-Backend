using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class UserDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private Nullable<DateTime> birthDate;
public Nullable<DateTime> BirthDate
{
        get { return birthDate; }
        set { birthDate = value; }
}

private string surnames;
public string Surnames
{
        get { return surnames; }
        set { surnames = value; }
}

private string address;
public string Address
{
        get { return address; }
        set { address = value; }
}

private string phone;
public string Phone
{
        get { return phone; }
        set { phone = value; }
}

private string photo;
public string Photo
{
        get { return photo; }
        set { photo = value; }
}

private bool isActive;
public bool IsActive
{
        get { return isActive; }
        set { isActive = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum Type
{
        get { return type; }
        set { type = value; }
}

private bool isDiseased;
public bool IsDiseased
{
        get { return isDiseased; }
        set { isDiseased = value; }
}

private string email;
public string Email
{
        get { return email; }
        set { email = value; }
}

private string name;
public string Name
{
        get { return name; }
        set { name = value; }
}

private string description;
public string Description
{
        get { return description; }
        set { description = value; }
}
}
}
