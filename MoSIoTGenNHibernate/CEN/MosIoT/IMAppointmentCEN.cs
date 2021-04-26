

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
 *      Definition of the class IMAppointmentCEN
 *
 */
public partial class IMAppointmentCEN
{
private IIMAppointmentCAD _IIMAppointmentCAD;

public IMAppointmentCEN()
{
        this._IIMAppointmentCAD = new IMAppointmentCAD ();
}

public IMAppointmentCEN(IIMAppointmentCAD _IIMAppointmentCAD)
{
        this._IIMAppointmentCAD = _IIMAppointmentCAD;
}

public IIMAppointmentCAD get_IIMAppointmentCAD ()
{
        return this._IIMAppointmentCAD;
}

public int New_ (string p_name, int p_scenario, string p_description, Nullable<DateTime> p_date, int p_appointment)
{
        IMAppointmentEN iMAppointmentEN = null;
        int oid;

        //Initialized IMAppointmentEN
        iMAppointmentEN = new IMAppointmentEN ();
        iMAppointmentEN.Name = p_name;


        if (p_scenario != -1) {
                // El argumento p_scenario -> Property scenario es oid = false
                // Lista de oids id
                iMAppointmentEN.Scenario = new MoSIoTGenNHibernate.EN.MosIoT.IoTScenarioEN ();
                iMAppointmentEN.Scenario.Id = p_scenario;
        }

        iMAppointmentEN.Description = p_description;

        iMAppointmentEN.Date = p_date;


        if (p_appointment != -1) {
                // El argumento p_appointment -> Property appointment es oid = false
                // Lista de oids id
                iMAppointmentEN.Appointment = new MoSIoTGenNHibernate.EN.MosIoT.AppointmentEN ();
                iMAppointmentEN.Appointment.Id = p_appointment;
        }

        //Call to IMAppointmentCAD

        oid = _IIMAppointmentCAD.New_ (iMAppointmentEN);
        return oid;
}

public void Modify (int p_IMAppointment_OID, string p_name, string p_description, Nullable<DateTime> p_date)
{
        IMAppointmentEN iMAppointmentEN = null;

        //Initialized IMAppointmentEN
        iMAppointmentEN = new IMAppointmentEN ();
        iMAppointmentEN.Id = p_IMAppointment_OID;
        iMAppointmentEN.Name = p_name;
        iMAppointmentEN.Description = p_description;
        iMAppointmentEN.Date = p_date;
        //Call to IMAppointmentCAD

        _IIMAppointmentCAD.Modify (iMAppointmentEN);
}

public void Destroy (int id
                     )
{
        _IIMAppointmentCAD.Destroy (id);
}

public IMAppointmentEN ReadOID (int id
                                )
{
        IMAppointmentEN iMAppointmentEN = null;

        iMAppointmentEN = _IIMAppointmentCAD.ReadOID (id);
        return iMAppointmentEN;
}

public System.Collections.Generic.IList<IMAppointmentEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<IMAppointmentEN> list = null;

        list = _IIMAppointmentCAD.ReadAll (first, size);
        return list;
}
}
}
