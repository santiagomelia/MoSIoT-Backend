
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMCommandCAD
{
IMCommandEN ReadOIDDefault (int id
                            );

void ModifyDefault (IMCommandEN iMCommand);

System.Collections.Generic.IList<IMCommandEN> ReadAllDefault (int first, int size);



int New_ (IMCommandEN iMCommand);

void Modify (IMCommandEN iMCommand);


void Destroy (int id
              );


IMCommandEN ReadOID (int id
                     );


System.Collections.Generic.IList<IMCommandEN> ReadAll (int first, int size);
}
}
