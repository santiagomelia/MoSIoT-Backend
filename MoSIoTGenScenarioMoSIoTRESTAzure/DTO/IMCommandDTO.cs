using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class IMCommandDTO               :                           EntityOperationDTO


{
private int command_oid;
public int Command_oid {
        get { return command_oid; } set { command_oid = value;  }
}
}
}
