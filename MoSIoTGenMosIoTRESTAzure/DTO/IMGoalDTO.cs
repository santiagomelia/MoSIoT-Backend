using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class IMGoalDTO                  :                           EntityAttributesDTO


{
private int goal_oid;
public int Goal_oid {
        get { return goal_oid; } set { goal_oid = value;  }
}
}
}
