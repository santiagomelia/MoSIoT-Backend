
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface INotificationCAD
{
NotificationEN ReadOIDDefault (int id
                               );

void ModifyDefault (NotificationEN notification);

System.Collections.Generic.IList<NotificationEN> ReadAllDefault (int first, int size);



int New_ (NotificationEN notification);

void Modify (NotificationEN notification);


void Destroy (int id
              );
}
}
