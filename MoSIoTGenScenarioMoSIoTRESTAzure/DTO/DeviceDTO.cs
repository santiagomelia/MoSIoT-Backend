using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class DeviceDTO                  :                           EntityDTO


{
private bool deviceSwitch;
public bool DeviceSwitch {
        get { return deviceSwitch; } set { deviceSwitch = value;  }
}
private string tag;
public string Tag {
        get { return tag; } set { tag = value;  }
}
private bool isSimulated;
public bool IsSimulated {
        get { return isSimulated; } set { isSimulated = value;  }
}
private string serialNumber;
public string SerialNumber {
        get { return serialNumber; } set { serialNumber = value;  }
}
private string firmVersion;
public string FirmVersion {
        get { return firmVersion; } set { firmVersion = value;  }
}
private string trademark;
public string Trademark {
        get { return trademark; } set { trademark = value;  }
}


private int deviceTemplate_oid;
public int DeviceTemplate_oid {
        get { return deviceTemplate_oid; } set { deviceTemplate_oid = value;  }
}
}
}
