
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMTelemetryValuesCAD
{
IMTelemetryValuesEN ReadOIDDefault (int id
                                    );

void ModifyDefault (IMTelemetryValuesEN iMTelemetryValues);

System.Collections.Generic.IList<IMTelemetryValuesEN> ReadAllDefault (int first, int size);



int New_ (IMTelemetryValuesEN iMTelemetryValues);

void Modify (IMTelemetryValuesEN iMTelemetryValues);


void Destroy (int id
              );


IMTelemetryValuesEN ReadOID (int id
                             );


System.Collections.Generic.IList<IMTelemetryValuesEN> ReadAll (int first, int size);
}
}
