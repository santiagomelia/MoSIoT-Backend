using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenMosIoTRESTAzure.DTOA
{
public class StateTelemetryDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}



/* Rol: StateTelemetry o--> StateDevice */
private IList<StateDeviceDTOA> states;
public IList<StateDeviceDTOA> States
{
        get { return states; }
        set { states = value; }
}
}
}
