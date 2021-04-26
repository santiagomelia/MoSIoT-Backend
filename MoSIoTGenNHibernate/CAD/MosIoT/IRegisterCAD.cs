
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IRegisterCAD
{
RegisterEN ReadOIDDefault (int id
                           );

void ModifyDefault (RegisterEN register);

System.Collections.Generic.IList<RegisterEN> ReadAllDefault (int first, int size);



int New_ (RegisterEN register);

void Modify (RegisterEN register);


void Destroy (int id
              );


RegisterEN ReadOID (int id
                    );


System.Collections.Generic.IList<RegisterEN> ReadAll (int first, int size);
}
}
