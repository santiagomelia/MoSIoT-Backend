
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIoTScenarioCAD
{
IoTScenarioEN ReadOIDDefault (int id
                              );

void ModifyDefault (IoTScenarioEN ioTScenario);

System.Collections.Generic.IList<IoTScenarioEN> ReadAllDefault (int first, int size);



int New_ (IoTScenarioEN ioTScenario);

void Modify (IoTScenarioEN ioTScenario);


void Destroy (int id
              );


IoTScenarioEN ReadOID (int id
                       );


System.Collections.Generic.IList<IoTScenarioEN> ReadAll (int first, int size);
}
}
