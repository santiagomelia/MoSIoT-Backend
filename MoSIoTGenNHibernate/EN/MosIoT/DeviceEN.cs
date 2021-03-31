
using System;
// Definición clase DeviceEN
namespace MoSIoTGenNHibernate.EN.MosIoT
{
public partial class DeviceEN                                                                       : MoSIoTGenNHibernate.EN.MosIoT.EntityEN


{
/**
 *	Atributo deviceSwitch
 */
private bool deviceSwitch;



/**
 *	Atributo tag
 */
private string tag;



/**
 *	Atributo isSimulated
 */
private bool isSimulated;



/**
 *	Atributo serialNumber
 */
private string serialNumber;



/**
 *	Atributo firmVersion
 */
private string firmVersion;



/**
 *	Atributo trademark
 */
private string trademark;



/**
 *	Atributo deviceTemplate
 */
private MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate;






public virtual bool DeviceSwitch {
        get { return deviceSwitch; } set { deviceSwitch = value;  }
}



public virtual string Tag {
        get { return tag; } set { tag = value;  }
}



public virtual bool IsSimulated {
        get { return isSimulated; } set { isSimulated = value;  }
}



public virtual string SerialNumber {
        get { return serialNumber; } set { serialNumber = value;  }
}



public virtual string FirmVersion {
        get { return firmVersion; } set { firmVersion = value;  }
}



public virtual string Trademark {
        get { return trademark; } set { trademark = value;  }
}



public virtual MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN DeviceTemplate {
        get { return deviceTemplate; } set { deviceTemplate = value;  }
}





public DeviceEN() : base ()
{
}



public DeviceEN(int id, bool deviceSwitch, string tag, bool isSimulated, string serialNumber, string firmVersion, string trademark, MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate
                , string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states
                )
{
        this.init (Id, deviceSwitch, tag, isSimulated, serialNumber, firmVersion, trademark, deviceTemplate, name, originAssociation, targetAssociation, scenario, description, operations, attributes, states);
}


public DeviceEN(DeviceEN device)
{
        this.init (Id, device.DeviceSwitch, device.Tag, device.IsSimulated, device.SerialNumber, device.FirmVersion, device.Trademark, device.DeviceTemplate, device.Name, device.OriginAssociation, device.TargetAssociation, device.Scenario, device.Description, device.Operations, device.Attributes, device.States);
}

private void init (int id
                   , bool deviceSwitch, string tag, bool isSimulated, string serialNumber, string firmVersion, string trademark, MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN deviceTemplate, string name, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> originAssociation, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.AssociationEN> targetAssociation, MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN scenario, string description, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityOperationEN> operations, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityAttributesEN> attributes, System.Collections.Generic.IList<MoSIoTGenNHibernate.EN.MosIoT.EntityStateEN> states)
{
        this.Id = id;


        this.DeviceSwitch = deviceSwitch;

        this.Tag = tag;

        this.IsSimulated = isSimulated;

        this.SerialNumber = serialNumber;

        this.FirmVersion = firmVersion;

        this.Trademark = trademark;

        this.DeviceTemplate = deviceTemplate;

        this.Name = name;

        this.OriginAssociation = originAssociation;

        this.TargetAssociation = targetAssociation;

        this.Scenario = scenario;

        this.Description = description;

        this.Operations = operations;

        this.Attributes = attributes;

        this.States = states;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        DeviceEN t = obj as DeviceEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
