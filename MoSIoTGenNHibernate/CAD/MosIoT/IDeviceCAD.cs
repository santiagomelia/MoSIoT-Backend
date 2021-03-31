
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IDeviceCAD
{
DeviceEN ReadOIDDefault (int id
                         );

void ModifyDefault (DeviceEN device);

System.Collections.Generic.IList<DeviceEN> ReadAllDefault (int first, int size);



int New_ (DeviceEN device);

void Modify (DeviceEN device);


void Destroy (int id
              );


DeviceEN ReadOID (int id
                  );


System.Collections.Generic.IList<DeviceEN> ReadAll (int first, int size);
}
}
