
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ILocationTelemetryCAD
{
LocationTelemetryEN ReadOIDDefault (int id
                                    );

void ModifyDefault (LocationTelemetryEN locationTelemetry);

System.Collections.Generic.IList<LocationTelemetryEN> ReadAllDefault (int first, int size);



int New_ (LocationTelemetryEN locationTelemetry);

void Modify (LocationTelemetryEN locationTelemetry);


void Destroy (int id
              );


LocationTelemetryEN ReadOID (int id
                             );


System.Collections.Generic.IList<LocationTelemetryEN> ReadAll (int first, int size);
}
}
