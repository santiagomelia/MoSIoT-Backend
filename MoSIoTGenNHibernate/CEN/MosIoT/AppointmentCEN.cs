

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
 *      Definition of the class AppointmentCEN
 *
 */
public partial class AppointmentCEN
{
private IAppointmentCAD _IAppointmentCAD;

public AppointmentCEN()
{
        this._IAppointmentCAD = new AppointmentCAD ();
}

public AppointmentCEN(IAppointmentCAD _IAppointmentCAD)
{
        this._IAppointmentCAD = _IAppointmentCAD;
}

public IAppointmentCAD get_IAppointmentCAD ()
{
        return this._IAppointmentCAD;
}

public int New_ (bool p_isVirtual, string p_description, string p_direction, string p_reasonCode, int p_careActivity)
{
        AppointmentEN appointmentEN = null;
        int oid;

        //Initialized AppointmentEN
        appointmentEN = new AppointmentEN ();
        appointmentEN.IsVirtual = p_isVirtual;

        appointmentEN.Description = p_description;

        appointmentEN.Direction = p_direction;

        appointmentEN.ReasonCode = p_reasonCode;


        if (p_careActivity != -1) {
                // El argumento p_careActivity -> Property careActivity es oid = false
                // Lista de oids id
                appointmentEN.CareActivity = new MoSIoTGenNHibernate.EN.MosIoT.CareActivityEN ();
                appointmentEN.CareActivity.Id = p_careActivity;
        }

        //Call to AppointmentCAD

        oid = _IAppointmentCAD.New_ (appointmentEN);
        return oid;
}

public void Modify (int p_Appointment_OID, bool p_isVirtual, string p_description, string p_direction, string p_reasonCode)
{
        AppointmentEN appointmentEN = null;

        //Initialized AppointmentEN
        appointmentEN = new AppointmentEN ();
        appointmentEN.Id = p_Appointment_OID;
        appointmentEN.IsVirtual = p_isVirtual;
        appointmentEN.Description = p_description;
        appointmentEN.Direction = p_direction;
        appointmentEN.ReasonCode = p_reasonCode;
        //Call to AppointmentCAD

        _IAppointmentCAD.Modify (appointmentEN);
}

public void Destroy (int id
                     )
{
        _IAppointmentCAD.Destroy (id);
}

public AppointmentEN ReadOID (int id
                              )
{
        AppointmentEN appointmentEN = null;

        appointmentEN = _IAppointmentCAD.ReadOID (id);
        return appointmentEN;
}

public System.Collections.Generic.IList<AppointmentEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AppointmentEN> list = null;

        list = _IAppointmentCAD.ReadAll (first, size);
        return list;
}
}
}
