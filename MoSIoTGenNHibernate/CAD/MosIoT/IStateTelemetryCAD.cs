
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IStateTelemetryCAD
{
StateTelemetryEN ReadOIDDefault (int id
                                 );

void ModifyDefault (StateTelemetryEN stateTelemetry);

System.Collections.Generic.IList<StateTelemetryEN> ReadAllDefault (int first, int size);



int New_ (StateTelemetryEN stateTelemetry);

void Modify (StateTelemetryEN stateTelemetry);


void Destroy (int id
              );


StateTelemetryEN ReadOID (int id
                          );


System.Collections.Generic.IList<StateTelemetryEN> ReadAll (int first, int size);
}
}
