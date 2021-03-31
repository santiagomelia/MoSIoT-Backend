
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IEventTelemetryCAD
{
EventTelemetryEN ReadOIDDefault (int id
                                 );

void ModifyDefault (EventTelemetryEN eventTelemetry);

System.Collections.Generic.IList<EventTelemetryEN> ReadAllDefault (int first, int size);



int New_ (EventTelemetryEN eventTelemetry);

void Modify (EventTelemetryEN eventTelemetry);


void Destroy (int id
              );


EventTelemetryEN ReadOID (int id
                          );


System.Collections.Generic.IList<EventTelemetryEN> ReadAll (int first, int size);
}
}
