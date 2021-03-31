
using System;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenNHibernate.CAD.MosIoT
{
public partial interface INotificationUserCAD
{
NotificationUserEN ReadOIDDefault (int id
                                   );

void ModifyDefault (NotificationUserEN notificationUser);

System.Collections.Generic.IList<NotificationUserEN> ReadAllDefault (int first, int size);



int New_ (NotificationUserEN notificationUser);

void Modify (NotificationUserEN notificationUser);


void Destroy (int id
              );
}
}
