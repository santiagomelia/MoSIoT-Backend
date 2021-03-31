
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ISpecificTelemetryCAD
{
SpecificTelemetryEN ReadOIDDefault (int id
                                    );

void ModifyDefault (SpecificTelemetryEN specificTelemetry);

System.Collections.Generic.IList<SpecificTelemetryEN> ReadAllDefault (int first, int size);



int New_ (SpecificTelemetryEN specificTelemetry);

void Modify (SpecificTelemetryEN specificTelemetry);


void Destroy (int id
              );


SpecificTelemetryEN ReadOID (int id
                             );


System.Collections.Generic.IList<SpecificTelemetryEN> ReadAll (int first, int size);
}
}
