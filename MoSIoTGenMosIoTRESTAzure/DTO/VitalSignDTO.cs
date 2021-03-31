using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class VitalSignDTO               :                           EntityDTO


{
private int measure_oid;
public int Measure_oid {
        get { return measure_oid; } set { measure_oid = value;  }
}
}
}
