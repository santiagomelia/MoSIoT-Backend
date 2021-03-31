
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMTelemetryCAD
{
IMTelemetryEN ReadOIDDefault (int id
                              );

void ModifyDefault (IMTelemetryEN iMTelemetry);

System.Collections.Generic.IList<IMTelemetryEN> ReadAllDefault (int first, int size);



int New_ (IMTelemetryEN iMTelemetry);

void Modify (IMTelemetryEN iMTelemetry);


void Destroy (int id
              );


IMTelemetryEN ReadOID (int id
                       );


System.Collections.Generic.IList<IMTelemetryEN> ReadAll (int first, int size);
}
}
