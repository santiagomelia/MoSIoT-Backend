

using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using MoSIoTGenNHibernate.Exceptions;

using MoSIoTGenNHibernate.EN.MosIoT;
using MoSIoTGenNHibernate.CAD.MosIoT;


namespace MoSIoTGenNHibernate.CEN.MosIoT
{
/*
 *      Definition of the class CommandCEN
 *
 */
public partial class CommandCEN
{
private ICommandCAD _ICommandCAD;

public CommandCEN()
{
        this._ICommandCAD = new CommandCAD ();
}

public CommandCEN(ICommandCAD _ICommandCAD)
{
        this._ICommandCAD = _ICommandCAD;
}

public ICommandCAD get_ICommandCAD ()
{
        return this._ICommandCAD;
}

public int New_ (int p_deviceTemplate, string p_name, bool p_isSynchronous, MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum p_type, string p_description)
{
        CommandEN commandEN = null;
        int oid;

        //Initialized CommandEN
        commandEN = new CommandEN ();

        if (p_deviceTemplate != -1) {
                // El argumento p_deviceTemplate -> Property deviceTemplate es oid = false
                // Lista de oids id
                commandEN.DeviceTemplate = new MoSIoTGenNHibernate.EN.MosIoT.DeviceTemplateEN ();
                commandEN.DeviceTemplate.Id = p_deviceTemplate;
        }

        commandEN.Name = p_name;

        commandEN.IsSynchronous = p_isSynchronous;

        commandEN.Type = p_type;

        commandEN.Description = p_description;

        //Call to CommandCAD

        oid = _ICommandCAD.New_ (commandEN);
        return oid;
}

public void Modify (int p_Command_OID, string p_name, bool p_isSynchronous, MoSIoTGenNHibernate.Enumerated.MosIoT.OperationTypeEnum p_type, string p_description)
{
        CommandEN commandEN = null;

        //Initialized CommandEN
        commandEN = new CommandEN ();
        commandEN.Id = p_Command_OID;
        commandEN.Name = p_name;
        commandEN.IsSynchronous = p_isSynchronous;
        commandEN.Type = p_type;
        commandEN.Description = p_description;
        //Call to CommandCAD

        _ICommandCAD.Modify (commandEN);
}

public void Destroy (int id
                     )
{
        _ICommandCAD.Destroy (id);
}

public CommandEN ReadOID (int id
                          )
{
        CommandEN commandEN = null;

        commandEN = _ICommandCAD.ReadOID (id);
        return commandEN;
}

public System.Collections.Generic.IList<CommandEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CommandEN> list = null;

        list = _ICommandCAD.ReadAll (first, size);
        return list;
}
}
}
