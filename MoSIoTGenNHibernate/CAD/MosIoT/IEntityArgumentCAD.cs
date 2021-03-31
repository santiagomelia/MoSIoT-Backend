
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IEntityArgumentCAD
{
EntityArgumentEN ReadOIDDefault (int id
                                 );

void ModifyDefault (EntityArgumentEN entityArgument);

System.Collections.Generic.IList<EntityArgumentEN> ReadAllDefault (int first, int size);



int New_ (EntityArgumentEN entityArgument);

void Modify (EntityArgumentEN entityArgument);


void Destroy (int id
              );


EntityArgumentEN ReadOID (int id
                          );


System.Collections.Generic.IList<EntityArgumentEN> ReadAll (int first, int size);
}
}
