using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;

namespace MoSIoTGenScenarioMoSIoTRESTAzure.DTOA
{
public class IMPropertyDTOA
{
private int id;
public int Id
{
        get { return id; }
        set { id = value; }
}


private string name;
public string Name
{
        get { return name; }
        set { name = value; }
}

private MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum type;
public MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum Type
{
        get { return type; }
        set { type = value; }
}

private string value;
public string Value
{
        get { return value; }
        set { value = value; }
}


/* Rol: IMProperty o--> Property */
private PropertyDTOA valueProperty;
public PropertyDTOA ValueProperty
{
        get { return valueProperty; }
        set { valueProperty = value; }
}
}
}
