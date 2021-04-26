using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class PatientAccessDTO                   :                           EntityDTO


{
private int accessMode_oid;
public int AccessMode_oid {
        get { return accessMode_oid; } set { accessMode_oid = value;  }
}
}
}
