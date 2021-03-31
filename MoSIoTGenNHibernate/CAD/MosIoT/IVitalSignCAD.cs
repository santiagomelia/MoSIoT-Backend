
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IVitalSignCAD
{
VitalSignEN ReadOIDDefault (int id
                            );

void ModifyDefault (VitalSignEN vitalSign);

System.Collections.Generic.IList<VitalSignEN> ReadAllDefault (int first, int size);



int New_ (VitalSignEN vitalSign);

void Modify (VitalSignEN vitalSign);


void Destroy (int id
              );


VitalSignEN ReadOID (int id
                     );


System.Collections.Generic.IList<VitalSignEN> ReadAll (int first, int size);
}
}
