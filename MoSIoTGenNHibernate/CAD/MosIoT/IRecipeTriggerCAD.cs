
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface IRecipeTriggerCAD
{
RecipeTriggerEN ReadOIDDefault (int id
                                );

void ModifyDefault (RecipeTriggerEN recipeTrigger);

System.Collections.Generic.IList<RecipeTriggerEN> ReadAllDefault (int first, int size);



int New_ (RecipeTriggerEN recipeTrigger);

void Modify (RecipeTriggerEN recipeTrigger);


void Destroy (int id
              );


RecipeTriggerEN ReadOID (int id
                         );


System.Collections.Generic.IList<RecipeTriggerEN> ReadAll (int first, int size);
}
}
