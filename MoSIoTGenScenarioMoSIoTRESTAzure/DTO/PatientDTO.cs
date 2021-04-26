using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class PatientDTO                 :                           EntityDTO


{
private int patientProfile_oid;
public int PatientProfile_oid {
        get { return patientProfile_oid; } set { patientProfile_oid = value;  }
}



private int userPatient_oid;
public int UserPatient_oid {
        get { return userPatient_oid; } set { userPatient_oid = value;  }
}
}
}
