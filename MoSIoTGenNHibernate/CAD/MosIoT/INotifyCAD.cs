
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface INotifyCAD
{
NotifyEN ReadOIDDefault (int id
                         );

void ModifyDefault (NotifyEN notify);

System.Collections.Generic.IList<NotifyEN> ReadAllDefault (int first, int size);



int New_ (NotifyEN notify);

void Modify (NotifyEN notify);


void Destroy (int id
              );


NotifyEN ReadOID (int id
                  );


System.Collections.Generic.IList<NotifyEN> ReadAll (int first, int size);
}
}
