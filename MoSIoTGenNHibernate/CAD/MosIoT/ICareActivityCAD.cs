
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ICareActivityCAD
{
CareActivityEN ReadOIDDefault (int id
                               );

void ModifyDefault (CareActivityEN careActivity);

System.Collections.Generic.IList<CareActivityEN> ReadAllDefault (int first, int size);



int New_ (CareActivityEN careActivity);

void Modify (CareActivityEN careActivity);


void Destroy (int id
              );


CareActivityEN ReadOID (int id
                        );


System.Collections.Generic.IList<CareActivityEN> ReadAll (int first, int size);
}
}
