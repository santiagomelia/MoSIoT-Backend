using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class NotificationAssemblerDTO {
public static IList<NotificationEN> ConvertList (IList<NotificationDTO> lista)
{
        IList<NotificationEN> result = new List<NotificationEN>();
        foreach (NotificationDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static NotificationEN Convert (NotificationDTO dto)
{
        NotificationEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new NotificationEN ();



                        newinstance.Severity = dto.Severity;
                        newinstance.Message = dto.Message;
                        newinstance.SendDate = dto.SendDate;
                        if (dto.Receivers_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IUserCAD userCAD = new MoSIoTGenNHibernate.CAD.MosIoT.UserCAD ();

                                newinstance.Receivers = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.UserEN>();
                                foreach (string entry in dto.Receivers_oid) {
                                        newinstance.Receivers.Add (userCAD.ReadOIDDefault (entry));
                                }
                        }
                        if (dto.CarePlan_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICarePlanCAD carePlanCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CarePlanCAD ();

                                newinstance.CarePlan = carePlanCAD.ReadOIDDefault (dto.CarePlan_oid);
                        }
                        newinstance.Id = dto.Id;
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
