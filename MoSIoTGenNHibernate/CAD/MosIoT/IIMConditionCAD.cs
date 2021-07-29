
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMConditionCAD
{
IMConditionEN ReadOIDDefault (int id
                              );

void ModifyDefault (IMConditionEN iMCondition);

System.Collections.Generic.IList<IMConditionEN> ReadAllDefault (int first, int size);



int New_ (IMConditionEN iMCondition);

void Modify (IMConditionEN iMCondition);


void Destroy (int id
              );


IMConditionEN ReadOID (int id
                       );


System.Collections.Generic.IList<IMConditionEN> ReadAll (int first, int size);


void AssignCondition (int p_IMCondition_OID, int p_condition_OID);
}
}
