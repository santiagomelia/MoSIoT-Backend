using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class IMConditionDTO                     :                           EntityAttributesDTO


{
private int condition_oid;
public int Condition_oid {
        get { return condition_oid; } set { condition_oid = value;  }
}
}
}
