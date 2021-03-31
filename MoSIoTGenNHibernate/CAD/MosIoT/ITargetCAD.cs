
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ITargetCAD
{
TargetEN ReadOIDDefault (int id
                         );

void ModifyDefault (TargetEN target);

System.Collections.Generic.IList<TargetEN> ReadAllDefault (int first, int size);



int New_ (TargetEN target);

void Modify (TargetEN target);


void Destroy (int id
              );


TargetEN ReadOID (int id
                  );


System.Collections.Generic.IList<TargetEN> ReadAll (int first, int size);
}
}
