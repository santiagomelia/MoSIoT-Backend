using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class StateTelemetryDTO                  :                           SpecificTelemetryDTO


{
private System.Collections.Generic.IList<StateDeviceDTO> rangeStates;
public System.Collections.Generic.IList<StateDeviceDTO> RangeStates {
        get { return rangeStates; } set { rangeStates = value;  }
}
}
}
