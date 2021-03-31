
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IStateDeviceCAD
{
StateDeviceEN ReadOIDDefault (int id
                              );

void ModifyDefault (StateDeviceEN stateDevice);

System.Collections.Generic.IList<StateDeviceEN> ReadAllDefault (int first, int size);



int New_ (StateDeviceEN stateDevice);

void Modify (StateDeviceEN stateDevice);


void Destroy (int id
              );


StateDeviceEN ReadOID (int id
                       );


System.Collections.Generic.IList<StateDeviceEN> ReadAll (int first, int size);
}
}
