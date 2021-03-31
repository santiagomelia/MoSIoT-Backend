
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface ICommandCAD
{
CommandEN ReadOIDDefault (int id
                          );

void ModifyDefault (CommandEN command);

System.Collections.Generic.IList<CommandEN> ReadAllDefault (int first, int size);



int New_ (CommandEN command);

void Modify (CommandEN command);


void Destroy (int id
              );


CommandEN ReadOID (int id
                   );


System.Collections.Generic.IList<CommandEN> ReadAll (int first, int size);
}
}
