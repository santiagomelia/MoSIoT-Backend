using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class IMMedicationDTO                    :                           EntityAttributesDTO


{
private int medication_oid;
public int Medication_oid {
        get { return medication_oid; } set { medication_oid = value;  }
}
}
}
