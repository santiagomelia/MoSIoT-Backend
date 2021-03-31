
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IRuleCAD
{
RuleEN ReadOIDDefault (int id
                       );

void ModifyDefault (RuleEN rule);

System.Collections.Generic.IList<RuleEN> ReadAllDefault (int first, int size);



int New_ (RuleEN rule);

void Modify (RuleEN rule);


void Destroy (int id
              );


RuleEN ReadOID (int id
                );


System.Collections.Generic.IList<RuleEN> ReadAll (int first, int size);
}
}
