
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IDisabilityCAD
{
DisabilityEN ReadOIDDefault (int id
                             );

void ModifyDefault (DisabilityEN disability);

System.Collections.Generic.IList<DisabilityEN> ReadAllDefault (int first, int size);



int New_ (DisabilityEN disability);

void Modify (DisabilityEN disability);


void Destroy (int id
              );


DisabilityEN ReadOID (int id
                      );


System.Collections.Generic.IList<DisabilityEN> ReadAll (int first, int size);
}
}
