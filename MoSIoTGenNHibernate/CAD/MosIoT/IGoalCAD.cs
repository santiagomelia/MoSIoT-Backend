
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IGoalCAD
{
GoalEN ReadOIDDefault (int id
                       );

void ModifyDefault (GoalEN goal);

System.Collections.Generic.IList<GoalEN> ReadAllDefault (int first, int size);



int New_ (GoalEN goal);

void Modify (GoalEN goal);


void Destroy (int id
              );


GoalEN ReadOID (int id
                );


System.Collections.Generic.IList<GoalEN> ReadAll (int first, int size);
}
}
