
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IHealthDataCAD
{
HealthDataEN ReadOIDDefault (int id
                             );

void ModifyDefault (HealthDataEN healthData);

System.Collections.Generic.IList<HealthDataEN> ReadAllDefault (int first, int size);



int New_ (HealthDataEN healthData);

void Modify (HealthDataEN healthData);


void Destroy (int id
              );
}
}
