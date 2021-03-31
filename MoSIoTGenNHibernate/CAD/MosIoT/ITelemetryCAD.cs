
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ITelemetryCAD
{
TelemetryEN ReadOIDDefault (int id
                            );

void ModifyDefault (TelemetryEN telemetry);

System.Collections.Generic.IList<TelemetryEN> ReadAllDefault (int first, int size);



int New_ (TelemetryEN telemetry);

void Modify (TelemetryEN telemetry);


void Destroy (int id
              );


TelemetryEN ReadOID (int id
                     );


System.Collections.Generic.IList<TelemetryEN> ReadAll (int first, int size);


void AsignarSpecific (int p_Telemetry_OID, int p_typeTelemetry_OID);
}
}
