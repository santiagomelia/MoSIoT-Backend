using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenMosIoTRESTAzure.DTO
{
public partial class LocationTelemetryDTO               :                           SpecificTelemetryDTO


{
private int latitude;
public int Latitude {
        get { return latitude; } set { latitude = value;  }
}
private int longitude;
public int Longitude {
        get { return longitude; } set { longitude = value;  }
}
private int altitude;
public int Altitude {
        get { return altitude; } set { altitude = value;  }
}
}
}
