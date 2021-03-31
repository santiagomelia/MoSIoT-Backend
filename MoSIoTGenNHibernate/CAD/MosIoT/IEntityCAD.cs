
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IEntityCAD
{
EntityEN ReadOIDDefault (int id
                         );

void ModifyDefault (EntityEN entity);

System.Collections.Generic.IList<EntityEN> ReadAllDefault (int first, int size);



int New_ (EntityEN entity);

void Modify (EntityEN entity);


void Destroy (int id
              );


EntityEN ReadOID (int id
                  );


System.Collections.Generic.IList<EntityEN> ReadAll (int first, int size);
}
}
