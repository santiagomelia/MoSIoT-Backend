
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IConditionCAD
{
ConditionEN ReadOIDDefault (int id
                            );

void ModifyDefault (ConditionEN condition);

System.Collections.Generic.IList<ConditionEN> ReadAllDefault (int first, int size);



int New_ (ConditionEN condition);

void Modify (ConditionEN condition);


void Destroy (int id
              );


ConditionEN ReadOID (int id
                     );


System.Collections.Generic.IList<ConditionEN> ReadAll (int first, int size);
}
}
