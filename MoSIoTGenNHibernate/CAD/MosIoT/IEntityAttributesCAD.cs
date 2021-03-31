
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IEntityAttributesCAD
{
EntityAttributesEN ReadOIDDefault (int id
                                   );

void ModifyDefault (EntityAttributesEN entityAttributes);

System.Collections.Generic.IList<EntityAttributesEN> ReadAllDefault (int first, int size);



int New_ (EntityAttributesEN entityAttributes);

void Modify (EntityAttributesEN entityAttributes);


void Destroy (int id
              );


EntityAttributesEN ReadOID (int id
                            );


System.Collections.Generic.IList<EntityAttributesEN> ReadAll (int first, int size);
}
}
