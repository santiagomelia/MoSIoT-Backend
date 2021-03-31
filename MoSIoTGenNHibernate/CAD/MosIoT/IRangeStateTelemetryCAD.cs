
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IRangeStateTelemetryCAD
{
RangeStateTelemetryEN ReadOIDDefault (int id
                                      );

void ModifyDefault (RangeStateTelemetryEN rangeStateTelemetry);

System.Collections.Generic.IList<RangeStateTelemetryEN> ReadAllDefault (int first, int size);



int New_ (RangeStateTelemetryEN rangeStateTelemetry);

void Modify (RangeStateTelemetryEN rangeStateTelemetry);


void Destroy (int id
              );


RangeStateTelemetryEN ReadOID (int id
                               );


System.Collections.Generic.IList<RangeStateTelemetryEN> ReadAll (int first, int size);
}
}
