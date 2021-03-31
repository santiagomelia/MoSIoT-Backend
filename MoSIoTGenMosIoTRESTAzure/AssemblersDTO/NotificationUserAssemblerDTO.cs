using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class NotificationUserAssemblerDTO {
public static IList<NotificationUserEN> ConvertList (IList<NotificationUserDTO> lista)
{
        IList<NotificationUserEN> result = new List<NotificationUserEN>();
        foreach (NotificationUserDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static NotificationUserEN Convert (NotificationUserDTO dto)
{
        NotificationUserEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new NotificationUserEN ();



                        if (dto.Notification_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.INotificationCAD notificationCAD = new MoSIoTGenNHibernate.CAD.MosIoT.NotificationCAD ();

                                newinstance.Notification = notificationCAD.ReadOIDDefault (dto.Notification_oid);
                        }
                        newinstance.Id = dto.Id;
                        if (dto.User_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IUserCAD userCAD = new MoSIoTGenNHibernate.CAD.MosIoT.UserCAD ();

                                newinstance.User = userCAD.ReadOIDDefault (dto.User_oid);
                        }
                        newinstance.IsReceived = dto.IsReceived;
                }
        }
        catch (Exception ex)
        {
                throw ex;
        }
        return newinstance;
}
}
}
