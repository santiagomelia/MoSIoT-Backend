
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IRuleConditionCAD
{
RuleConditionEN ReadOIDDefault (int id
                                );

void ModifyDefault (RuleConditionEN ruleCondition);

System.Collections.Generic.IList<RuleConditionEN> ReadAllDefault (int first, int size);



int New_ (RuleConditionEN ruleCondition);

void Modify (RuleConditionEN ruleCondition);


void Destroy (int id
              );


RuleConditionEN ReadOID (int id
                         );


System.Collections.Generic.IList<RuleConditionEN> ReadAll (int first, int size);
}
}
