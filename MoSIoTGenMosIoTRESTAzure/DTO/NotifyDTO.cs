using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class NotifyDTO                  :                           EntityOperationDTO


{
private System.Collections.Generic.IList<int> users_oid;
public System.Collections.Generic.IList<int> Users_oid {
        get { return users_oid; } set { users_oid = value;  }
}
}
}
