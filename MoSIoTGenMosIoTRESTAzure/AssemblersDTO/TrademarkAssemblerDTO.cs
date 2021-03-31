using System;
using System.Collections.Generic;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenMosIoTRESTAzure.DTO;

namespace MoSIoTGenMosIoTRESTAzure.AssemblersDTO
{
public class TrademarkAssemblerDTO {
public static IList<TrademarkEN> ConvertList (IList<TrademarkDTO> lista)
{
        IList<TrademarkEN> result = new List<TrademarkEN>();
        foreach (TrademarkDTO dto in lista) {
                result.Add (Convert (dto));
        }
        return result;
}


public static TrademarkEN Convert (TrademarkDTO dto)
{
        TrademarkEN newinstance = null;

        try
        {
                if (dto != null) {
                        newinstance = new TrademarkEN ();



                        newinstance.Id = dto.Id;
                        newinstance.Name = dto.Name;
                        if (dto.Device_oid != null) {
                                MoSIoTGenNHibernate.CAD.MosIoT.IDeviceCAD deviceCAD = new MoSIoTGenNHibernate.CAD.MosIoT.DeviceCAD ();

                                newinstance.Device = new System.Collections.Generic.List<MoSIoTGenNHibernate.EN.MosIoT.DeviceEN>();
                                foreach (int entry in dto.Device_oid) {
                                        newinstance.Device.Add (deviceCAD.ReadOIDDefault (entry));
                                }
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
