using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class PatientDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
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


/* Rol: Patient o--> PatientProfile */
private PatientProfileDTOA patientProfile;
public PatientProfileDTOA PatientProfile
{
        get { return patientProfile; }
        set { patientProfile = value; }
}

/* Rol: Patient o--> User */
private UserDTOA userData;
public UserDTOA UserData
{
        get { return userData; }
        set { userData = value; }
}
}
}
