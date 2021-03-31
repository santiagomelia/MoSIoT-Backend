using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;

using MoSIoTGenMosIoTRESTAzure.DTOA;
using MoSIoTGenMosIoTRESTAzure.CAD;
using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CEN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;
using MoSIoTGenNHibernate.CP.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.Assemblers
{
public static class StateDeviceAssembler
{
public static StateDeviceDTOA Convert (StateDeviceEN en, NHibernate.ISession session = null)
{
        StateDeviceDTOA dto = null;
        StateDeviceRESTCAD stateDeviceRESTCAD = null;
        StateDeviceCEN stateDeviceCEN = null;
        StateDeviceCP stateDeviceCP = null;

        if (en != null) {
                dto = new StateDeviceDTOA ();
                stateDeviceRESTCAD = new StateDeviceRESTCAD (session);
                stateDeviceCEN = new StateDeviceCEN (stateDeviceRESTCAD);
                stateDeviceCP = new StateDeviceCP (session);





                //
                // Attributes

                dto.Id = en.Id;

                dto.Name = en.Name;


                dto.Value = en.Value;


                //
                // TravesalLink


                //
                // Service
        }

        return dto;
}
}
}
