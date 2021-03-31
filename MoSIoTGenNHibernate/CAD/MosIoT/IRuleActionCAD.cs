
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IRuleActionCAD
{
RuleActionEN ReadOIDDefault (int id
                             );

void ModifyDefault (RuleActionEN ruleAction);

System.Collections.Generic.IList<RuleActionEN> ReadAllDefault (int first, int size);



int New_ (RuleActionEN ruleAction);

void Modify (RuleActionEN ruleAction);


void Destroy (int id
              );


RuleActionEN ReadOID (int id
                      );


System.Collections.Generic.IList<RuleActionEN> ReadAll (int first, int size);
}
}
