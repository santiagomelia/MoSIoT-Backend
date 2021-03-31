
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IEntityStateCAD
{
EntityStateEN ReadOIDDefault (int id
                              );

void ModifyDefault (EntityStateEN entityState);

System.Collections.Generic.IList<EntityStateEN> ReadAllDefault (int first, int size);



int New_ (EntityStateEN entityState);

void Modify (EntityStateEN entityState);


void Destroy (int id
              );
}
}
