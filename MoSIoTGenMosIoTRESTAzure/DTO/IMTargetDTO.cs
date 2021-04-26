using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class IMTargetDTO                :                           EntityAttributesDTO


{
private int target_oid;
public int Target_oid {
        get { return target_oid; } set { target_oid = value;  }
}
}
}
