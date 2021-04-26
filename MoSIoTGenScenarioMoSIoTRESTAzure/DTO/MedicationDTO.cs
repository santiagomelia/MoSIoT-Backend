using System;
using System.Runtime.Serialization;
using MoSIoTGenNHibernate.EN.MosIoT;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTO
{
public partial class MedicationDTO
{
private int careActivity_oid;
public int CareActivity_oid {
        get { return careActivity_oid; } set { careActivity_oid = value;  }
}

private int productReference;
public int ProductReference {
        get { return productReference; } set { productReference = value;  }
}
private string name;
public string Name {
        get { return name; } set { name = value;  }
}
private string manufacturer;
public string Manufacturer {
        get { return manufacturer; } set { manufacturer = value;  }
}
private string description;
public string Description {
        get { return description; } set { description = value;  }
}
private string dosage;
public string Dosage {
        get { return dosage; } set { dosage = value;  }
}
private MoSIoTGenNHibernate.Enumerated.MosIoT.FormTypeEnum form;
public MoSIoTGenNHibernate.Enumerated.MosIoT.FormTypeEnum Form {
        get { return form; } set { form = value;  }
}
private string medicationCode;
public string MedicationCode {
        get { return medicationCode; } set { medicationCode = value;  }
}
}
}
