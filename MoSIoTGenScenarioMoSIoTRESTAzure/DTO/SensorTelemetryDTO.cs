using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class SensorTelemetryDTO                 :                           SpecificTelemetryDTO


{
private string sensorType;
public string SensorType {
        get { return sensorType; } set { sensorType = value;  }
}
}
}
