using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class UserDTO
{
private Nullable<DateTime> birthDate;
public Nullable<DateTime> BirthDate {
        get { return birthDate; } set { birthDate = value;  }
}
private string address;
public string Address {
        get { return address; } set { address = value;  }
}
private string surnames;
public string Surnames {
        get { return surnames; } set { surnames = value;  }
}
private string phone;
public string Phone {
        get { return phone; } set { phone = value;  }
}
private string photo;
public string Photo {
        get { return photo; } set { photo = value;  }
}
private bool isActive;
public bool IsActive {
        get { return isActive; } set { isActive = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.GenderTypeEnum Type {
        get { return type; } set { type = value;  }
}
private bool isDiseased;
public bool IsDiseased {
        get { return isDiseased; } set { isDiseased = value;  }
}
private String pass;
public String Pass {
        get { return pass; } set { pass = value;  }
}
private int id;
public int Id {
        get { return id; } set { id = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private string email;
public string Email {
        get { return email; } set { email = value;  }
}


private System.Collections.Generic.IList<int> relatedPerson_oid;
public System.Collections.Generic.IList<int> RelatedPerson_oid {
        get { return relatedPerson_oid; } set { relatedPerson_oid = value;  }
}



private System.Collections.Generic.IList<int> practitioner_oid;
public System.Collections.Generic.IList<int> Practitioner_oid {
        get { return practitioner_oid; } set { practitioner_oid = value;  }
}



private System.Collections.Generic.IList<int> patient_oid;
public System.Collections.Generic.IList<int> Patient_oid {
        get { return patient_oid; } set { patient_oid = value;  }
}



private System.Collections.Generic.IList<int> notifications_oid;
public System.Collections.Generic.IList<int> Notifications_oid {
        get { return notifications_oid; } set { notifications_oid = value;  }
}
}
}
