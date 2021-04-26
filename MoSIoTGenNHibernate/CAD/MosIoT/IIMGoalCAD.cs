
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IIMGoalCAD
{
IMGoalEN ReadOIDDefault (int id
                         );

void ModifyDefault (IMGoalEN iMGoal);

System.Collections.Generic.IList<IMGoalEN> ReadAllDefault (int first, int size);



int New_ (IMGoalEN iMGoal);

void Modify (IMGoalEN iMGoal);


void Destroy (int id
              );


IMGoalEN ReadOID (int id
                  );


System.Collections.Generic.IList<IMGoalEN> ReadAll (int first, int size);
}
}
