
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IPropertyCAD
{
PropertyEN ReadOIDDefault (int id
                           );

void ModifyDefault (PropertyEN property);

System.Collections.Generic.IList<PropertyEN> ReadAllDefault (int first, int size);



int New_ (PropertyEN property);

void Modify (PropertyEN property);


void Destroy (int id
              );


PropertyEN ReadOID (int id
                    );


System.Collections.Generic.IList<PropertyEN> ReadAll (int first, int size);
}
}
