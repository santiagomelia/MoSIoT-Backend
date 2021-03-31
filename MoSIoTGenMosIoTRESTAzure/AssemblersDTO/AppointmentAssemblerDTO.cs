using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class AppointmentAssemblerDTO {
public static IList<AppointmentEN> ConvertList (IList<AppointmentDTO> lista)
{
        IList<AppointmentEN> result = new List<AppointmentEN>();
        foreach (AppointmentDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static AppointmentEN Convert (AppointmentDTO dto)
{
        AppointmentEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new AppointmentEN ();



                        newinstance.Id = dto.Id;
                        newinstance.IsVirtual = dto.IsVirtual;
                        newinstance.Description = dto.Description;
                        newinstance.Direction = dto.Direction;
                        newinstance.ReasonCode = dto.ReasonCode;
                        if (dto.CareActivity_oid != -1) {
                                MoSIoTGenNHibernate.CAD.MosIoT.ICareActivityCAD careActivityCAD = new MoSIoTGenNHibernate.CAD.MosIoT.CareActivityCAD ();

                                newinstance.CareActivity = careActivityCAD.ReadOIDDefault (dto.CareActivity_oid);
                        }
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
