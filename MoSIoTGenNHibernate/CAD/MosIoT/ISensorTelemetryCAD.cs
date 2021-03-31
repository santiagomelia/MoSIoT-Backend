
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ISensorTelemetryCAD
{
SensorTelemetryEN ReadOIDDefault (int id
                                  );

void ModifyDefault (SensorTelemetryEN sensorTelemetry);

System.Collections.Generic.IList<SensorTelemetryEN> ReadAllDefault (int first, int size);



int New_ (SensorTelemetryEN sensorTelemetry);

void Modify (SensorTelemetryEN sensorTelemetry);


void Destroy (int id
              );


SensorTelemetryEN ReadOID (int id
                           );


System.Collections.Generic.IList<SensorTelemetryEN> ReadAll (int first, int size);
}
}
