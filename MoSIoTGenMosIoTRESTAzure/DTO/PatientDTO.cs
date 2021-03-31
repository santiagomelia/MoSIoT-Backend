using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class PatientDTO                 :                           UserDTO


{
private int patientProfile_oid;
public int PatientProfile_oid {
        get { return patientProfile_oid; } set { patientProfile_oid = value;  }
}
}
}
