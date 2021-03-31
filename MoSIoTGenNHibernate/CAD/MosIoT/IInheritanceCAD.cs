
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IInheritanceCAD
{
InheritanceEN ReadOIDDefault (int id
                              );

void ModifyDefault (InheritanceEN inheritance);

System.Collections.Generic.IList<InheritanceEN> ReadAllDefault (int first, int size);



int New_ (InheritanceEN inheritance);

void Modify (InheritanceEN inheritance);


void Destroy (int id
              );


InheritanceEN ReadOID (int id
                       );


System.Collections.Generic.IList<InheritanceEN> ReadAll (int first, int size);
}
}
