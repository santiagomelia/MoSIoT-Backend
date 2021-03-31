
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IDeviceTemplateCAD
{
DeviceTemplateEN ReadOIDDefault (int id
                                 );

void ModifyDefault (DeviceTemplateEN deviceTemplate);

System.Collections.Generic.IList<DeviceTemplateEN> ReadAllDefault (int first, int size);



int New_ (DeviceTemplateEN deviceTemplate);

void Modify (DeviceTemplateEN deviceTemplate);


void Destroy (int id
              );


DeviceTemplateEN ReadOID (int id
                          );


System.Collections.Generic.IList<DeviceTemplateEN> ReadAll (int first, int size);
}
}
