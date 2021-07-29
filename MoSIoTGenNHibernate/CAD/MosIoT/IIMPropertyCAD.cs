
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMPropertyCAD
{
IMPropertyEN ReadOIDDefault (int id
                             );

void ModifyDefault (IMPropertyEN iMProperty);

System.Collections.Generic.IList<IMPropertyEN> ReadAllDefault (int first, int size);



int New_ (IMPropertyEN iMProperty);

void Modify (IMPropertyEN iMProperty);


void Destroy (int id
              );


IMPropertyEN ReadOID (int id
                      );


System.Collections.Generic.IList<IMPropertyEN> ReadAll (int first, int size);


void AssignProperty (int p_IMProperty_OID, int p_property_OID);
}
}
