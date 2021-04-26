

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
 *      Definition of the class NotifyCEN
 *
 */
public partial class NotifyCEN
{
private INotifyCAD _INotifyCAD;

public NotifyCEN()
{
        this._INotifyCAD = new NotifyCAD ();
}

public NotifyCEN(INotifyCAD _INotifyCAD)
{
        this._INotifyCAD = _INotifyCAD;
}

public INotifyCAD get_INotifyCAD ()
{
        return this._INotifyCAD;
}

public int New_ (string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum p_serviceType, string p_description, int p_entity)
{
        NotifyEN notifyEN = null;
        int oid;

        //Initialized NotifyEN
        notifyEN = new NotifyEN ();
        notifyEN.Name = p_name;

        notifyEN.Type = p_type;

        notifyEN.ServiceType = p_serviceType;

        notifyEN.Description = p_description;


        if (p_entity != -1) {
                // El argumento p_entity -> Property entity es oid = false
                // Lista de oids id
                notifyEN.Entity = new MoSIoTGenNHibernate.EN.MosIoT.EntityEN ();
                notifyEN.Entity.Id = p_entity;
        }

        //Call to NotifyCAD

        oid = _INotifyCAD.New_ (notifyEN);
        return oid;
}

public void Modify (int p_Notify_OID, string p_name, MoSIoTGenNHibernate.Enumerated.MosIoT.DataTypeEnum p_type, MoSIoTGenNHibernate.Enumerated.MosIoT.ServiceTypeEnum p_serviceType, string p_description)
{
        NotifyEN notifyEN = null;

        //Initialized NotifyEN
        notifyEN = new NotifyEN ();
        notifyEN.Id = p_Notify_OID;
        notifyEN.Name = p_name;
        notifyEN.Type = p_type;
        notifyEN.ServiceType = p_serviceType;
        notifyEN.Description = p_description;
        //Call to NotifyCAD

        _INotifyCAD.Modify (notifyEN);
}

public void Destroy (int id
                     )
{
        _INotifyCAD.Destroy (id);
}

public NotifyEN ReadOID (int id
                         )
{
        NotifyEN notifyEN = null;

        notifyEN = _INotifyCAD.ReadOID (id);
        return notifyEN;
}

public System.Collections.Generic.IList<NotifyEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<NotifyEN> list = null;

        list = _INotifyCAD.ReadAll (first, size);
        return list;
}
}
}
